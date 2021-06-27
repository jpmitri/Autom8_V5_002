using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MonitorPLCService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private HttpClient client;
        private List<Outlet> outlets;
        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            client = new();
            outlets = new();
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
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }

    #region Params
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
        public Hardware_link My_Hardware_link { get; set; }
    }
    public partial class Hardware_link
    {
        public long? HARDWARE_LINK_ID { get; set; }
        public Int32? PLC_ID { get; set; }
        public string PLC_ADDRESS { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public Int32? OWNER_ID { get; set; }

        public Plc My_Plc { get; set; }
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
    }
    public partial class UserInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Int32 OwnerID { get; set; }
        public Int64 UserID { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Ticket { get; set; }
    }
    public partial class Params_Admin_log_in
    {
        public UserInfo My_UserInfo { get; set; }
    }
    #endregion
}
