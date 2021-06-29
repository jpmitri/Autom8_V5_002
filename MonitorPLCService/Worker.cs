using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using TwinCAT.Ads;

namespace MonitorPLCService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private List<Outlet> outlets;
        private HttpClient client;
        private List<Plc> plc;
        private Params_Get_Service_Data user;
        private AdsStream dataStream;
        private List<Outlet_Edit> _outlets;
        private TopLevel topLevel;
        private string responseString = string.Empty;
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            outlets = new();
            client = new();
            user = new();
            user.My_UserInfo = new();
            plc = new();
            dataStream = new();
            topLevel = new();
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            client.Dispose();
            _logger.LogInformation("The service has been stopped...");
            return base.StopAsync(cancellationToken);
        }
        public String Twincat2Read(Params_Twincat2Read i_Params_Twincat2Read)
        {
            try
            {
                using (TcAdsClient tcAdsClient = new())
                {
                    AmsNetId amsNetId = new(i_Params_Twincat2Read.AMSID);
                    tcAdsClient.Connect(amsNetId, int.Parse(i_Params_Twincat2Read.Port));
                    int varibalehande = tcAdsClient.CreateVariableHandle(i_Params_Twincat2Read.VariableName);
                    string res = tcAdsClient.ReadAny(varibalehande, varibalehande.GetType()).ToString(); ;
                    tcAdsClient.Dispose();
                    return res;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "There was a problem contacting the PLC");
                return null;
            }
        }
        public async void WriteChange(object sender, AdsNotificationEventArgs e)
        {
            try
            {
                Outlet_Edit toWrite = new();
                toWrite = _outlets.Where(x => x.PLCMonitor == e.NotificationHandle).First();
                Outlet toApi = new();
                toApi.OUTLET_ID = toWrite.OUTLET_ID;
                Params_Twincat2Read params_Twincat2Read = new();
                params_Twincat2Read.AMSID = toWrite.PlcAddress;
                params_Twincat2Read.Port = toWrite.Port + "";
                params_Twincat2Read.VariableName = toWrite.HW_link_name;
                toApi.CURRENT_VALUE = null;
                while (toApi.CURRENT_VALUE is null)
                {
                    toApi.CURRENT_VALUE = Twincat2Read(params_Twincat2Read);
                    if (toApi.CURRENT_VALUE is null)
                    {
                        await Task.Delay(5000);
                    }
                }
                string serOut = JsonConvert.SerializeObject(toApi);
                HttpContent content = new StringContent(serOut, Encoding.UTF8, "application/json");
                string request = ConfigurationManager.AppSettings["API"];
                request += "Edit_Outlet?ticket=";
                request += topLevel.MyResult.MyUserInfo.Ticket;

                HttpResponseMessage response = await client.PostAsync(request, content);
                responseString = await response.Content.ReadAsStringAsync();
                _logger.LogInformation(
                e.NotificationHandle, toWrite.HW_link_name);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "There was a problem contacting the Api");
            }
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            if (!stoppingToken.IsCancellationRequested)
            {
                bool loggedIn = false;

                while (!loggedIn)
                {
                    try
                    {
                        user.My_UserInfo.UserName = ConfigurationManager.AppSettings["USERNAME"];
                        user.My_UserInfo.Password = ConfigurationManager.AppSettings["ENCRYPTED_PASSWORD"];
                        string serOut = JsonConvert.SerializeObject(user);
                        HttpContent content = new StringContent(serOut, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PostAsync(ConfigurationManager.AppSettings["API"] + "Get_Service_Data", content);
                        responseString = await response.Content.ReadAsStringAsync();
                        loggedIn = true;
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "There was a problem contacting the Api");

                    }
                    finally
                    {
                        topLevel = JsonConvert.DeserializeObject<TopLevel>(responseString);
                    }
                    if (!loggedIn)
                    {
                        await Task.Delay(5000, stoppingToken);
                    }
                }
                _outlets = new();
                foreach (MyPlc plc in topLevel.MyResult.MyPlCs)
                {
                    foreach (MyHardwareLink Hardware in plc.MyHardwareLink)
                    {
                        foreach (MyOutlet outlet in Hardware.MyOutlet)
                        {
                            Outlet_Edit outlet_Edit = new();
                            outlet_Edit.OUTLET_ID = outlet.OutletId;
                            outlet_Edit.HW_link_name = Hardware.PlcAddress;
                            outlet_Edit.CURRENT_VALUE = outlet.CurrentValue + "";
                            outlet_Edit.PlcAddress = plc.Location;
                            outlet_Edit.Port = (int)plc.Port;
                            _outlets.Add(outlet_Edit);
                        }
                    }
                }
                using (TcAdsClient tcAdsClient = new())
                {
                    foreach (Outlet_Edit item in _outlets)
                    {
                        string name = item.HW_link_name;
                        name.Replace("_out_plc_", "_in_");
                        item.PLCMonitor = tcAdsClient.AddDeviceNotification(name, dataStream, 0, 1, AdsTransMode.OnChange, 100, 0, "");
                    }
                    tcAdsClient.AdsNotification += new(WriteChange);
                }
            }
        }
    }

    #region Params
    public partial class Outlet_Edit
    {
        public long? OUTLET_ID { get; set; }
        public string CURRENT_VALUE { get; set; }
        public string HW_link_name { get; set; }
        public int Port { get; set; }
        public string PlcAddress { get; set; }
        public int PLCMonitor { get; set; }
    }
    public partial class Outlet
    {
        public long? OUTLET_ID { get; set; }
        public Int32? OUTLET_TYPE_ID { get; set; }
        public long? HARDWARE_LINK_ID { get; set; }
        public Int32? ROOM_ID { get; set; }
        public string NAME { get; set; }
        public string CURRENT_VALUE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public Int32? OWNER_ID { get; set; }
        public string HW_link_name { get; set; }
    }
    public partial class Hardware_link
    {
        public long? HARDWARE_LINK_ID { get; set; }
        public Int32? PLC_ID { get; set; }
        public string PLC_ADDRESS { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public Int32? OWNER_ID { get; set; }
        public List<Outlet> MyProperty { get; set; }

    }
    public partial class Plc
    {
        public Int32? PLC_ID { get; set; }
        public string LOCATION { get; set; }
        public string PORT { get; set; }
        public string TYPE { get; set; }
        public Int32? CURRENT_INPUTS { get; set; }
        public Int32? MAX_INPUTS { get; set; }
        public Int32? CURRENT_OUTPUTS { get; set; }
        public Int32? MAX_OUTPUTS { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public Int32? OWNER_ID { get; set; }
        public List<Hardware_link> My_Hardware_link { get; set; }
    }
    public class UserInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Int32 OwnerID { get; set; }
        public Int64 UserID { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Ticket { get; set; }
    }
    public class Params_Get_Service_Data
    {
        public UserInfo My_UserInfo { get; set; }
    }
    public partial class Params_Admin_log_in
    {
        public UserInfo My_UserInfo { get; set; }
    }
    public partial class Params_Twincat2Read
    {
        public string VariableName { get; set; }
        public string AMSID { get; set; }
        public string Port { get; set; }
    }
    #endregion
    #region Test
    public partial class TopLevel
    {
        [JsonProperty("My_Result")]
        public MyResult MyResult { get; set; }

        [JsonProperty("My_Params_Get_Service_Data")]
        public MyParamsGetServiceData MyParamsGetServiceData { get; set; }

        [JsonProperty("ExceptionMsg")]
        public string ExceptionMsg { get; set; }
    }

    public partial class MyParamsGetServiceData
    {
        [JsonProperty("My_UserInfo")]
        public MyUserInfo MyUserInfo { get; set; }
    }

    public partial class MyUserInfo
    {
        [JsonProperty("UserName")]
        public string UserName { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }

        [JsonProperty("OwnerID")]
        public long OwnerId { get; set; }

        [JsonProperty("UserID")]
        public long UserId { get; set; }

        [JsonProperty("IsAuthenticated")]
        public bool IsAuthenticated { get; set; }

        [JsonProperty("Ticket")]
        public string Ticket { get; set; }
    }

    public partial class MyResult
    {
        [JsonProperty("My_PLCs")]
        public MyPlc[] MyPlCs { get; set; }

        [JsonProperty("My_UserInfo")]
        public MyUserInfo MyUserInfo { get; set; }
    }

    public partial class MyOutlet
    {
        [JsonProperty("OUTLET_ID")]
        public long OutletId { get; set; }

        [JsonProperty("OUTLET_TYPE_ID")]
        public long OutletTypeId { get; set; }

        [JsonProperty("HARDWARE_LINK_ID")]
        public long HardwareLinkId { get; set; }

        [JsonProperty("ROOM_ID")]
        public long RoomId { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("CURRENT_VALUE")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CurrentValue { get; set; }

        [JsonProperty("ENTRY_USER_ID")]
        public long EntryUserId { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public DateTimeOffset EntryDate { get; set; }

        [JsonProperty("OWNER_ID")]
        public long OwnerId { get; set; }

        [JsonProperty("My_Outlet_type")]
        public MyOutletType MyOutletType { get; set; }

        [JsonProperty("My_Hardware_link")]
        public MyHardwareLink MyHardwareLink { get; set; }

        [JsonProperty("My_Room")]
        public MyRoom MyRoom { get; set; }

        [JsonProperty("UI_Element")]
        public object UiElement { get; set; }
    }

    public partial class MyHardwareLink
    {
        [JsonProperty("HARDWARE_LINK_ID")]
        public long HardwareLinkId { get; set; }

        [JsonProperty("PLC_ID")]
        public long PlcId { get; set; }

        [JsonProperty("PLC_ADDRESS")]
        public string PlcAddress { get; set; }

        [JsonProperty("ENTRY_USER_ID")]
        public long EntryUserId { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public DateTimeOffset EntryDate { get; set; }

        [JsonProperty("OWNER_ID")]
        public long OwnerId { get; set; }

        [JsonProperty("My_Plc")]
        public MyPlc MyPlc { get; set; }

        [JsonProperty("My_Outlet")]
        public MyOutlet[] MyOutlet { get; set; }
    }

    public partial class MyPlc
    {
        [JsonProperty("PLC_ID")]
        public long PlcId { get; set; }

        [JsonProperty("LOCATION")]
        public string Location { get; set; }

        [JsonProperty("PORT")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Port { get; set; }

        [JsonProperty("TYPE")]
        public string Type { get; set; }

        [JsonProperty("CURRENT_INPUTS")]
        public long CurrentInputs { get; set; }

        [JsonProperty("MAX_INPUTS")]
        public long MaxInputs { get; set; }

        [JsonProperty("CURRENT_OUTPUTS")]
        public long CurrentOutputs { get; set; }

        [JsonProperty("MAX_OUTPUTS")]
        public long MaxOutputs { get; set; }

        [JsonProperty("ENTRY_USER_ID")]
        public long EntryUserId { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public DateTimeOffset EntryDate { get; set; }

        [JsonProperty("OWNER_ID")]
        public long OwnerId { get; set; }

        [JsonProperty("My_Hardware_link")]
        public MyHardwareLink[] MyHardwareLink { get; set; }
    }

    public partial class MyOutletType
    {
        [JsonProperty("OUTLET_TYPE_ID")]
        public long OutletTypeId { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("MIN_VALUE")]
        public long MinValue { get; set; }

        [JsonProperty("MAX_VALUE")]
        public long MaxValue { get; set; }

        [JsonProperty("IS_DIGITAL")]
        public bool IsDigital { get; set; }

        [JsonProperty("ENTRY_USER_ID")]
        public long EntryUserId { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public DateTimeOffset EntryDate { get; set; }

        [JsonProperty("OWNER_ID")]
        public long OwnerId { get; set; }
    }

    public partial class MyRoom
    {
        [JsonProperty("ROOM_ID")]
        public long RoomId { get; set; }

        [JsonProperty("FLOOR_ID")]
        public long FloorId { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("ENTRY_USER_ID")]
        public long EntryUserId { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public DateTimeOffset EntryDate { get; set; }

        [JsonProperty("OWNER_ID")]
        public long OwnerId { get; set; }

        [JsonProperty("My_Floor")]
        public object MyFloor { get; set; }

        [JsonProperty("MyOutlets")]
        public object MyOutlets { get; set; }
    }

    public partial class TopLevel
    {
        public static TopLevel FromJson(string json) => JsonConvert.DeserializeObject<TopLevel>(json, MonitorPLCService.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this TopLevel self) => JsonConvert.SerializeObject(self, MonitorPLCService.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new();
    }

    #endregion
}