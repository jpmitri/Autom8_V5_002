using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BLC;
[Route("api/[controller]")]
[ApiController]
public partial class DataController : ControllerBase
{
#region Members
#endregion
#region Extract_Ticket
private string Extract_Ticket()
{
#region Declaration And Initialization Section.
string str_Ticket = string.Empty;
#endregion
if(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null)
{
str_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
#region Return Section.
return str_Ticket;
#endregion
}
#endregion
#region IsValidWebTicket
private bool IsValidWebTicket(string i_Input)
{
#region Declaration And Initialization Section.
bool Is_Valid = false;
BLCInitializer oBLCInitializer = new BLCInitializer();
#endregion
#region Body Section.
BLC.BLC oBLC_Default = new BLC.BLC();
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
Is_Valid = oBLC.IsValidTicket(i_Input);
}
#endregion
#region Return Section.
return Is_Valid;
#endregion
}
#endregion
#region Admin_log_in
[HttpPost]
[Route("Admin_log_in")]
public Result_Admin_log_in Admin_log_in(Params_Admin_log_in i_Params_Admin_log_in)
{
#region Declaration And Initialization Section.
Admin_log_in_res oReturnValue = new Admin_log_in_res();
string i_Ticket = string.Empty;
Result_Admin_log_in oResult_Admin_log_in = new Result_Admin_log_in();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Admin_log_in);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Admin_log_in(i_Params_Admin_log_in);
oResult_Admin_log_in.My_Result = oReturnValue;
oResult_Admin_log_in.My_Params_Admin_log_in = i_Params_Admin_log_in;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Admin_log_in.ExceptionMsg = string.Format("Admin_log_in : {0}", ex.Message);
}
else
{
oResult_Admin_log_in.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Admin_log_in;
#endregion
}
#endregion
#region Delete_Floor
[HttpPost]
[Route("Delete_Floor")]
public Result_Delete_Floor Delete_Floor(Params_Delete_Floor i_Params_Delete_Floor)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Floor oResult_Delete_Floor = new Result_Delete_Floor();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Floor);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Floor(i_Params_Delete_Floor);
oResult_Delete_Floor.My_Params_Delete_Floor = i_Params_Delete_Floor;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Floor.ExceptionMsg = string.Format("Delete_Floor : {0}", ex.Message);
}
else
{
oResult_Delete_Floor.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Floor;
#endregion
}
#endregion
#region Delete_Hardware_link
[HttpPost]
[Route("Delete_Hardware_link")]
public Result_Delete_Hardware_link Delete_Hardware_link(Params_Delete_Hardware_link i_Params_Delete_Hardware_link)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Hardware_link oResult_Delete_Hardware_link = new Result_Delete_Hardware_link();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Hardware_link);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Hardware_link(i_Params_Delete_Hardware_link);
oResult_Delete_Hardware_link.My_Params_Delete_Hardware_link = i_Params_Delete_Hardware_link;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Hardware_link.ExceptionMsg = string.Format("Delete_Hardware_link : {0}", ex.Message);
}
else
{
oResult_Delete_Hardware_link.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Hardware_link;
#endregion
}
#endregion
#region Delete_Outlet
[HttpPost]
[Route("Delete_Outlet")]
public Result_Delete_Outlet Delete_Outlet(Params_Delete_Outlet i_Params_Delete_Outlet)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Outlet oResult_Delete_Outlet = new Result_Delete_Outlet();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Outlet);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Outlet(i_Params_Delete_Outlet);
oResult_Delete_Outlet.My_Params_Delete_Outlet = i_Params_Delete_Outlet;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Outlet.ExceptionMsg = string.Format("Delete_Outlet : {0}", ex.Message);
}
else
{
oResult_Delete_Outlet.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Outlet;
#endregion
}
#endregion
#region Delete_Outlet_type
[HttpPost]
[Route("Delete_Outlet_type")]
public Result_Delete_Outlet_type Delete_Outlet_type(Params_Delete_Outlet_type i_Params_Delete_Outlet_type)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Outlet_type oResult_Delete_Outlet_type = new Result_Delete_Outlet_type();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Outlet_type);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Outlet_type(i_Params_Delete_Outlet_type);
oResult_Delete_Outlet_type.My_Params_Delete_Outlet_type = i_Params_Delete_Outlet_type;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Outlet_type.ExceptionMsg = string.Format("Delete_Outlet_type : {0}", ex.Message);
}
else
{
oResult_Delete_Outlet_type.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Outlet_type;
#endregion
}
#endregion
#region Delete_Outlet_ui
[HttpPost]
[Route("Delete_Outlet_ui")]
public Result_Delete_Outlet_ui Delete_Outlet_ui(Params_Delete_Outlet_ui i_Params_Delete_Outlet_ui)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Outlet_ui oResult_Delete_Outlet_ui = new Result_Delete_Outlet_ui();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Outlet_ui);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Outlet_ui(i_Params_Delete_Outlet_ui);
oResult_Delete_Outlet_ui.My_Params_Delete_Outlet_ui = i_Params_Delete_Outlet_ui;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Outlet_ui.ExceptionMsg = string.Format("Delete_Outlet_ui : {0}", ex.Message);
}
else
{
oResult_Delete_Outlet_ui.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Outlet_ui;
#endregion
}
#endregion
#region Delete_Plc
[HttpPost]
[Route("Delete_Plc")]
public Result_Delete_Plc Delete_Plc(Params_Delete_Plc i_Params_Delete_Plc)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Plc oResult_Delete_Plc = new Result_Delete_Plc();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Plc);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Plc(i_Params_Delete_Plc);
oResult_Delete_Plc.My_Params_Delete_Plc = i_Params_Delete_Plc;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Plc.ExceptionMsg = string.Format("Delete_Plc : {0}", ex.Message);
}
else
{
oResult_Delete_Plc.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Plc;
#endregion
}
#endregion
#region Delete_Room
[HttpPost]
[Route("Delete_Room")]
public Result_Delete_Room Delete_Room(Params_Delete_Room i_Params_Delete_Room)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Room oResult_Delete_Room = new Result_Delete_Room();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Room);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Room(i_Params_Delete_Room);
oResult_Delete_Room.My_Params_Delete_Room = i_Params_Delete_Room;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Room.ExceptionMsg = string.Format("Delete_Room : {0}", ex.Message);
}
else
{
oResult_Delete_Room.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Room;
#endregion
}
#endregion
#region Delete_Ui
[HttpPost]
[Route("Delete_Ui")]
public Result_Delete_Ui Delete_Ui(Params_Delete_Ui i_Params_Delete_Ui)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Ui oResult_Delete_Ui = new Result_Delete_Ui();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Ui);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Ui(i_Params_Delete_Ui);
oResult_Delete_Ui.My_Params_Delete_Ui = i_Params_Delete_Ui;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Ui.ExceptionMsg = string.Format("Delete_Ui : {0}", ex.Message);
}
else
{
oResult_Delete_Ui.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Ui;
#endregion
}
#endregion
#region Delete_User
[HttpPost]
[Route("Delete_User")]
public Result_Delete_User Delete_User(Params_Delete_User i_Params_Delete_User)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_User oResult_Delete_User = new Result_Delete_User();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_User);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_User(i_Params_Delete_User);
oResult_Delete_User.My_Params_Delete_User = i_Params_Delete_User;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_User.ExceptionMsg = string.Format("Delete_User : {0}", ex.Message);
}
else
{
oResult_Delete_User.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_User;
#endregion
}
#endregion
#region Edit_Floor
[HttpPost]
[Route("Edit_Floor")]
public Result_Edit_Floor Edit_Floor(Floor i_Floor)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Floor oResult_Edit_Floor = new Result_Edit_Floor();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Floor);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Floor(i_Floor);
oResult_Edit_Floor.My_Floor = i_Floor;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Floor.ExceptionMsg = string.Format("Edit_Floor : {0}", ex.Message);
}
else
{
oResult_Edit_Floor.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Floor;
#endregion
}
#endregion
#region Edit_Hardware_link
[HttpPost]
[Route("Edit_Hardware_link")]
public Result_Edit_Hardware_link Edit_Hardware_link(Hardware_link i_Hardware_link)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Hardware_link oResult_Edit_Hardware_link = new Result_Edit_Hardware_link();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Hardware_link);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Hardware_link(i_Hardware_link);
oResult_Edit_Hardware_link.My_Hardware_link = i_Hardware_link;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Hardware_link.ExceptionMsg = string.Format("Edit_Hardware_link : {0}", ex.Message);
}
else
{
oResult_Edit_Hardware_link.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Hardware_link;
#endregion
}
#endregion
#region Edit_Outlet
// Moved To SignalR
#endregion
#region Edit_Outlet_type
[HttpPost]
[Route("Edit_Outlet_type")]
public Result_Edit_Outlet_type Edit_Outlet_type(Outlet_type i_Outlet_type)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Outlet_type oResult_Edit_Outlet_type = new Result_Edit_Outlet_type();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Outlet_type);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Outlet_type(i_Outlet_type);
oResult_Edit_Outlet_type.My_Outlet_type = i_Outlet_type;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Outlet_type.ExceptionMsg = string.Format("Edit_Outlet_type : {0}", ex.Message);
}
else
{
oResult_Edit_Outlet_type.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Outlet_type;
#endregion
}
#endregion
#region Edit_Outlet_ui
[HttpPost]
[Route("Edit_Outlet_ui")]
public Result_Edit_Outlet_ui Edit_Outlet_ui(Outlet_ui i_Outlet_ui)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Outlet_ui oResult_Edit_Outlet_ui = new Result_Edit_Outlet_ui();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Outlet_ui);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Outlet_ui(i_Outlet_ui);
oResult_Edit_Outlet_ui.My_Outlet_ui = i_Outlet_ui;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Outlet_ui.ExceptionMsg = string.Format("Edit_Outlet_ui : {0}", ex.Message);
}
else
{
oResult_Edit_Outlet_ui.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Outlet_ui;
#endregion
}
#endregion
#region Edit_Plc
[HttpPost]
[Route("Edit_Plc")]
public Result_Edit_Plc Edit_Plc(Plc i_Plc)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Plc oResult_Edit_Plc = new Result_Edit_Plc();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Plc);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Plc(i_Plc);
oResult_Edit_Plc.My_Plc = i_Plc;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Plc.ExceptionMsg = string.Format("Edit_Plc : {0}", ex.Message);
}
else
{
oResult_Edit_Plc.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Plc;
#endregion
}
#endregion
#region Edit_Room
[HttpPost]
[Route("Edit_Room")]
public Result_Edit_Room Edit_Room(Room i_Room)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Room oResult_Edit_Room = new Result_Edit_Room();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Room);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Room(i_Room);
oResult_Edit_Room.My_Room = i_Room;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Room.ExceptionMsg = string.Format("Edit_Room : {0}", ex.Message);
}
else
{
oResult_Edit_Room.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Room;
#endregion
}
#endregion
#region Edit_Ui
[HttpPost]
[Route("Edit_Ui")]
public Result_Edit_Ui Edit_Ui(Ui i_Ui)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Ui oResult_Edit_Ui = new Result_Edit_Ui();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Ui);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Ui(i_Ui);
oResult_Edit_Ui.My_Ui = i_Ui;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Ui.ExceptionMsg = string.Format("Edit_Ui : {0}", ex.Message);
}
else
{
oResult_Edit_Ui.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Ui;
#endregion
}
#endregion
#region Edit_User
[HttpPost]
[Route("Edit_User")]
public Result_Edit_User Edit_User(User i_User)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_User oResult_Edit_User = new Result_Edit_User();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_User);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_User(i_User);
oResult_Edit_User.My_User = i_User;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_User.ExceptionMsg = string.Format("Edit_User : {0}", ex.Message);
}
else
{
oResult_Edit_User.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_User;
#endregion
}
#endregion
#region Get_All_Data
[HttpPost]
[Route("Get_All_Data")]
public Result_Get_All_Data Get_All_Data(Params_Get_All_Data i_Params_Get_All_Data)
{
#region Declaration And Initialization Section.
All_Data oReturnValue = new All_Data();
string i_Ticket = string.Empty;
Result_Get_All_Data oResult_Get_All_Data = new Result_Get_All_Data();
#endregion
#region Body Section.
try
{


BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_All_Data);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_All_Data(i_Params_Get_All_Data);
oResult_Get_All_Data.My_Result = oReturnValue;
oResult_Get_All_Data.My_Params_Get_All_Data = i_Params_Get_All_Data;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_All_Data.ExceptionMsg = string.Format("Get_All_Data : {0}", ex.Message);
}
else
{
oResult_Get_All_Data.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_All_Data;
#endregion
}
#endregion
#region Get_Floor_By_OWNER_ID
[HttpPost]
[Route("Get_Floor_By_OWNER_ID")]
public Result_Get_Floor_By_OWNER_ID Get_Floor_By_OWNER_ID(Params_Get_Floor_By_OWNER_ID i_Params_Get_Floor_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Floor>  oReturnValue = new List<Floor> ();
string i_Ticket = string.Empty;
Result_Get_Floor_By_OWNER_ID oResult_Get_Floor_By_OWNER_ID = new Result_Get_Floor_By_OWNER_ID();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Floor_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Floor_By_OWNER_ID(i_Params_Get_Floor_By_OWNER_ID);
oResult_Get_Floor_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Floor_By_OWNER_ID.My_Params_Get_Floor_By_OWNER_ID = i_Params_Get_Floor_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Floor_By_OWNER_ID.ExceptionMsg = string.Format("Get_Floor_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Floor_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Floor_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Hardware_link_By_OWNER_ID
[HttpPost]
[Route("Get_Hardware_link_By_OWNER_ID")]
public Result_Get_Hardware_link_By_OWNER_ID Get_Hardware_link_By_OWNER_ID(Params_Get_Hardware_link_By_OWNER_ID i_Params_Get_Hardware_link_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Hardware_link>  oReturnValue = new List<Hardware_link> ();
string i_Ticket = string.Empty;
Result_Get_Hardware_link_By_OWNER_ID oResult_Get_Hardware_link_By_OWNER_ID = new Result_Get_Hardware_link_By_OWNER_ID();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Hardware_link_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Hardware_link_By_OWNER_ID(i_Params_Get_Hardware_link_By_OWNER_ID);
oResult_Get_Hardware_link_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Hardware_link_By_OWNER_ID.My_Params_Get_Hardware_link_By_OWNER_ID = i_Params_Get_Hardware_link_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Hardware_link_By_OWNER_ID.ExceptionMsg = string.Format("Get_Hardware_link_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Hardware_link_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Hardware_link_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Outlet_By_OWNER_ID
[HttpPost]
[Route("Get_Outlet_By_OWNER_ID")]
public Result_Get_Outlet_By_OWNER_ID Get_Outlet_By_OWNER_ID(Params_Get_Outlet_By_OWNER_ID i_Params_Get_Outlet_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Outlet>  oReturnValue = new List<Outlet> ();
string i_Ticket = string.Empty;
Result_Get_Outlet_By_OWNER_ID oResult_Get_Outlet_By_OWNER_ID = new Result_Get_Outlet_By_OWNER_ID();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Outlet_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Outlet_By_OWNER_ID(i_Params_Get_Outlet_By_OWNER_ID);
oResult_Get_Outlet_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Outlet_By_OWNER_ID.My_Params_Get_Outlet_By_OWNER_ID = i_Params_Get_Outlet_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Outlet_By_OWNER_ID.ExceptionMsg = string.Format("Get_Outlet_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Outlet_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Outlet_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Outlet_type_By_OWNER_ID
[HttpPost]
[Route("Get_Outlet_type_By_OWNER_ID")]
public Result_Get_Outlet_type_By_OWNER_ID Get_Outlet_type_By_OWNER_ID(Params_Get_Outlet_type_By_OWNER_ID i_Params_Get_Outlet_type_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Outlet_type>  oReturnValue = new List<Outlet_type> ();
string i_Ticket = string.Empty;
Result_Get_Outlet_type_By_OWNER_ID oResult_Get_Outlet_type_By_OWNER_ID = new Result_Get_Outlet_type_By_OWNER_ID();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Outlet_type_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Outlet_type_By_OWNER_ID(i_Params_Get_Outlet_type_By_OWNER_ID);
oResult_Get_Outlet_type_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Outlet_type_By_OWNER_ID.My_Params_Get_Outlet_type_By_OWNER_ID = i_Params_Get_Outlet_type_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Outlet_type_By_OWNER_ID.ExceptionMsg = string.Format("Get_Outlet_type_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Outlet_type_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Outlet_type_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Outlet_ui_By_OWNER_ID
[HttpPost]
[Route("Get_Outlet_ui_By_OWNER_ID")]
public Result_Get_Outlet_ui_By_OWNER_ID Get_Outlet_ui_By_OWNER_ID(Params_Get_Outlet_ui_By_OWNER_ID i_Params_Get_Outlet_ui_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Outlet_ui>  oReturnValue = new List<Outlet_ui> ();
string i_Ticket = string.Empty;
Result_Get_Outlet_ui_By_OWNER_ID oResult_Get_Outlet_ui_By_OWNER_ID = new Result_Get_Outlet_ui_By_OWNER_ID();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Outlet_ui_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Outlet_ui_By_OWNER_ID(i_Params_Get_Outlet_ui_By_OWNER_ID);
oResult_Get_Outlet_ui_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Outlet_ui_By_OWNER_ID.My_Params_Get_Outlet_ui_By_OWNER_ID = i_Params_Get_Outlet_ui_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Outlet_ui_By_OWNER_ID.ExceptionMsg = string.Format("Get_Outlet_ui_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Outlet_ui_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Outlet_ui_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Plc_By_OWNER_ID
[HttpPost]
[Route("Get_Plc_By_OWNER_ID")]
public Result_Get_Plc_By_OWNER_ID Get_Plc_By_OWNER_ID(Params_Get_Plc_By_OWNER_ID i_Params_Get_Plc_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Plc>  oReturnValue = new List<Plc> ();
string i_Ticket = string.Empty;
Result_Get_Plc_By_OWNER_ID oResult_Get_Plc_By_OWNER_ID = new Result_Get_Plc_By_OWNER_ID();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Plc_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Plc_By_OWNER_ID(i_Params_Get_Plc_By_OWNER_ID);
oResult_Get_Plc_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Plc_By_OWNER_ID.My_Params_Get_Plc_By_OWNER_ID = i_Params_Get_Plc_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Plc_By_OWNER_ID.ExceptionMsg = string.Format("Get_Plc_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Plc_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Plc_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Room_By_OWNER_ID
[HttpPost]
[Route("Get_Room_By_OWNER_ID")]
public Result_Get_Room_By_OWNER_ID Get_Room_By_OWNER_ID(Params_Get_Room_By_OWNER_ID i_Params_Get_Room_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Room>  oReturnValue = new List<Room> ();
string i_Ticket = string.Empty;
Result_Get_Room_By_OWNER_ID oResult_Get_Room_By_OWNER_ID = new Result_Get_Room_By_OWNER_ID();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Room_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Room_By_OWNER_ID(i_Params_Get_Room_By_OWNER_ID);
oResult_Get_Room_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Room_By_OWNER_ID.My_Params_Get_Room_By_OWNER_ID = i_Params_Get_Room_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Room_By_OWNER_ID.ExceptionMsg = string.Format("Get_Room_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Room_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Room_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Service_Data
[HttpPost]
[Route("Get_Service_Data")]
public Result_Get_Service_Data Get_Service_Data(Params_Get_Service_Data i_Params_Get_Service_Data)
{
#region Declaration And Initialization Section.
Service_Data_Result oReturnValue = new Service_Data_Result();
string i_Ticket = string.Empty;
Result_Get_Service_Data oResult_Get_Service_Data = new Result_Get_Service_Data();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Service_Data);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Service_Data(i_Params_Get_Service_Data);
oResult_Get_Service_Data.My_Result = oReturnValue;
oResult_Get_Service_Data.My_Params_Get_Service_Data = i_Params_Get_Service_Data;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Service_Data.ExceptionMsg = string.Format("Get_Service_Data : {0}", ex.Message);
}
else
{
oResult_Get_Service_Data.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Service_Data;
#endregion
}
#endregion
#region Get_Ui_By_OWNER_ID
[HttpPost]
[Route("Get_Ui_By_OWNER_ID")]
public Result_Get_Ui_By_OWNER_ID Get_Ui_By_OWNER_ID(Params_Get_Ui_By_OWNER_ID i_Params_Get_Ui_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Ui>  oReturnValue = new List<Ui> ();
string i_Ticket = string.Empty;
Result_Get_Ui_By_OWNER_ID oResult_Get_Ui_By_OWNER_ID = new Result_Get_Ui_By_OWNER_ID();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Ui_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Ui_By_OWNER_ID(i_Params_Get_Ui_By_OWNER_ID);
oResult_Get_Ui_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Ui_By_OWNER_ID.My_Params_Get_Ui_By_OWNER_ID = i_Params_Get_Ui_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Ui_By_OWNER_ID.ExceptionMsg = string.Format("Get_Ui_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Ui_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Ui_By_OWNER_ID;
#endregion
}
#endregion
#region Get_User_By_OWNER_ID
[HttpPost]
[Route("Get_User_By_OWNER_ID")]
public Result_Get_User_By_OWNER_ID Get_User_By_OWNER_ID(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<User>  oReturnValue = new List<User> ();
string i_Ticket = string.Empty;
Result_Get_User_By_OWNER_ID oResult_Get_User_By_OWNER_ID = new Result_Get_User_By_OWNER_ID();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_User_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_User_By_OWNER_ID(i_Params_Get_User_By_OWNER_ID);
oResult_Get_User_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_User_By_OWNER_ID.My_Params_Get_User_By_OWNER_ID = i_Params_Get_User_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_User_By_OWNER_ID.ExceptionMsg = string.Format("Get_User_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_User_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_User_By_OWNER_ID;
#endregion
}
#endregion
}

#region Action_Result
public partial class Action_Result
{
#region Properties.
public string ExceptionMsg { get; set; }
#endregion
#region Constructor
public Action_Result()
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
this.ExceptionMsg = string.Empty;
#endregion
}
#endregion
}
#endregion
#region Result_Admin_log_in
public partial class Result_Admin_log_in : Action_Result
{
#region Properties.
public Admin_log_in_res My_Result { get; set; }
public Params_Admin_log_in My_Params_Admin_log_in { get; set; }
#endregion
}
#endregion
#region Result_Delete_Floor
public partial class Result_Delete_Floor : Action_Result
{
#region Properties.
public Params_Delete_Floor My_Params_Delete_Floor { get; set; }
#endregion
}
#endregion
#region Result_Delete_Hardware_link
public partial class Result_Delete_Hardware_link : Action_Result
{
#region Properties.
public Params_Delete_Hardware_link My_Params_Delete_Hardware_link { get; set; }
#endregion
}
#endregion
#region Result_Delete_Outlet
public partial class Result_Delete_Outlet : Action_Result
{
#region Properties.
public Params_Delete_Outlet My_Params_Delete_Outlet { get; set; }
#endregion
}
#endregion
#region Result_Delete_Outlet_type
public partial class Result_Delete_Outlet_type : Action_Result
{
#region Properties.
public Params_Delete_Outlet_type My_Params_Delete_Outlet_type { get; set; }
#endregion
}
#endregion
#region Result_Delete_Outlet_ui
public partial class Result_Delete_Outlet_ui : Action_Result
{
#region Properties.
public Params_Delete_Outlet_ui My_Params_Delete_Outlet_ui { get; set; }
#endregion
}
#endregion
#region Result_Delete_Plc
public partial class Result_Delete_Plc : Action_Result
{
#region Properties.
public Params_Delete_Plc My_Params_Delete_Plc { get; set; }
#endregion
}
#endregion
#region Result_Delete_Room
public partial class Result_Delete_Room : Action_Result
{
#region Properties.
public Params_Delete_Room My_Params_Delete_Room { get; set; }
#endregion
}
#endregion
#region Result_Delete_Ui
public partial class Result_Delete_Ui : Action_Result
{
#region Properties.
public Params_Delete_Ui My_Params_Delete_Ui { get; set; }
#endregion
}
#endregion
#region Result_Delete_User
public partial class Result_Delete_User : Action_Result
{
#region Properties.
public Params_Delete_User My_Params_Delete_User { get; set; }
#endregion
}
#endregion
#region Result_Edit_Floor
public partial class Result_Edit_Floor : Action_Result
{
#region Properties.
public Floor My_Floor { get; set; }
#endregion
}
#endregion
#region Result_Edit_Hardware_link
public partial class Result_Edit_Hardware_link : Action_Result
{
#region Properties.
public Hardware_link My_Hardware_link { get; set; }
#endregion
}
#endregion
#region Result_Edit_Outlet
public partial class Result_Edit_Outlet : Action_Result
{
#region Properties.
public Outlet My_Outlet { get; set; }
#endregion
}
#endregion
#region Result_Edit_Outlet_type
public partial class Result_Edit_Outlet_type : Action_Result
{
#region Properties.
public Outlet_type My_Outlet_type { get; set; }
#endregion
}
#endregion
#region Result_Edit_Outlet_ui
public partial class Result_Edit_Outlet_ui : Action_Result
{
#region Properties.
public Outlet_ui My_Outlet_ui { get; set; }
#endregion
}
#endregion
#region Result_Edit_Plc
public partial class Result_Edit_Plc : Action_Result
{
#region Properties.
public Plc My_Plc { get; set; }
#endregion
}
#endregion
#region Result_Edit_Room
public partial class Result_Edit_Room : Action_Result
{
#region Properties.
public Room My_Room { get; set; }
#endregion
}
#endregion
#region Result_Edit_Ui
public partial class Result_Edit_Ui : Action_Result
{
#region Properties.
public Ui My_Ui { get; set; }
#endregion
}
#endregion
#region Result_Edit_User
public partial class Result_Edit_User : Action_Result
{
#region Properties.
public User My_User { get; set; }
#endregion
}
#endregion
#region Result_Get_All_Data
public partial class Result_Get_All_Data : Action_Result
{
#region Properties.
public All_Data My_Result { get; set; }
public Params_Get_All_Data My_Params_Get_All_Data { get; set; }
#endregion
}
#endregion
#region Result_Get_Floor_By_OWNER_ID
public partial class Result_Get_Floor_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Floor>  My_Result { get; set; }
public Params_Get_Floor_By_OWNER_ID My_Params_Get_Floor_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Hardware_link_By_OWNER_ID
public partial class Result_Get_Hardware_link_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Hardware_link>  My_Result { get; set; }
public Params_Get_Hardware_link_By_OWNER_ID My_Params_Get_Hardware_link_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Outlet_By_OWNER_ID
public partial class Result_Get_Outlet_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Outlet>  My_Result { get; set; }
public Params_Get_Outlet_By_OWNER_ID My_Params_Get_Outlet_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Outlet_type_By_OWNER_ID
public partial class Result_Get_Outlet_type_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Outlet_type>  My_Result { get; set; }
public Params_Get_Outlet_type_By_OWNER_ID My_Params_Get_Outlet_type_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Outlet_ui_By_OWNER_ID
public partial class Result_Get_Outlet_ui_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Outlet_ui>  My_Result { get; set; }
public Params_Get_Outlet_ui_By_OWNER_ID My_Params_Get_Outlet_ui_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Plc_By_OWNER_ID
public partial class Result_Get_Plc_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Plc>  My_Result { get; set; }
public Params_Get_Plc_By_OWNER_ID My_Params_Get_Plc_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Room_By_OWNER_ID
public partial class Result_Get_Room_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Room>  My_Result { get; set; }
public Params_Get_Room_By_OWNER_ID My_Params_Get_Room_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Service_Data
public partial class Result_Get_Service_Data : Action_Result
{
#region Properties.
public Service_Data_Result My_Result { get; set; }
public Params_Get_Service_Data My_Params_Get_Service_Data { get; set; }
#endregion
}
#endregion
#region Result_Get_Ui_By_OWNER_ID
public partial class Result_Get_Ui_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Ui>  My_Result { get; set; }
public Params_Get_Ui_By_OWNER_ID My_Params_Get_Ui_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_User_By_OWNER_ID
public partial class Result_Get_User_By_OWNER_ID : Action_Result
{
#region Properties.
public List<User>  My_Result { get; set; }
public Params_Get_User_By_OWNER_ID My_Params_Get_User_By_OWNER_ID { get; set; }
#endregion
}
#endregion
