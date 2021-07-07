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
    public class Worker: BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private HttpClient client;
        private Params_Get_Service_Data user;
        private int delay = 5000;
        private User resultGetData;
        private string responseString = string.Empty;
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            user = new();
            user.My_UserInfo = new();
            resultGetData = new();
            if(int.TryParse(ConfigurationManager.AppSettings["DELAY"],out int x))
            {
                delay = x;
            }
            else
            {
                _logger.LogError("Unable To Parse Delay Using Default Delay of 5000ms or 5s");
            }
            _logger.LogInformation("Service Initialized and Started");
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            client.Dispose();
            _logger.LogInformation("The service has been stopped...");
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using(client = new())
            {
                bool loggedIn = false;
                while(!loggedIn)
                {
                    try
                    {
                        user.My_UserInfo.UserName = ConfigurationManager.AppSettings["USERNAME"];
                        user.My_UserInfo.Password = ConfigurationManager.AppSettings["ENCRYPTED_PASSWORD"];
                        string serOut = JsonConvert.SerializeObject(user);
                        HttpContent content = new StringContent(serOut,Encoding.UTF8,"application/json");
                        HttpResponseMessage response = await client.PostAsync(ConfigurationManager.AppSettings["API"] + "Get_Service_Data",content);
                        responseString = await response.Content.ReadAsStringAsync();
                        resultGetData = JsonConvert.DeserializeObject<User>(responseString);
                        loggedIn = true;
                    }
                    catch(Exception ex)
                    {
                        _logger.LogError(ex,"There was a problem contacting the Api");

                    }
                    if(!loggedIn)
                    {
                        await Task.Delay(5000);
                    }
                }
            }
            while(!stoppingToken.IsCancellationRequested)
            {
                using(client = new())
                {
                    Params_MonitorPLC params_MonitorPLC = new();
                    string serOut = JsonConvert.SerializeObject(params_MonitorPLC);
                    HttpContent content = new StringContent(serOut,Encoding.UTF8,"application/json");
                    string request = ConfigurationManager.AppSettings["API"];
                    request += "MonitorPLC?ticket=";
                    request += resultGetData.MyResult.MyUserInfo.Ticket;
                    HttpResponseMessage response = await client.PostAsync(request,content);
                    responseString = await response.Content.ReadAsStringAsync();
                }
                await Task.Delay(delay,stoppingToken);
            }
        }
    }

    #region Params
    public partial class Params_MonitorPLC
    {

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

    public partial class User
    {
        [JsonProperty("My_Result")]
        public My MyResult { get; set; }

        [JsonProperty("My_Params_Get_Service_Data")]
        public My MyParamsGetServiceData { get; set; }

        [JsonProperty("ExceptionMsg")]
        public string ExceptionMsg { get; set; }
    }

    public partial class My
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

    public partial class User
    {
        public static User FromJson(string json) => JsonConvert.DeserializeObject<User>(json,Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this User self) => JsonConvert.SerializeObject(self,Converter.Settings);
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
    #endregion
}