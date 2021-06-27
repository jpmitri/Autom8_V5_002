using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using BLC;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

using WebAPI.GetHub;

namespace WebAPI.Controllers
{
    public partial class DataController : ControllerBase
    {
        private IHubContext<OutletHub> _hub;
        public DataController(IHubContext<OutletHub> hub)
        {
            _hub = hub;
        }
        #region Edit_Outlet
        [HttpPost]
        [Route("Edit_Outlet")]
        public Result_Edit_Outlet Edit_Outlet(Outlet i_Outlet)
        {
            #region Declaration And Initialization Section.
            string i_Ticket = string.Empty;
            Result_Edit_Outlet oResult_Edit_Outlet = new Result_Edit_Outlet();
            #endregion
            #region Body Section.
            try
            {

                // Ticket Checking
                //-------------------
                if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
                {
                    if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
                    {
                        if
                        (
                        (HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
                        (HttpContext.Request.Query["Ticket"].ToString() != "")
                        )
                        {
                            i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
                        }
                        else
                        {
                            throw new Exception("Invalid Ticket");
                        }
                    }
                }
                //-------------------

                BLC.BLC oBLC_Default = new BLC.BLC();
                BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket, BLC.BLC.Enum_API_Method.Edit_Outlet);
                using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
                {
                    oBLC.Edit_Outlet(i_Outlet);
                    oResult_Edit_Outlet.My_Outlet = i_Outlet;
                    if(i_Outlet.OUTLET_ID != -1 && i_Outlet.CURRENT_VALUE != "-1")
                    {
                        UpdateClients(i_Outlet);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType().FullName != "BLC.BLCException")
                {
                    oResult_Edit_Outlet.ExceptionMsg = string.Format("Edit_Outlet : {0}", ex.Message);
                }
                else
                {
                    oResult_Edit_Outlet.ExceptionMsg = ex.Message;
                }
            }
            #endregion
            #region Return Section
            return oResult_Edit_Outlet;
            #endregion
        }

        public void UpdateClients(Outlet i_Outlet)
        {
            _hub.Clients.All.SendAsync("updatedOutlet", i_Outlet);
        }
        #endregion
    }
}
