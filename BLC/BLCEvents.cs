using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using BLC;
namespace BLC
{
public partial class BLC
{

#region Enum_API_Method
public enum Enum_API_Method
{
Get_All_Data,
Get_User_By_OWNER_ID,
Edit_Outlet,
Edit_Outlet_ui,
Edit_User,
Delete_User,
Admin_log_in,
Get_Ui_By_OWNER_ID,
Get_Plc_By_OWNER_ID,
Get_Hardware_link_By_OWNER_ID,
Get_Outlet_type_By_OWNER_ID,
Get_Floor_By_OWNER_ID,
Get_Room_By_OWNER_ID,
Get_Outlet_By_OWNER_ID,
Get_Outlet_ui_By_OWNER_ID,
Edit_Ui,
Edit_Plc,
Edit_Hardware_link,
Edit_Outlet_type,
Edit_Floor,
Edit_Room,
Delete_Outlet,
Delete_Ui,
Delete_Plc,
Delete_Hardware_link,
Delete_Outlet_type,
Delete_Floor,
Delete_Room,
Delete_Outlet_ui,
Get_Service_Data
}
#endregion

#region Prepare_BLCInitializer
public BLCInitializer Prepare_BLCInitializer(string i_Ticket, Enum_API_Method i_Enum_API_Method)
{
#region Declaration And Initialization Section.
BLCInitializer oBLCInitializer = new BLCInitializer();
BLC oBLC_Default = new BLC();
string str_CUSTOM_BLC_INIT = string.Empty;
#endregion
#region Body Section.
if (this.OnPreEvent_BLC_Init != null)
{
oBLCInitializer = this.OnPreEvent_BLC_Init(i_Ticket, i_Enum_API_Method);
return oBLCInitializer;
}
else
{
oBLCInitializer.UserID = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
}
#endregion
#region Return Section.
return oBLCInitializer;
#endregion
}
#endregion

#region General Pre/Post events
public delegate void PreEvent_Handler_General(string i_MethodName);
public delegate void PostEvent_Handler_General(string i_MethodName);
public event PreEvent_Handler_General OnPreEvent_General;
public event PostEvent_Handler_General OnPostEvent_General;
#endregion
#region General Pre/Post BLC_Init
public delegate BLCInitializer PreEvent_Handler_BLC_Init(string i_Ticket, Enum_API_Method i_Enum_API_Method);
public delegate BLCInitializer PostEvent_Handler_BLC_Init(string i_Ticket, Enum_API_Method i_Enum_API_Method);
public event PreEvent_Handler_BLC_Init OnPreEvent_BLC_Init;
public event PostEvent_Handler_BLC_Init OnPostEvent_BLC_Init;
#endregion
public  delegate void PreEvent_Handler_Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file);
public  delegate void  PostEvent_Handler_Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file);
public event PreEvent_Handler_Delete_Uploaded_file OnPreEvent_Delete_Uploaded_file;
public event PostEvent_Handler_Delete_Uploaded_file OnPostEvent_Delete_Uploaded_file;
public  delegate void PreEvent_Handler_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
public  delegate void  PostEvent_Handler_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
public event PreEvent_Handler_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
public event PostEvent_Handler_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD OnPostEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
public  delegate void PreEvent_Handler_Edit_Outlet(Outlet i_Outlet,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Outlet(Outlet i_Outlet,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Outlet OnPreEvent_Edit_Outlet;
public event PostEvent_Handler_Edit_Outlet OnPostEvent_Edit_Outlet;
public  delegate void PreEvent_Handler_Edit_Uploaded_file(Uploaded_file i_Uploaded_file,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Uploaded_file(Uploaded_file i_Uploaded_file,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Uploaded_file OnPreEvent_Edit_Uploaded_file;
public event PostEvent_Handler_Edit_Uploaded_file OnPostEvent_Edit_Uploaded_file;
public  delegate void PreEvent_Handler_Edit_User(User i_User,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_User(User i_User,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_User OnPreEvent_Edit_User;
public event PostEvent_Handler_Edit_User OnPostEvent_Edit_User;
public  delegate void PreEvent_Handler_Get_Hardware_link_By_HARDWARE_LINK_ID(Params_Get_Hardware_link_By_HARDWARE_LINK_ID i_Params_Get_Hardware_link_By_HARDWARE_LINK_ID);
public  delegate void  PostEvent_Handler_Get_Hardware_link_By_HARDWARE_LINK_ID(ref Hardware_link i_Result, Params_Get_Hardware_link_By_HARDWARE_LINK_ID i_Params_Get_Hardware_link_By_HARDWARE_LINK_ID);
public event PreEvent_Handler_Get_Hardware_link_By_HARDWARE_LINK_ID OnPreEvent_Get_Hardware_link_By_HARDWARE_LINK_ID;
public event PostEvent_Handler_Get_Hardware_link_By_HARDWARE_LINK_ID OnPostEvent_Get_Hardware_link_By_HARDWARE_LINK_ID;
public  delegate void PreEvent_Handler_Get_Floor_By_OWNER_ID(Params_Get_Floor_By_OWNER_ID i_Params_Get_Floor_By_OWNER_ID);
public  delegate void  PostEvent_Handler_Get_Floor_By_OWNER_ID(ref List<Floor>  i_Result, Params_Get_Floor_By_OWNER_ID i_Params_Get_Floor_By_OWNER_ID);
public event PreEvent_Handler_Get_Floor_By_OWNER_ID OnPreEvent_Get_Floor_By_OWNER_ID;
public event PostEvent_Handler_Get_Floor_By_OWNER_ID OnPostEvent_Get_Floor_By_OWNER_ID;
public  delegate void PreEvent_Handler_Get_Hardware_link_By_OWNER_ID(Params_Get_Hardware_link_By_OWNER_ID i_Params_Get_Hardware_link_By_OWNER_ID);
public  delegate void  PostEvent_Handler_Get_Hardware_link_By_OWNER_ID(List<Hardware_link>  i_Result, Params_Get_Hardware_link_By_OWNER_ID i_Params_Get_Hardware_link_By_OWNER_ID);
public event PreEvent_Handler_Get_Hardware_link_By_OWNER_ID OnPreEvent_Get_Hardware_link_By_OWNER_ID;
public event PostEvent_Handler_Get_Hardware_link_By_OWNER_ID OnPostEvent_Get_Hardware_link_By_OWNER_ID;
public  delegate void PreEvent_Handler_Get_Outlet_By_ROOM_ID(Params_Get_Outlet_By_ROOM_ID i_Params_Get_Outlet_By_ROOM_ID);
public  delegate void  PostEvent_Handler_Get_Outlet_By_ROOM_ID(ref List<Outlet>  i_Result, Params_Get_Outlet_By_ROOM_ID i_Params_Get_Outlet_By_ROOM_ID);
public event PreEvent_Handler_Get_Outlet_By_ROOM_ID OnPreEvent_Get_Outlet_By_ROOM_ID;
public event PostEvent_Handler_Get_Outlet_By_ROOM_ID OnPostEvent_Get_Outlet_By_ROOM_ID;
public  delegate void PreEvent_Handler_Get_Plc_By_OWNER_ID(Params_Get_Plc_By_OWNER_ID i_Params_Get_Plc_By_OWNER_ID);
public  delegate void  PostEvent_Handler_Get_Plc_By_OWNER_ID(List<Plc>  i_Result, Params_Get_Plc_By_OWNER_ID i_Params_Get_Plc_By_OWNER_ID);
public event PreEvent_Handler_Get_Plc_By_OWNER_ID OnPreEvent_Get_Plc_By_OWNER_ID;
public event PostEvent_Handler_Get_Plc_By_OWNER_ID OnPostEvent_Get_Plc_By_OWNER_ID;
public  delegate void PreEvent_Handler_Get_Room_By_FLOOR_ID(Params_Get_Room_By_FLOOR_ID i_Params_Get_Room_By_FLOOR_ID);
public  delegate void  PostEvent_Handler_Get_Room_By_FLOOR_ID(ref List<Room>  i_Result, Params_Get_Room_By_FLOOR_ID i_Params_Get_Room_By_FLOOR_ID);
public event PreEvent_Handler_Get_Room_By_FLOOR_ID OnPreEvent_Get_Room_By_FLOOR_ID;
public event PostEvent_Handler_Get_Room_By_FLOOR_ID OnPostEvent_Get_Room_By_FLOOR_ID;
#region Uploaded Files Events Handlers
#region Register_Uploaded_Events_Handlers
public void Register_Uploaded_Events_Handlers()
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
this.OnPreEvent_Edit_Uploaded_file += BLC_OnPreEvent_Edit_Uploaded_file;
this.OnPreEvent_Delete_Uploaded_file += BLC_OnPreEvent_Delete_Uploaded_file;
this.OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD += BLC_OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD;
#endregion
}
#endregion
#region Get_Uploaded_Files
public List<Uploaded_file> Get_Uploaded_Files(string i_REL_ENTITY,string i_REL_FIELD,long? i_REL_KEY)
{
#region Declaration And Initialization Section.
List<Uploaded_file> oList_Uploaded_files = new List<Uploaded_file>();
Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD();
#endregion
#region Body Section.
oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD();
oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_ENTITY = i_REL_ENTITY;
oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_FIELD = i_REL_FIELD;
oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_KEY = i_REL_KEY;
oList_Uploaded_files = Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
#endregion
#region Return Section.
return oList_Uploaded_files;
#endregion
}
#endregion
#region BLC_OnPreEvent_Edit_Uploaded_file
void BLC_OnPreEvent_Edit_Uploaded_file(Uploaded_file i_Uploaded_file, BLC.Enum_EditMode i_Enum_EditMode)
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
i_Uploaded_file.STAMP = oTools.Get_Unique_String();
#endregion
}
#endregion
#region BLC_OnPreEvent_Delete_Uploaded_file
void BLC_OnPreEvent_Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file)
{
#region Declaration And Initialization Section.
string str_Full_Path = string.Empty;
Uploaded_file oUploaded_file = new Uploaded_file();
Params_Get_Uploaded_file_By_UPLOADED_FILE_ID oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID = new Params_Get_Uploaded_file_By_UPLOADED_FILE_ID();
string str_Main_Folder = ConfigurationManager.AppSettings["UPLOAD_DOCUMENT_LOCATION"];
#endregion
#region Body Section.
oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID = new Params_Get_Uploaded_file_By_UPLOADED_FILE_ID();
oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID.UPLOADED_FILE_ID = i_Params_Delete_Uploaded_file.UPLOADED_FILE_ID;
oUploaded_file = Get_Uploaded_file_By_UPLOADED_FILE_ID(oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID);
str_Full_Path = string.Format(@"{0}\{1}.{2}", str_Main_Folder, oUploaded_file.UPLOADED_FILE_ID.ToString(), oUploaded_file.EXTENSION);
File.Delete(str_Full_Path);
#endregion
}
#endregion
#region BLC_OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
private void BLC_OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD)
{
#region Declaration And Initialization Section.
string str_Full_Path = string.Empty;
Uploaded_file oUploaded_file = new Uploaded_file();
List<Uploaded_file> oList_Uploaded_files = new List<Uploaded_file>();
Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD();
string str_Main_Folder = ConfigurationManager.AppSettings["UPLOAD_DOCUMENT_LOCATION"];
#endregion
#region Body Section.
oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD = new Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD();
oTools.CopyPropValues(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD, oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
oList_Uploaded_files = Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(oParams_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
if ((oList_Uploaded_files != null) && (oList_Uploaded_files.Count > 0))
{
oUploaded_file = oList_Uploaded_files[oList_Uploaded_files.Count - 1];
str_Full_Path = string.Format(@"{0}\{1}.{2}", str_Main_Folder, oUploaded_file.UPLOADED_FILE_ID.ToString(), oUploaded_file.EXTENSION);
File.Delete(str_Full_Path);
}
#endregion
}
#endregion
#endregion
}
}
