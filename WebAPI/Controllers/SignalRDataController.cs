using BLC;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Configuration;
using System.Linq;
using Microsoft.AspNetCore.SignalR;
using WebAPI.GetHub;
using System.Collections.Generic;

public partial class DataController
{


    private IHubContext<OutletHub> _hub;
    public DataController(IHubContext<OutletHub> hub)
    {
        _hub = hub;
    }


    public void UpdateClients(Outlet i_Outlet)
    {
        _hub.Clients.All.SendAsync("updatedOutlet",i_Outlet);
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
            if(ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
            {
                if(ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
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
            BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Outlet);
            using(BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
            {
                oBLC.Edit_Outlet(i_Outlet);
                oResult_Edit_Outlet.My_Outlet = i_Outlet;
                if(i_Outlet.OUTLET_TYPE_ID is 1 or 2)
                {
                    if(i_Outlet.OUTLET_ID != -1 && i_Outlet.CURRENT_VALUE != "-1")
                    {
                        UpdateClients(i_Outlet);
                    }
                }
            }
        }
        catch(Exception ex)
        {
            if(ex.GetType().FullName != "BLC.BLCException")
            {
                oResult_Edit_Outlet.ExceptionMsg = string.Format("Edit_Outlet : {0}",ex.Message);
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
    #endregion
    #region Monitor Plc
    [HttpPost]
    [Route("MonitorPLC")]
    public Result_MonitorPLC MonitorPLC(Params_MonitorPLC i_Params_MonitorPLC)
    {
        #region Declaration And Initialization Section.
        List<Outlet> oReturnValue = new List<Outlet>();
        string i_Ticket = string.Empty;
        Result_MonitorPLC oResult_MonitorPLC = new Result_MonitorPLC();
        #endregion
        #region Body Section.
        try
        {

            // Ticket Checking
            //-------------------
            if(ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
            {
                if(ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
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
            BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.MonitorPLC);
            using(BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
            {
                oReturnValue = oBLC.MonitorPLC(i_Params_MonitorPLC);
                oResult_MonitorPLC.My_Result = oReturnValue;
                oResult_MonitorPLC.My_Params_MonitorPLC = i_Params_MonitorPLC;
            }
        }
        catch(Exception ex)
        {
            if(ex.GetType().FullName != "BLC.BLCException")
            {
                oResult_MonitorPLC.ExceptionMsg = string.Format("MonitorPLC : {0}",ex.Message);
            }
            else
            {
                oResult_MonitorPLC.ExceptionMsg = ex.Message;
            }
        }
        #endregion
        #region Return Section
        foreach(Outlet outlet in oResult_MonitorPLC.My_Result)
        {
            Edit_Outlet(outlet);
            System.Threading.Thread.Sleep(100);
        }
        return oResult_MonitorPLC;
        #endregion
    }
    #endregion
}
#region Result_Edit_Outlet
public partial class Result_Edit_Outlet: Action_Result
{
    #region Properties.
    public Outlet My_Outlet { get; set; }
    #endregion
}
#endregion
#region Result_Monitor_PLC
public partial class Result_MonitorPLC: Action_Result
{
    #region Properties.
    public List<Outlet> My_Result { get; set; }
    public Params_MonitorPLC My_Params_MonitorPLC { get; set; }
    #endregion
}
#endregion