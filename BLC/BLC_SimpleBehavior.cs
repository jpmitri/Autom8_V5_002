using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Configuration;
using DALC;
//using System.Data.Linq;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Reflection;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Threading;







namespace BLC
{
public partial class BLC
{
#region Members
#region Used For Delete Operations
private Floor _Floor;
private Hardware_link _Hardware_link;
private Outlet _Outlet;
private Outlet_type _Outlet_type;
private Outlet_ui _Outlet_ui;
private Owner _Owner;
private Plc _Plc;
private Room _Room;
private Ui _Ui;
private Uploaded_file _Uploaded_file;
private User _User;
#endregion
#region Stop Executing Flags For Edit and Delete Operations
private bool _Stop_Edit_Floor_Execution;
private bool _Stop_Delete_Floor_Execution;
private bool _Stop_Edit_Hardware_link_Execution;
private bool _Stop_Delete_Hardware_link_Execution;
private bool _Stop_Edit_Outlet_Execution;
private bool _Stop_Delete_Outlet_Execution;
private bool _Stop_Edit_Outlet_type_Execution;
private bool _Stop_Delete_Outlet_type_Execution;
private bool _Stop_Edit_Outlet_ui_Execution;
private bool _Stop_Delete_Outlet_ui_Execution;
private bool _Stop_Edit_Owner_Execution;
private bool _Stop_Delete_Owner_Execution;
private bool _Stop_Edit_Plc_Execution;
private bool _Stop_Delete_Plc_Execution;
private bool _Stop_Edit_Room_Execution;
private bool _Stop_Delete_Room_Execution;
private bool _Stop_Edit_Ui_Execution;
private bool _Stop_Delete_Ui_Execution;
private bool _Stop_Edit_Uploaded_file_Execution;
private bool _Stop_Delete_Uploaded_file_Execution;
private bool _Stop_Edit_User_Execution;
private bool _Stop_Delete_User_Execution;
#endregion
#endregion
public Floor Get_Floor_By_FLOOR_ID(Params_Get_Floor_By_FLOOR_ID i_Params_Get_Floor_By_FLOOR_ID)
{
Floor oFloor = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Floor_By_FLOOR_ID");}
#region Body Section.
DALC.Floor oDBEntry = _AppContext.Get_Floor_By_FLOOR_ID(i_Params_Get_Floor_By_FLOOR_ID.FLOOR_ID);
oFloor = new Floor();
oTools.CopyPropValues(oDBEntry, oFloor);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Floor_By_FLOOR_ID");}
return oFloor;
}
public Hardware_link Get_Hardware_link_By_HARDWARE_LINK_ID(Params_Get_Hardware_link_By_HARDWARE_LINK_ID i_Params_Get_Hardware_link_By_HARDWARE_LINK_ID)
{
Hardware_link oHardware_link = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_HARDWARE_LINK_ID");}
#region PreEvent_Get_Hardware_link_By_HARDWARE_LINK_ID
if (OnPreEvent_Get_Hardware_link_By_HARDWARE_LINK_ID != null)
{
OnPreEvent_Get_Hardware_link_By_HARDWARE_LINK_ID(i_Params_Get_Hardware_link_By_HARDWARE_LINK_ID);
}
#endregion
#region Body Section.
DALC.Hardware_link oDBEntry = _AppContext.Get_Hardware_link_By_HARDWARE_LINK_ID(i_Params_Get_Hardware_link_By_HARDWARE_LINK_ID.HARDWARE_LINK_ID);
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
#endregion
#region PostEvent_Get_Hardware_link_By_HARDWARE_LINK_ID
if (OnPostEvent_Get_Hardware_link_By_HARDWARE_LINK_ID != null)
{
OnPostEvent_Get_Hardware_link_By_HARDWARE_LINK_ID(ref oHardware_link,i_Params_Get_Hardware_link_By_HARDWARE_LINK_ID);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_HARDWARE_LINK_ID");}
return oHardware_link;
}
public Outlet Get_Outlet_By_OUTLET_ID(Params_Get_Outlet_By_OUTLET_ID i_Params_Get_Outlet_By_OUTLET_ID)
{
Outlet oOutlet = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_OUTLET_ID");}
#region Body Section.
DALC.Outlet oDBEntry = _AppContext.Get_Outlet_By_OUTLET_ID(i_Params_Get_Outlet_By_OUTLET_ID.OUTLET_ID);
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_OUTLET_ID");}
return oOutlet;
}
public Outlet_type Get_Outlet_type_By_OUTLET_TYPE_ID(Params_Get_Outlet_type_By_OUTLET_TYPE_ID i_Params_Get_Outlet_type_By_OUTLET_TYPE_ID)
{
Outlet_type oOutlet_type = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_type_By_OUTLET_TYPE_ID");}
#region Body Section.
DALC.Outlet_type oDBEntry = _AppContext.Get_Outlet_type_By_OUTLET_TYPE_ID(i_Params_Get_Outlet_type_By_OUTLET_TYPE_ID.OUTLET_TYPE_ID);
oOutlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry, oOutlet_type);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_type_By_OUTLET_TYPE_ID");}
return oOutlet_type;
}
public Outlet_ui Get_Outlet_ui_By_OUTLET_UI_ID(Params_Get_Outlet_ui_By_OUTLET_UI_ID i_Params_Get_Outlet_ui_By_OUTLET_UI_ID)
{
Outlet_ui oOutlet_ui = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_OUTLET_UI_ID");}
#region Body Section.
DALC.Outlet_ui oDBEntry = _AppContext.Get_Outlet_ui_By_OUTLET_UI_ID(i_Params_Get_Outlet_ui_By_OUTLET_UI_ID.OUTLET_UI_ID);
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_OUTLET_UI_ID");}
return oOutlet_ui;
}
public Owner Get_Owner_By_OWNER_ID(Params_Get_Owner_By_OWNER_ID i_Params_Get_Owner_By_OWNER_ID)
{
Owner oOwner = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID");}
#region Body Section.
DALC.Owner oDBEntry = _AppContext.Get_Owner_By_OWNER_ID(i_Params_Get_Owner_By_OWNER_ID.OWNER_ID);
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID");}
return oOwner;
}
public Plc Get_Plc_By_PLC_ID(Params_Get_Plc_By_PLC_ID i_Params_Get_Plc_By_PLC_ID)
{
Plc oPlc = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Plc_By_PLC_ID");}
#region Body Section.
DALC.Plc oDBEntry = _AppContext.Get_Plc_By_PLC_ID(i_Params_Get_Plc_By_PLC_ID.PLC_ID);
oPlc = new Plc();
oTools.CopyPropValues(oDBEntry, oPlc);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Plc_By_PLC_ID");}
return oPlc;
}
public Room Get_Room_By_ROOM_ID(Params_Get_Room_By_ROOM_ID i_Params_Get_Room_By_ROOM_ID)
{
Room oRoom = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_ROOM_ID");}
#region Body Section.
DALC.Room oDBEntry = _AppContext.Get_Room_By_ROOM_ID(i_Params_Get_Room_By_ROOM_ID.ROOM_ID);
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_ROOM_ID");}
return oRoom;
}
public Ui Get_Ui_By_UI_ID(Params_Get_Ui_By_UI_ID i_Params_Get_Ui_By_UI_ID)
{
Ui oUi = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Ui_By_UI_ID");}
#region Body Section.
DALC.Ui oDBEntry = _AppContext.Get_Ui_By_UI_ID(i_Params_Get_Ui_By_UI_ID.UI_ID);
oUi = new Ui();
oTools.CopyPropValues(oDBEntry, oUi);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Ui_By_UI_ID");}
return oUi;
}
public Uploaded_file Get_Uploaded_file_By_UPLOADED_FILE_ID(Params_Get_Uploaded_file_By_UPLOADED_FILE_ID i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID)
{
Uploaded_file oUploaded_file = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID");}
#region Body Section.
DALC.Uploaded_file oDBEntry = _AppContext.Get_Uploaded_file_By_UPLOADED_FILE_ID(i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID.UPLOADED_FILE_ID);
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID");}
return oUploaded_file;
}
public User Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID");}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID");}
return oUser;
}
public List<Floor> Get_Floor_By_FLOOR_ID_List(Params_Get_Floor_By_FLOOR_ID_List i_Params_Get_Floor_By_FLOOR_ID_List)
{
Floor oFloor = null;
List<Floor> oList = new List<Floor>();
Params_Get_Floor_By_FLOOR_ID_List_SP oParams_Get_Floor_By_FLOOR_ID_List_SP = new Params_Get_Floor_By_FLOOR_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Floor_By_FLOOR_ID_List");}
#region Body Section.
List<DALC.Floor> oList_DBEntries = _AppContext.Get_Floor_By_FLOOR_ID_List(i_Params_Get_Floor_By_FLOOR_ID_List.FLOOR_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFloor = new Floor();
oTools.CopyPropValues(oDBEntry, oFloor);
oList.Add(oFloor);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Floor_By_FLOOR_ID_List");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_HARDWARE_LINK_ID_List(Params_Get_Hardware_link_By_HARDWARE_LINK_ID_List i_Params_Get_Hardware_link_By_HARDWARE_LINK_ID_List)
{
Hardware_link oHardware_link = null;
List<Hardware_link> oList = new List<Hardware_link>();
Params_Get_Hardware_link_By_HARDWARE_LINK_ID_List_SP oParams_Get_Hardware_link_By_HARDWARE_LINK_ID_List_SP = new Params_Get_Hardware_link_By_HARDWARE_LINK_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_HARDWARE_LINK_ID_List");}
#region Body Section.
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_HARDWARE_LINK_ID_List(i_Params_Get_Hardware_link_By_HARDWARE_LINK_ID_List.HARDWARE_LINK_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oList.Add(oHardware_link);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_HARDWARE_LINK_ID_List");}
return oList;
}
public List<Outlet> Get_Outlet_By_OUTLET_ID_List(Params_Get_Outlet_By_OUTLET_ID_List i_Params_Get_Outlet_By_OUTLET_ID_List)
{
Outlet oOutlet = null;
List<Outlet> oList = new List<Outlet>();
Params_Get_Outlet_By_OUTLET_ID_List_SP oParams_Get_Outlet_By_OUTLET_ID_List_SP = new Params_Get_Outlet_By_OUTLET_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_OUTLET_ID_List");}
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_OUTLET_ID_List(i_Params_Get_Outlet_By_OUTLET_ID_List.OUTLET_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oList.Add(oOutlet);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_OUTLET_ID_List");}
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_OUTLET_TYPE_ID_List(Params_Get_Outlet_type_By_OUTLET_TYPE_ID_List i_Params_Get_Outlet_type_By_OUTLET_TYPE_ID_List)
{
Outlet_type oOutlet_type = null;
List<Outlet_type> oList = new List<Outlet_type>();
Params_Get_Outlet_type_By_OUTLET_TYPE_ID_List_SP oParams_Get_Outlet_type_By_OUTLET_TYPE_ID_List_SP = new Params_Get_Outlet_type_By_OUTLET_TYPE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_type_By_OUTLET_TYPE_ID_List");}
#region Body Section.
List<DALC.Outlet_type> oList_DBEntries = _AppContext.Get_Outlet_type_By_OUTLET_TYPE_ID_List(i_Params_Get_Outlet_type_By_OUTLET_TYPE_ID_List.OUTLET_TYPE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry, oOutlet_type);
oList.Add(oOutlet_type);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_type_By_OUTLET_TYPE_ID_List");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OUTLET_UI_ID_List(Params_Get_Outlet_ui_By_OUTLET_UI_ID_List i_Params_Get_Outlet_ui_By_OUTLET_UI_ID_List)
{
Outlet_ui oOutlet_ui = null;
List<Outlet_ui> oList = new List<Outlet_ui>();
Params_Get_Outlet_ui_By_OUTLET_UI_ID_List_SP oParams_Get_Outlet_ui_By_OUTLET_UI_ID_List_SP = new Params_Get_Outlet_ui_By_OUTLET_UI_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_OUTLET_UI_ID_List");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_OUTLET_UI_ID_List(i_Params_Get_Outlet_ui_By_OUTLET_UI_ID_List.OUTLET_UI_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_OUTLET_UI_ID_List");}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List(Params_Get_Owner_By_OWNER_ID_List i_Params_Get_Owner_By_OWNER_ID_List)
{
Owner oOwner = null;
List<Owner> oList = new List<Owner>();
Params_Get_Owner_By_OWNER_ID_List_SP oParams_Get_Owner_By_OWNER_ID_List_SP = new Params_Get_Owner_By_OWNER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID_List");}
#region Body Section.
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_OWNER_ID_List(i_Params_Get_Owner_By_OWNER_ID_List.OWNER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID_List");}
return oList;
}
public List<Plc> Get_Plc_By_PLC_ID_List(Params_Get_Plc_By_PLC_ID_List i_Params_Get_Plc_By_PLC_ID_List)
{
Plc oPlc = null;
List<Plc> oList = new List<Plc>();
Params_Get_Plc_By_PLC_ID_List_SP oParams_Get_Plc_By_PLC_ID_List_SP = new Params_Get_Plc_By_PLC_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Plc_By_PLC_ID_List");}
#region Body Section.
List<DALC.Plc> oList_DBEntries = _AppContext.Get_Plc_By_PLC_ID_List(i_Params_Get_Plc_By_PLC_ID_List.PLC_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPlc = new Plc();
oTools.CopyPropValues(oDBEntry, oPlc);
oList.Add(oPlc);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Plc_By_PLC_ID_List");}
return oList;
}
public List<Room> Get_Room_By_ROOM_ID_List(Params_Get_Room_By_ROOM_ID_List i_Params_Get_Room_By_ROOM_ID_List)
{
Room oRoom = null;
List<Room> oList = new List<Room>();
Params_Get_Room_By_ROOM_ID_List_SP oParams_Get_Room_By_ROOM_ID_List_SP = new Params_Get_Room_By_ROOM_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_ROOM_ID_List");}
#region Body Section.
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_ROOM_ID_List(i_Params_Get_Room_By_ROOM_ID_List.ROOM_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oList.Add(oRoom);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_ROOM_ID_List");}
return oList;
}
public List<Ui> Get_Ui_By_UI_ID_List(Params_Get_Ui_By_UI_ID_List i_Params_Get_Ui_By_UI_ID_List)
{
Ui oUi = null;
List<Ui> oList = new List<Ui>();
Params_Get_Ui_By_UI_ID_List_SP oParams_Get_Ui_By_UI_ID_List_SP = new Params_Get_Ui_By_UI_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Ui_By_UI_ID_List");}
#region Body Section.
List<DALC.Ui> oList_DBEntries = _AppContext.Get_Ui_By_UI_ID_List(i_Params_Get_Ui_By_UI_ID_List.UI_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUi = new Ui();
oTools.CopyPropValues(oDBEntry, oUi);
oList.Add(oUi);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Ui_By_UI_ID_List");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_UPLOADED_FILE_ID_List(Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List)
{
Uploaded_file oUploaded_file = null;
List<Uploaded_file> oList = new List<Uploaded_file>();
Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP oParams_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP = new Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID_List");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_UPLOADED_FILE_ID_List(i_Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List.UPLOADED_FILE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_UPLOADED_FILE_ID_List");}
return oList;
}
public List<User> Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List");}
return oList;
}
public List<Floor> Get_Floor_By_OWNER_ID(Params_Get_Floor_By_OWNER_ID i_Params_Get_Floor_By_OWNER_ID)
{
List<Floor> oList = new List<Floor>();
Floor oFloor = new Floor();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Floor_By_OWNER_ID");}
#region PreEvent_Get_Floor_By_OWNER_ID
if (OnPreEvent_Get_Floor_By_OWNER_ID != null)
{
OnPreEvent_Get_Floor_By_OWNER_ID(i_Params_Get_Floor_By_OWNER_ID);
}
#endregion
#region Body Section.
List<DALC.Floor> oList_DBEntries = _AppContext.Get_Floor_By_OWNER_ID(i_Params_Get_Floor_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFloor = new Floor();
oTools.CopyPropValues(oDBEntry, oFloor);
oList.Add(oFloor);
}
}
#endregion
#region PostEvent_Get_Floor_By_OWNER_ID
if (OnPostEvent_Get_Floor_By_OWNER_ID != null)
{
OnPostEvent_Get_Floor_By_OWNER_ID(ref oList,i_Params_Get_Floor_By_OWNER_ID);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Floor_By_OWNER_ID");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_OWNER_ID(Params_Get_Hardware_link_By_OWNER_ID i_Params_Get_Hardware_link_By_OWNER_ID)
{
List<Hardware_link> oList = new List<Hardware_link>();
Hardware_link oHardware_link = new Hardware_link();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_OWNER_ID");}
#region PreEvent_Get_Hardware_link_By_OWNER_ID
if (OnPreEvent_Get_Hardware_link_By_OWNER_ID != null)
{
OnPreEvent_Get_Hardware_link_By_OWNER_ID(i_Params_Get_Hardware_link_By_OWNER_ID);
}
#endregion
#region Body Section.
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_OWNER_ID(i_Params_Get_Hardware_link_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oList.Add(oHardware_link);
}
}
#endregion
#region PostEvent_Get_Hardware_link_By_OWNER_ID
if (OnPostEvent_Get_Hardware_link_By_OWNER_ID != null)
{
OnPostEvent_Get_Hardware_link_By_OWNER_ID(oList,i_Params_Get_Hardware_link_By_OWNER_ID);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_OWNER_ID");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_PLC_ID(Params_Get_Hardware_link_By_PLC_ID i_Params_Get_Hardware_link_By_PLC_ID)
{
List<Hardware_link> oList = new List<Hardware_link>();
Hardware_link oHardware_link = new Hardware_link();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_PLC_ID");}
#region Body Section.
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_PLC_ID(i_Params_Get_Hardware_link_By_PLC_ID.PLC_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oList.Add(oHardware_link);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_PLC_ID");}
return oList;
}
public List<Outlet> Get_Outlet_By_OWNER_ID(Params_Get_Outlet_By_OWNER_ID i_Params_Get_Outlet_By_OWNER_ID)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_OWNER_ID");}
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_OWNER_ID(i_Params_Get_Outlet_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oList.Add(oOutlet);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_OWNER_ID");}
return oList;
}
public List<Outlet> Get_Outlet_By_ROOM_ID(Params_Get_Outlet_By_ROOM_ID i_Params_Get_Outlet_By_ROOM_ID)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_ROOM_ID");}
#region PreEvent_Get_Outlet_By_ROOM_ID
if (OnPreEvent_Get_Outlet_By_ROOM_ID != null)
{
OnPreEvent_Get_Outlet_By_ROOM_ID(i_Params_Get_Outlet_By_ROOM_ID);
}
#endregion
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_ROOM_ID(i_Params_Get_Outlet_By_ROOM_ID.ROOM_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oList.Add(oOutlet);
}
}
#endregion
#region PostEvent_Get_Outlet_By_ROOM_ID
if (OnPostEvent_Get_Outlet_By_ROOM_ID != null)
{
OnPostEvent_Get_Outlet_By_ROOM_ID(ref oList,i_Params_Get_Outlet_By_ROOM_ID);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_ROOM_ID");}
return oList;
}
public List<Outlet> Get_Outlet_By_OUTLET_TYPE_ID(Params_Get_Outlet_By_OUTLET_TYPE_ID i_Params_Get_Outlet_By_OUTLET_TYPE_ID)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_OUTLET_TYPE_ID");}
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_OUTLET_TYPE_ID(i_Params_Get_Outlet_By_OUTLET_TYPE_ID.OUTLET_TYPE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oList.Add(oOutlet);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_OUTLET_TYPE_ID");}
return oList;
}
public List<Outlet> Get_Outlet_By_HARDWARE_LINK_ID(Params_Get_Outlet_By_HARDWARE_LINK_ID i_Params_Get_Outlet_By_HARDWARE_LINK_ID)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_HARDWARE_LINK_ID");}
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_HARDWARE_LINK_ID(i_Params_Get_Outlet_By_HARDWARE_LINK_ID.HARDWARE_LINK_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oList.Add(oOutlet);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_HARDWARE_LINK_ID");}
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_OWNER_ID(Params_Get_Outlet_type_By_OWNER_ID i_Params_Get_Outlet_type_By_OWNER_ID)
{
List<Outlet_type> oList = new List<Outlet_type>();
Outlet_type oOutlet_type = new Outlet_type();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_type_By_OWNER_ID");}
#region Body Section.
List<DALC.Outlet_type> oList_DBEntries = _AppContext.Get_Outlet_type_By_OWNER_ID(i_Params_Get_Outlet_type_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry, oOutlet_type);
oList.Add(oOutlet_type);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_type_By_OWNER_ID");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OWNER_ID(Params_Get_Outlet_ui_By_OWNER_ID i_Params_Get_Outlet_ui_By_OWNER_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_OWNER_ID");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_OWNER_ID(i_Params_Get_Outlet_ui_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_OWNER_ID");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OUTLET_ID(Params_Get_Outlet_ui_By_OUTLET_ID i_Params_Get_Outlet_ui_By_OUTLET_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_OUTLET_ID");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_OUTLET_ID(i_Params_Get_Outlet_ui_By_OUTLET_ID.OUTLET_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_OUTLET_ID");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_UI_ID(Params_Get_Outlet_ui_By_UI_ID i_Params_Get_Outlet_ui_By_UI_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_UI_ID");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_UI_ID(i_Params_Get_Outlet_ui_By_UI_ID.UI_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_UI_ID");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_USER_ID(Params_Get_Outlet_ui_By_USER_ID i_Params_Get_Outlet_ui_By_USER_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_USER_ID");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_USER_ID(i_Params_Get_Outlet_ui_By_USER_ID.USER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_USER_ID");}
return oList;
}
public List<Plc> Get_Plc_By_OWNER_ID(Params_Get_Plc_By_OWNER_ID i_Params_Get_Plc_By_OWNER_ID)
{
List<Plc> oList = new List<Plc>();
Plc oPlc = new Plc();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Plc_By_OWNER_ID");}
#region PreEvent_Get_Plc_By_OWNER_ID
if (OnPreEvent_Get_Plc_By_OWNER_ID != null)
{
OnPreEvent_Get_Plc_By_OWNER_ID(i_Params_Get_Plc_By_OWNER_ID);
}
#endregion
#region Body Section.
List<DALC.Plc> oList_DBEntries = _AppContext.Get_Plc_By_OWNER_ID(i_Params_Get_Plc_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPlc = new Plc();
oTools.CopyPropValues(oDBEntry, oPlc);
oList.Add(oPlc);
}
}
#endregion
#region PostEvent_Get_Plc_By_OWNER_ID
if (OnPostEvent_Get_Plc_By_OWNER_ID != null)
{
OnPostEvent_Get_Plc_By_OWNER_ID(oList,i_Params_Get_Plc_By_OWNER_ID);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Plc_By_OWNER_ID");}
return oList;
}
public List<Room> Get_Room_By_OWNER_ID(Params_Get_Room_By_OWNER_ID i_Params_Get_Room_By_OWNER_ID)
{
List<Room> oList = new List<Room>();
Room oRoom = new Room();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_OWNER_ID");}
#region Body Section.
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_OWNER_ID(i_Params_Get_Room_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oList.Add(oRoom);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_OWNER_ID");}
return oList;
}
public List<Room> Get_Room_By_FLOOR_ID(Params_Get_Room_By_FLOOR_ID i_Params_Get_Room_By_FLOOR_ID)
{
List<Room> oList = new List<Room>();
Room oRoom = new Room();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_FLOOR_ID");}
#region PreEvent_Get_Room_By_FLOOR_ID
if (OnPreEvent_Get_Room_By_FLOOR_ID != null)
{
OnPreEvent_Get_Room_By_FLOOR_ID(i_Params_Get_Room_By_FLOOR_ID);
}
#endregion
#region Body Section.
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_FLOOR_ID(i_Params_Get_Room_By_FLOOR_ID.FLOOR_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oList.Add(oRoom);
}
}
#endregion
#region PostEvent_Get_Room_By_FLOOR_ID
if (OnPostEvent_Get_Room_By_FLOOR_ID != null)
{
OnPostEvent_Get_Room_By_FLOOR_ID(ref oList,i_Params_Get_Room_By_FLOOR_ID);
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_FLOOR_ID");}
return oList;
}
public List<Ui> Get_Ui_By_OWNER_ID(Params_Get_Ui_By_OWNER_ID i_Params_Get_Ui_By_OWNER_ID)
{
List<Ui> oList = new List<Ui>();
Ui oUi = new Ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Ui_By_OWNER_ID");}
#region Body Section.
List<DALC.Ui> oList_DBEntries = _AppContext.Get_Ui_By_OWNER_ID(i_Params_Get_Ui_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUi = new Ui();
oTools.CopyPropValues(oDBEntry, oUi);
oList.Add(oUi);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Ui_By_OWNER_ID");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_OWNER_ID(Params_Get_Uploaded_file_By_OWNER_ID i_Params_Get_Uploaded_file_By_OWNER_ID)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_OWNER_ID");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_OWNER_ID(i_Params_Get_Uploaded_file_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_OWNER_ID");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY(Params_Get_Uploaded_file_By_REL_ENTITY i_Params_Get_Uploaded_file_By_REL_ENTITY)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_REL_ENTITY");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_REL_ENTITY(i_Params_Get_Uploaded_file_By_REL_ENTITY.REL_ENTITY);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_REL_ENTITY");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY(Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_REL_ENTITY_REL_KEY(i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_ENTITY,i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_KEY);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
#region Body Section.
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_ENTITY,i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_KEY,i_Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_FIELD);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
return oList;
}
public List<User> Get_User_By_OWNER_ID(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID");}
return oList;
}
public List<User> Get_User_By_USERNAME(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME(i_Params_Get_User_By_USERNAME.USERNAME);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_PLC_ID_List(Params_Get_Hardware_link_By_PLC_ID_List i_Params_Get_Hardware_link_By_PLC_ID_List)
{
List<Hardware_link> oList = new List<Hardware_link>();
Hardware_link oHardware_link = new Hardware_link();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_PLC_ID_List");}
#region Body Section.
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_PLC_ID_List(i_Params_Get_Hardware_link_By_PLC_ID_List.PLC_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oList.Add(oHardware_link);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_PLC_ID_List");}
return oList;
}
public List<Outlet> Get_Outlet_By_ROOM_ID_List(Params_Get_Outlet_By_ROOM_ID_List i_Params_Get_Outlet_By_ROOM_ID_List)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_ROOM_ID_List");}
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_ROOM_ID_List(i_Params_Get_Outlet_By_ROOM_ID_List.ROOM_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oList.Add(oOutlet);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_ROOM_ID_List");}
return oList;
}
public List<Outlet> Get_Outlet_By_OUTLET_TYPE_ID_List(Params_Get_Outlet_By_OUTLET_TYPE_ID_List i_Params_Get_Outlet_By_OUTLET_TYPE_ID_List)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_OUTLET_TYPE_ID_List");}
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_OUTLET_TYPE_ID_List(i_Params_Get_Outlet_By_OUTLET_TYPE_ID_List.OUTLET_TYPE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oList.Add(oOutlet);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_OUTLET_TYPE_ID_List");}
return oList;
}
public List<Outlet> Get_Outlet_By_HARDWARE_LINK_ID_List(Params_Get_Outlet_By_HARDWARE_LINK_ID_List i_Params_Get_Outlet_By_HARDWARE_LINK_ID_List)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_HARDWARE_LINK_ID_List");}
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_HARDWARE_LINK_ID_List(i_Params_Get_Outlet_By_HARDWARE_LINK_ID_List.HARDWARE_LINK_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oList.Add(oOutlet);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_HARDWARE_LINK_ID_List");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OUTLET_ID_List(Params_Get_Outlet_ui_By_OUTLET_ID_List i_Params_Get_Outlet_ui_By_OUTLET_ID_List)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_OUTLET_ID_List");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_OUTLET_ID_List(i_Params_Get_Outlet_ui_By_OUTLET_ID_List.OUTLET_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_OUTLET_ID_List");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_UI_ID_List(Params_Get_Outlet_ui_By_UI_ID_List i_Params_Get_Outlet_ui_By_UI_ID_List)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_UI_ID_List");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_UI_ID_List(i_Params_Get_Outlet_ui_By_UI_ID_List.UI_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_UI_ID_List");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_USER_ID_List(Params_Get_Outlet_ui_By_USER_ID_List i_Params_Get_Outlet_ui_By_USER_ID_List)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_USER_ID_List");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_USER_ID_List(i_Params_Get_Outlet_ui_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_USER_ID_List");}
return oList;
}
public List<Room> Get_Room_By_FLOOR_ID_List(Params_Get_Room_By_FLOOR_ID_List i_Params_Get_Room_By_FLOOR_ID_List)
{
List<Room> oList = new List<Room>();
Room oRoom = new Room();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_FLOOR_ID_List");}
#region Body Section.
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_FLOOR_ID_List(i_Params_Get_Room_By_FLOOR_ID_List.FLOOR_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oList.Add(oRoom);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_FLOOR_ID_List");}
return oList;
}
public List<Floor> Get_Floor_By_Criteria(Params_Get_Floor_By_Criteria i_Params_Get_Floor_By_Criteria)
{
List<Floor> oList = new List<Floor>();
Floor oFloor = new Floor();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Floor_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Floor_By_Criteria.OWNER_ID == null) || (i_Params_Get_Floor_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Floor_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Floor_By_Criteria.START_ROW == null) { i_Params_Get_Floor_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Floor_By_Criteria.END_ROW == null) || (i_Params_Get_Floor_By_Criteria.END_ROW == 0)) { i_Params_Get_Floor_By_Criteria.END_ROW = 1000000; }
List<DALC.Floor> oList_DBEntries = _AppContext.Get_Floor_By_Criteria(i_Params_Get_Floor_By_Criteria.NAME,i_Params_Get_Floor_By_Criteria.OWNER_ID,i_Params_Get_Floor_By_Criteria.START_ROW,i_Params_Get_Floor_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFloor = new Floor();
oTools.CopyPropValues(oDBEntry, oFloor);
oList.Add(oFloor);
}
}
i_Params_Get_Floor_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Floor_By_Criteria");}
return oList;
}
public List<Floor> Get_Floor_By_Where(Params_Get_Floor_By_Where i_Params_Get_Floor_By_Where)
{
List<Floor> oList = new List<Floor>();
Floor oFloor = new Floor();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Floor_By_Where");}
#region Body Section.
if ((i_Params_Get_Floor_By_Where.OWNER_ID == null) || (i_Params_Get_Floor_By_Where.OWNER_ID == 0)) { i_Params_Get_Floor_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Floor_By_Where.START_ROW == null) { i_Params_Get_Floor_By_Where.START_ROW = 0; }
if ((i_Params_Get_Floor_By_Where.END_ROW == null) || (i_Params_Get_Floor_By_Where.END_ROW == 0)) { i_Params_Get_Floor_By_Where.END_ROW = 1000000; }
List<DALC.Floor> oList_DBEntries = _AppContext.Get_Floor_By_Where(i_Params_Get_Floor_By_Where.NAME,i_Params_Get_Floor_By_Where.OWNER_ID,i_Params_Get_Floor_By_Where.START_ROW,i_Params_Get_Floor_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFloor = new Floor();
oTools.CopyPropValues(oDBEntry, oFloor);
oList.Add(oFloor);
}
}
i_Params_Get_Floor_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Floor_By_Where");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Criteria(Params_Get_Hardware_link_By_Criteria i_Params_Get_Hardware_link_By_Criteria)
{
List<Hardware_link> oList = new List<Hardware_link>();
Hardware_link oHardware_link = new Hardware_link();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Hardware_link_By_Criteria.OWNER_ID == null) || (i_Params_Get_Hardware_link_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Hardware_link_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Hardware_link_By_Criteria.START_ROW == null) { i_Params_Get_Hardware_link_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Hardware_link_By_Criteria.END_ROW == null) || (i_Params_Get_Hardware_link_By_Criteria.END_ROW == 0)) { i_Params_Get_Hardware_link_By_Criteria.END_ROW = 1000000; }
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_Criteria(i_Params_Get_Hardware_link_By_Criteria.PLC_ADDRESS,i_Params_Get_Hardware_link_By_Criteria.OWNER_ID,i_Params_Get_Hardware_link_By_Criteria.START_ROW,i_Params_Get_Hardware_link_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oList.Add(oHardware_link);
}
}
i_Params_Get_Hardware_link_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_Criteria");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Where(Params_Get_Hardware_link_By_Where i_Params_Get_Hardware_link_By_Where)
{
List<Hardware_link> oList = new List<Hardware_link>();
Hardware_link oHardware_link = new Hardware_link();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_Where");}
#region Body Section.
if ((i_Params_Get_Hardware_link_By_Where.OWNER_ID == null) || (i_Params_Get_Hardware_link_By_Where.OWNER_ID == 0)) { i_Params_Get_Hardware_link_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Hardware_link_By_Where.START_ROW == null) { i_Params_Get_Hardware_link_By_Where.START_ROW = 0; }
if ((i_Params_Get_Hardware_link_By_Where.END_ROW == null) || (i_Params_Get_Hardware_link_By_Where.END_ROW == 0)) { i_Params_Get_Hardware_link_By_Where.END_ROW = 1000000; }
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_Where(i_Params_Get_Hardware_link_By_Where.PLC_ADDRESS,i_Params_Get_Hardware_link_By_Where.OWNER_ID,i_Params_Get_Hardware_link_By_Where.START_ROW,i_Params_Get_Hardware_link_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oList.Add(oHardware_link);
}
}
i_Params_Get_Hardware_link_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_Where");}
return oList;
}
public List<Outlet> Get_Outlet_By_Criteria(Params_Get_Outlet_By_Criteria i_Params_Get_Outlet_By_Criteria)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Outlet_By_Criteria.OWNER_ID == null) || (i_Params_Get_Outlet_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Outlet_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_By_Criteria.START_ROW == null) { i_Params_Get_Outlet_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Outlet_By_Criteria.END_ROW == null) || (i_Params_Get_Outlet_By_Criteria.END_ROW == 0)) { i_Params_Get_Outlet_By_Criteria.END_ROW = 1000000; }
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_Criteria(i_Params_Get_Outlet_By_Criteria.NAME,i_Params_Get_Outlet_By_Criteria.CURRENT_VALUE,i_Params_Get_Outlet_By_Criteria.OWNER_ID,i_Params_Get_Outlet_By_Criteria.START_ROW,i_Params_Get_Outlet_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oList.Add(oOutlet);
}
}
i_Params_Get_Outlet_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_Criteria");}
return oList;
}
public List<Outlet> Get_Outlet_By_Where(Params_Get_Outlet_By_Where i_Params_Get_Outlet_By_Where)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_Where");}
#region Body Section.
if ((i_Params_Get_Outlet_By_Where.OWNER_ID == null) || (i_Params_Get_Outlet_By_Where.OWNER_ID == 0)) { i_Params_Get_Outlet_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_By_Where.START_ROW == null) { i_Params_Get_Outlet_By_Where.START_ROW = 0; }
if ((i_Params_Get_Outlet_By_Where.END_ROW == null) || (i_Params_Get_Outlet_By_Where.END_ROW == 0)) { i_Params_Get_Outlet_By_Where.END_ROW = 1000000; }
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_Where(i_Params_Get_Outlet_By_Where.NAME,i_Params_Get_Outlet_By_Where.CURRENT_VALUE,i_Params_Get_Outlet_By_Where.OWNER_ID,i_Params_Get_Outlet_By_Where.START_ROW,i_Params_Get_Outlet_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oList.Add(oOutlet);
}
}
i_Params_Get_Outlet_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_Where");}
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_Criteria(Params_Get_Outlet_type_By_Criteria i_Params_Get_Outlet_type_By_Criteria)
{
List<Outlet_type> oList = new List<Outlet_type>();
Outlet_type oOutlet_type = new Outlet_type();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_type_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Outlet_type_By_Criteria.OWNER_ID == null) || (i_Params_Get_Outlet_type_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Outlet_type_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_type_By_Criteria.START_ROW == null) { i_Params_Get_Outlet_type_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Outlet_type_By_Criteria.END_ROW == null) || (i_Params_Get_Outlet_type_By_Criteria.END_ROW == 0)) { i_Params_Get_Outlet_type_By_Criteria.END_ROW = 1000000; }
List<DALC.Outlet_type> oList_DBEntries = _AppContext.Get_Outlet_type_By_Criteria(i_Params_Get_Outlet_type_By_Criteria.NAME,i_Params_Get_Outlet_type_By_Criteria.OWNER_ID,i_Params_Get_Outlet_type_By_Criteria.START_ROW,i_Params_Get_Outlet_type_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry, oOutlet_type);
oList.Add(oOutlet_type);
}
}
i_Params_Get_Outlet_type_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_type_By_Criteria");}
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_Where(Params_Get_Outlet_type_By_Where i_Params_Get_Outlet_type_By_Where)
{
List<Outlet_type> oList = new List<Outlet_type>();
Outlet_type oOutlet_type = new Outlet_type();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_type_By_Where");}
#region Body Section.
if ((i_Params_Get_Outlet_type_By_Where.OWNER_ID == null) || (i_Params_Get_Outlet_type_By_Where.OWNER_ID == 0)) { i_Params_Get_Outlet_type_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_type_By_Where.START_ROW == null) { i_Params_Get_Outlet_type_By_Where.START_ROW = 0; }
if ((i_Params_Get_Outlet_type_By_Where.END_ROW == null) || (i_Params_Get_Outlet_type_By_Where.END_ROW == 0)) { i_Params_Get_Outlet_type_By_Where.END_ROW = 1000000; }
List<DALC.Outlet_type> oList_DBEntries = _AppContext.Get_Outlet_type_By_Where(i_Params_Get_Outlet_type_By_Where.NAME,i_Params_Get_Outlet_type_By_Where.OWNER_ID,i_Params_Get_Outlet_type_By_Where.START_ROW,i_Params_Get_Outlet_type_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry, oOutlet_type);
oList.Add(oOutlet_type);
}
}
i_Params_Get_Outlet_type_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_type_By_Where");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Criteria(Params_Get_Outlet_ui_By_Criteria i_Params_Get_Outlet_ui_By_Criteria)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Outlet_ui_By_Criteria.OWNER_ID == null) || (i_Params_Get_Outlet_ui_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Outlet_ui_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_ui_By_Criteria.START_ROW == null) { i_Params_Get_Outlet_ui_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Outlet_ui_By_Criteria.END_ROW == null) || (i_Params_Get_Outlet_ui_By_Criteria.END_ROW == 0)) { i_Params_Get_Outlet_ui_By_Criteria.END_ROW = 1000000; }
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_Criteria(i_Params_Get_Outlet_ui_By_Criteria.DESCRIPTION,i_Params_Get_Outlet_ui_By_Criteria.OWNER_ID,i_Params_Get_Outlet_ui_By_Criteria.START_ROW,i_Params_Get_Outlet_ui_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oList.Add(oOutlet_ui);
}
}
i_Params_Get_Outlet_ui_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_Criteria");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Where(Params_Get_Outlet_ui_By_Where i_Params_Get_Outlet_ui_By_Where)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_Where");}
#region Body Section.
if ((i_Params_Get_Outlet_ui_By_Where.OWNER_ID == null) || (i_Params_Get_Outlet_ui_By_Where.OWNER_ID == 0)) { i_Params_Get_Outlet_ui_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_ui_By_Where.START_ROW == null) { i_Params_Get_Outlet_ui_By_Where.START_ROW = 0; }
if ((i_Params_Get_Outlet_ui_By_Where.END_ROW == null) || (i_Params_Get_Outlet_ui_By_Where.END_ROW == 0)) { i_Params_Get_Outlet_ui_By_Where.END_ROW = 1000000; }
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_Where(i_Params_Get_Outlet_ui_By_Where.DESCRIPTION,i_Params_Get_Outlet_ui_By_Where.OWNER_ID,i_Params_Get_Outlet_ui_By_Where.START_ROW,i_Params_Get_Outlet_ui_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oList.Add(oOutlet_ui);
}
}
i_Params_Get_Outlet_ui_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_Where");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria(Params_Get_Owner_By_Criteria i_Params_Get_Owner_By_Criteria)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria.START_ROW == null) { i_Params_Get_Owner_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria.END_ROW == null) || (i_Params_Get_Owner_By_Criteria.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria(i_Params_Get_Owner_By_Criteria.CODE,i_Params_Get_Owner_By_Criteria.DESCRIPTION,i_Params_Get_Owner_By_Criteria.OWNER_ID,i_Params_Get_Owner_By_Criteria.START_ROW,i_Params_Get_Owner_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria");}
return oList;
}
public List<Owner> Get_Owner_By_Where(Params_Get_Owner_By_Where i_Params_Get_Owner_By_Where)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where");}
#region Body Section.
if ((i_Params_Get_Owner_By_Where.OWNER_ID == null) || (i_Params_Get_Owner_By_Where.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where.START_ROW == null) { i_Params_Get_Owner_By_Where.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where.END_ROW == null) || (i_Params_Get_Owner_By_Where.END_ROW == 0)) { i_Params_Get_Owner_By_Where.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where(i_Params_Get_Owner_By_Where.CODE,i_Params_Get_Owner_By_Where.DESCRIPTION,i_Params_Get_Owner_By_Where.OWNER_ID,i_Params_Get_Owner_By_Where.START_ROW,i_Params_Get_Owner_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2(Params_Get_Owner_By_Criteria_V2 i_Params_Get_Owner_By_Criteria_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria_V2.START_ROW == null) { i_Params_Get_Owner_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Owner_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria_V2(i_Params_Get_Owner_By_Criteria_V2.CODE,i_Params_Get_Owner_By_Criteria_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Criteria_V2.DESCRIPTION,i_Params_Get_Owner_By_Criteria_V2.OWNER_ID,i_Params_Get_Owner_By_Criteria_V2.START_ROW,i_Params_Get_Owner_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria_V2");}
return oList;
}
public List<Owner> Get_Owner_By_Where_V2(Params_Get_Owner_By_Where_V2 i_Params_Get_Owner_By_Where_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Owner_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where_V2.START_ROW == null) { i_Params_Get_Owner_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where_V2.END_ROW == null) || (i_Params_Get_Owner_By_Where_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Where_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where_V2(i_Params_Get_Owner_By_Where_V2.CODE,i_Params_Get_Owner_By_Where_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Where_V2.DESCRIPTION,i_Params_Get_Owner_By_Where_V2.OWNER_ID,i_Params_Get_Owner_By_Where_V2.START_ROW,i_Params_Get_Owner_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where_V2");}
return oList;
}
public List<Plc> Get_Plc_By_Criteria(Params_Get_Plc_By_Criteria i_Params_Get_Plc_By_Criteria)
{
List<Plc> oList = new List<Plc>();
Plc oPlc = new Plc();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Plc_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Plc_By_Criteria.OWNER_ID == null) || (i_Params_Get_Plc_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Plc_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Plc_By_Criteria.START_ROW == null) { i_Params_Get_Plc_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Plc_By_Criteria.END_ROW == null) || (i_Params_Get_Plc_By_Criteria.END_ROW == 0)) { i_Params_Get_Plc_By_Criteria.END_ROW = 1000000; }
List<DALC.Plc> oList_DBEntries = _AppContext.Get_Plc_By_Criteria(i_Params_Get_Plc_By_Criteria.LOCATION,i_Params_Get_Plc_By_Criteria.PORT,i_Params_Get_Plc_By_Criteria.TYPE,i_Params_Get_Plc_By_Criteria.OWNER_ID,i_Params_Get_Plc_By_Criteria.START_ROW,i_Params_Get_Plc_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPlc = new Plc();
oTools.CopyPropValues(oDBEntry, oPlc);
oList.Add(oPlc);
}
}
i_Params_Get_Plc_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Plc_By_Criteria");}
return oList;
}
public List<Plc> Get_Plc_By_Where(Params_Get_Plc_By_Where i_Params_Get_Plc_By_Where)
{
List<Plc> oList = new List<Plc>();
Plc oPlc = new Plc();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Plc_By_Where");}
#region Body Section.
if ((i_Params_Get_Plc_By_Where.OWNER_ID == null) || (i_Params_Get_Plc_By_Where.OWNER_ID == 0)) { i_Params_Get_Plc_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Plc_By_Where.START_ROW == null) { i_Params_Get_Plc_By_Where.START_ROW = 0; }
if ((i_Params_Get_Plc_By_Where.END_ROW == null) || (i_Params_Get_Plc_By_Where.END_ROW == 0)) { i_Params_Get_Plc_By_Where.END_ROW = 1000000; }
List<DALC.Plc> oList_DBEntries = _AppContext.Get_Plc_By_Where(i_Params_Get_Plc_By_Where.LOCATION,i_Params_Get_Plc_By_Where.PORT,i_Params_Get_Plc_By_Where.TYPE,i_Params_Get_Plc_By_Where.OWNER_ID,i_Params_Get_Plc_By_Where.START_ROW,i_Params_Get_Plc_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPlc = new Plc();
oTools.CopyPropValues(oDBEntry, oPlc);
oList.Add(oPlc);
}
}
i_Params_Get_Plc_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Plc_By_Where");}
return oList;
}
public List<Room> Get_Room_By_Criteria(Params_Get_Room_By_Criteria i_Params_Get_Room_By_Criteria)
{
List<Room> oList = new List<Room>();
Room oRoom = new Room();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Room_By_Criteria.OWNER_ID == null) || (i_Params_Get_Room_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Room_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Room_By_Criteria.START_ROW == null) { i_Params_Get_Room_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Room_By_Criteria.END_ROW == null) || (i_Params_Get_Room_By_Criteria.END_ROW == 0)) { i_Params_Get_Room_By_Criteria.END_ROW = 1000000; }
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_Criteria(i_Params_Get_Room_By_Criteria.NAME,i_Params_Get_Room_By_Criteria.OWNER_ID,i_Params_Get_Room_By_Criteria.START_ROW,i_Params_Get_Room_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oList.Add(oRoom);
}
}
i_Params_Get_Room_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_Criteria");}
return oList;
}
public List<Room> Get_Room_By_Where(Params_Get_Room_By_Where i_Params_Get_Room_By_Where)
{
List<Room> oList = new List<Room>();
Room oRoom = new Room();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_Where");}
#region Body Section.
if ((i_Params_Get_Room_By_Where.OWNER_ID == null) || (i_Params_Get_Room_By_Where.OWNER_ID == 0)) { i_Params_Get_Room_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Room_By_Where.START_ROW == null) { i_Params_Get_Room_By_Where.START_ROW = 0; }
if ((i_Params_Get_Room_By_Where.END_ROW == null) || (i_Params_Get_Room_By_Where.END_ROW == 0)) { i_Params_Get_Room_By_Where.END_ROW = 1000000; }
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_Where(i_Params_Get_Room_By_Where.NAME,i_Params_Get_Room_By_Where.OWNER_ID,i_Params_Get_Room_By_Where.START_ROW,i_Params_Get_Room_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oList.Add(oRoom);
}
}
i_Params_Get_Room_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_Where");}
return oList;
}
public List<Ui> Get_Ui_By_Criteria(Params_Get_Ui_By_Criteria i_Params_Get_Ui_By_Criteria)
{
List<Ui> oList = new List<Ui>();
Ui oUi = new Ui();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Ui_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Ui_By_Criteria.OWNER_ID == null) || (i_Params_Get_Ui_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Ui_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Ui_By_Criteria.START_ROW == null) { i_Params_Get_Ui_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Ui_By_Criteria.END_ROW == null) || (i_Params_Get_Ui_By_Criteria.END_ROW == 0)) { i_Params_Get_Ui_By_Criteria.END_ROW = 1000000; }
List<DALC.Ui> oList_DBEntries = _AppContext.Get_Ui_By_Criteria(i_Params_Get_Ui_By_Criteria.COLOR,i_Params_Get_Ui_By_Criteria.OTHER,i_Params_Get_Ui_By_Criteria.OWNER_ID,i_Params_Get_Ui_By_Criteria.START_ROW,i_Params_Get_Ui_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUi = new Ui();
oTools.CopyPropValues(oDBEntry, oUi);
oList.Add(oUi);
}
}
i_Params_Get_Ui_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Ui_By_Criteria");}
return oList;
}
public List<Ui> Get_Ui_By_Where(Params_Get_Ui_By_Where i_Params_Get_Ui_By_Where)
{
List<Ui> oList = new List<Ui>();
Ui oUi = new Ui();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Ui_By_Where");}
#region Body Section.
if ((i_Params_Get_Ui_By_Where.OWNER_ID == null) || (i_Params_Get_Ui_By_Where.OWNER_ID == 0)) { i_Params_Get_Ui_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Ui_By_Where.START_ROW == null) { i_Params_Get_Ui_By_Where.START_ROW = 0; }
if ((i_Params_Get_Ui_By_Where.END_ROW == null) || (i_Params_Get_Ui_By_Where.END_ROW == 0)) { i_Params_Get_Ui_By_Where.END_ROW = 1000000; }
List<DALC.Ui> oList_DBEntries = _AppContext.Get_Ui_By_Where(i_Params_Get_Ui_By_Where.COLOR,i_Params_Get_Ui_By_Where.OTHER,i_Params_Get_Ui_By_Where.OWNER_ID,i_Params_Get_Ui_By_Where.START_ROW,i_Params_Get_Ui_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUi = new Ui();
oTools.CopyPropValues(oDBEntry, oUi);
oList.Add(oUi);
}
}
i_Params_Get_Ui_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Ui_By_Where");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_Criteria(Params_Get_Uploaded_file_By_Criteria i_Params_Get_Uploaded_file_By_Criteria)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID == null) || (i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Uploaded_file_By_Criteria.START_ROW == null) { i_Params_Get_Uploaded_file_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Uploaded_file_By_Criteria.END_ROW == null) || (i_Params_Get_Uploaded_file_By_Criteria.END_ROW == 0)) { i_Params_Get_Uploaded_file_By_Criteria.END_ROW = 1000000; }
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_Criteria(i_Params_Get_Uploaded_file_By_Criteria.REL_ENTITY,i_Params_Get_Uploaded_file_By_Criteria.REL_FIELD,i_Params_Get_Uploaded_file_By_Criteria.EXTENSION,i_Params_Get_Uploaded_file_By_Criteria.URL,i_Params_Get_Uploaded_file_By_Criteria.STAMP,i_Params_Get_Uploaded_file_By_Criteria.OWNER_ID,i_Params_Get_Uploaded_file_By_Criteria.START_ROW,i_Params_Get_Uploaded_file_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
i_Params_Get_Uploaded_file_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_Criteria");}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_Where(Params_Get_Uploaded_file_By_Where i_Params_Get_Uploaded_file_By_Where)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
Uploaded_file oUploaded_file = new Uploaded_file();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Uploaded_file_By_Where");}
#region Body Section.
if ((i_Params_Get_Uploaded_file_By_Where.OWNER_ID == null) || (i_Params_Get_Uploaded_file_By_Where.OWNER_ID == 0)) { i_Params_Get_Uploaded_file_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Uploaded_file_By_Where.START_ROW == null) { i_Params_Get_Uploaded_file_By_Where.START_ROW = 0; }
if ((i_Params_Get_Uploaded_file_By_Where.END_ROW == null) || (i_Params_Get_Uploaded_file_By_Where.END_ROW == 0)) { i_Params_Get_Uploaded_file_By_Where.END_ROW = 1000000; }
List<DALC.Uploaded_file> oList_DBEntries = _AppContext.Get_Uploaded_file_By_Where(i_Params_Get_Uploaded_file_By_Where.REL_ENTITY,i_Params_Get_Uploaded_file_By_Where.REL_FIELD,i_Params_Get_Uploaded_file_By_Where.EXTENSION,i_Params_Get_Uploaded_file_By_Where.URL,i_Params_Get_Uploaded_file_By_Where.STAMP,i_Params_Get_Uploaded_file_By_Where.OWNER_ID,i_Params_Get_Uploaded_file_By_Where.START_ROW,i_Params_Get_Uploaded_file_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUploaded_file = new Uploaded_file();
oTools.CopyPropValues(oDBEntry, oUploaded_file);
oList.Add(oUploaded_file);
}
}
i_Params_Get_Uploaded_file_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Uploaded_file_By_Where");}
return oList;
}
public List<User> Get_User_By_Criteria(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria");}
return oList;
}
public List<User> Get_User_By_Where(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where");}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Criteria_InList(Params_Get_Hardware_link_By_Criteria_InList i_Params_Get_Hardware_link_By_Criteria_InList)
{
List<Hardware_link> oList = new List<Hardware_link>();
Hardware_link oHardware_link = new Hardware_link();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Hardware_link_By_Criteria_InList_SP oParams_Get_Hardware_link_By_Criteria_InList_SP = new Params_Get_Hardware_link_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Hardware_link_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Hardware_link_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Hardware_link_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Hardware_link_By_Criteria_InList.START_ROW == null) { i_Params_Get_Hardware_link_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Hardware_link_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Hardware_link_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Hardware_link_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Hardware_link_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Hardware_link_By_Criteria_InList.OWNER_ID;
oParams_Get_Hardware_link_By_Criteria_InList_SP.PLC_ADDRESS = i_Params_Get_Hardware_link_By_Criteria_InList.PLC_ADDRESS;
if ( i_Params_Get_Hardware_link_By_Criteria_InList.PLC_ID_LIST == null)
{
i_Params_Get_Hardware_link_By_Criteria_InList.PLC_ID_LIST = new List<Int32?>();
}
oParams_Get_Hardware_link_By_Criteria_InList_SP.PLC_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Hardware_link_By_Criteria_InList.PLC_ID_LIST);
oParams_Get_Hardware_link_By_Criteria_InList_SP.START_ROW = i_Params_Get_Hardware_link_By_Criteria_InList.START_ROW;
oParams_Get_Hardware_link_By_Criteria_InList_SP.END_ROW = i_Params_Get_Hardware_link_By_Criteria_InList.END_ROW;
oParams_Get_Hardware_link_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Hardware_link_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_Criteria_InList(i_Params_Get_Hardware_link_By_Criteria_InList.PLC_ADDRESS,i_Params_Get_Hardware_link_By_Criteria_InList.PLC_ID_LIST,i_Params_Get_Hardware_link_By_Criteria_InList.OWNER_ID,i_Params_Get_Hardware_link_By_Criteria_InList.START_ROW,i_Params_Get_Hardware_link_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oList.Add(oHardware_link);
}
}
i_Params_Get_Hardware_link_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Hardware_link_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Hardware_link_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_Criteria_InList");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Where_InList(Params_Get_Hardware_link_By_Where_InList i_Params_Get_Hardware_link_By_Where_InList)
{
List<Hardware_link> oList = new List<Hardware_link>();
Hardware_link oHardware_link = new Hardware_link();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Hardware_link_By_Where_InList_SP oParams_Get_Hardware_link_By_Where_InList_SP = new Params_Get_Hardware_link_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Hardware_link_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Hardware_link_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Hardware_link_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Hardware_link_By_Where_InList.START_ROW == null) { i_Params_Get_Hardware_link_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Hardware_link_By_Where_InList.END_ROW == null) || (i_Params_Get_Hardware_link_By_Where_InList.END_ROW == 0)) { i_Params_Get_Hardware_link_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Hardware_link_By_Where_InList_SP.OWNER_ID = i_Params_Get_Hardware_link_By_Where_InList.OWNER_ID;
oParams_Get_Hardware_link_By_Where_InList_SP.PLC_ADDRESS = i_Params_Get_Hardware_link_By_Where_InList.PLC_ADDRESS;
if ( i_Params_Get_Hardware_link_By_Where_InList.PLC_ID_LIST == null)
{
i_Params_Get_Hardware_link_By_Where_InList.PLC_ID_LIST = new List<Int32?>();
}
oParams_Get_Hardware_link_By_Where_InList_SP.PLC_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Hardware_link_By_Where_InList.PLC_ID_LIST);
oParams_Get_Hardware_link_By_Where_InList_SP.START_ROW = i_Params_Get_Hardware_link_By_Where_InList.START_ROW;
oParams_Get_Hardware_link_By_Where_InList_SP.END_ROW = i_Params_Get_Hardware_link_By_Where_InList.END_ROW;
oParams_Get_Hardware_link_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Hardware_link_By_Where_InList.TOTAL_COUNT;
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_Where_InList(i_Params_Get_Hardware_link_By_Where_InList.PLC_ADDRESS,i_Params_Get_Hardware_link_By_Where_InList.PLC_ID_LIST,i_Params_Get_Hardware_link_By_Where_InList.OWNER_ID,i_Params_Get_Hardware_link_By_Where_InList.START_ROW,i_Params_Get_Hardware_link_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oList.Add(oHardware_link);
}
}
i_Params_Get_Hardware_link_By_Where_InList.TOTAL_COUNT = oParams_Get_Hardware_link_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Hardware_link_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_Where_InList");}
return oList;
}
public List<Outlet> Get_Outlet_By_Criteria_InList(Params_Get_Outlet_By_Criteria_InList i_Params_Get_Outlet_By_Criteria_InList)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Outlet_By_Criteria_InList_SP oParams_Get_Outlet_By_Criteria_InList_SP = new Params_Get_Outlet_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Outlet_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Outlet_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Outlet_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_By_Criteria_InList.START_ROW == null) { i_Params_Get_Outlet_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Outlet_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Outlet_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Outlet_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Outlet_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Outlet_By_Criteria_InList.OWNER_ID;
oParams_Get_Outlet_By_Criteria_InList_SP.NAME = i_Params_Get_Outlet_By_Criteria_InList.NAME;
oParams_Get_Outlet_By_Criteria_InList_SP.CURRENT_VALUE = i_Params_Get_Outlet_By_Criteria_InList.CURRENT_VALUE;
if ( i_Params_Get_Outlet_By_Criteria_InList.OUTLET_TYPE_ID_LIST == null)
{
i_Params_Get_Outlet_By_Criteria_InList.OUTLET_TYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Outlet_By_Criteria_InList_SP.OUTLET_TYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Outlet_By_Criteria_InList.OUTLET_TYPE_ID_LIST);
if ( i_Params_Get_Outlet_By_Criteria_InList.HARDWARE_LINK_ID_LIST == null)
{
i_Params_Get_Outlet_By_Criteria_InList.HARDWARE_LINK_ID_LIST = new List<long?>();
}
oParams_Get_Outlet_By_Criteria_InList_SP.HARDWARE_LINK_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Outlet_By_Criteria_InList.HARDWARE_LINK_ID_LIST);
if ( i_Params_Get_Outlet_By_Criteria_InList.ROOM_ID_LIST == null)
{
i_Params_Get_Outlet_By_Criteria_InList.ROOM_ID_LIST = new List<Int32?>();
}
oParams_Get_Outlet_By_Criteria_InList_SP.ROOM_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Outlet_By_Criteria_InList.ROOM_ID_LIST);
oParams_Get_Outlet_By_Criteria_InList_SP.START_ROW = i_Params_Get_Outlet_By_Criteria_InList.START_ROW;
oParams_Get_Outlet_By_Criteria_InList_SP.END_ROW = i_Params_Get_Outlet_By_Criteria_InList.END_ROW;
oParams_Get_Outlet_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Outlet_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_Criteria_InList(i_Params_Get_Outlet_By_Criteria_InList.NAME,i_Params_Get_Outlet_By_Criteria_InList.CURRENT_VALUE,i_Params_Get_Outlet_By_Criteria_InList.OUTLET_TYPE_ID_LIST,i_Params_Get_Outlet_By_Criteria_InList.HARDWARE_LINK_ID_LIST,i_Params_Get_Outlet_By_Criteria_InList.ROOM_ID_LIST,i_Params_Get_Outlet_By_Criteria_InList.OWNER_ID,i_Params_Get_Outlet_By_Criteria_InList.START_ROW,i_Params_Get_Outlet_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oList.Add(oOutlet);
}
}
i_Params_Get_Outlet_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Outlet_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Outlet_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_Criteria_InList");}
return oList;
}
public List<Outlet> Get_Outlet_By_Where_InList(Params_Get_Outlet_By_Where_InList i_Params_Get_Outlet_By_Where_InList)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Outlet_By_Where_InList_SP oParams_Get_Outlet_By_Where_InList_SP = new Params_Get_Outlet_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Outlet_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Outlet_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Outlet_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_By_Where_InList.START_ROW == null) { i_Params_Get_Outlet_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Outlet_By_Where_InList.END_ROW == null) || (i_Params_Get_Outlet_By_Where_InList.END_ROW == 0)) { i_Params_Get_Outlet_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Outlet_By_Where_InList_SP.OWNER_ID = i_Params_Get_Outlet_By_Where_InList.OWNER_ID;
oParams_Get_Outlet_By_Where_InList_SP.NAME = i_Params_Get_Outlet_By_Where_InList.NAME;
oParams_Get_Outlet_By_Where_InList_SP.CURRENT_VALUE = i_Params_Get_Outlet_By_Where_InList.CURRENT_VALUE;
if ( i_Params_Get_Outlet_By_Where_InList.OUTLET_TYPE_ID_LIST == null)
{
i_Params_Get_Outlet_By_Where_InList.OUTLET_TYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Outlet_By_Where_InList_SP.OUTLET_TYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Outlet_By_Where_InList.OUTLET_TYPE_ID_LIST);
if ( i_Params_Get_Outlet_By_Where_InList.HARDWARE_LINK_ID_LIST == null)
{
i_Params_Get_Outlet_By_Where_InList.HARDWARE_LINK_ID_LIST = new List<long?>();
}
oParams_Get_Outlet_By_Where_InList_SP.HARDWARE_LINK_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Outlet_By_Where_InList.HARDWARE_LINK_ID_LIST);
if ( i_Params_Get_Outlet_By_Where_InList.ROOM_ID_LIST == null)
{
i_Params_Get_Outlet_By_Where_InList.ROOM_ID_LIST = new List<Int32?>();
}
oParams_Get_Outlet_By_Where_InList_SP.ROOM_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Outlet_By_Where_InList.ROOM_ID_LIST);
oParams_Get_Outlet_By_Where_InList_SP.START_ROW = i_Params_Get_Outlet_By_Where_InList.START_ROW;
oParams_Get_Outlet_By_Where_InList_SP.END_ROW = i_Params_Get_Outlet_By_Where_InList.END_ROW;
oParams_Get_Outlet_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Outlet_By_Where_InList.TOTAL_COUNT;
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_Where_InList(i_Params_Get_Outlet_By_Where_InList.NAME,i_Params_Get_Outlet_By_Where_InList.CURRENT_VALUE,i_Params_Get_Outlet_By_Where_InList.OUTLET_TYPE_ID_LIST,i_Params_Get_Outlet_By_Where_InList.HARDWARE_LINK_ID_LIST,i_Params_Get_Outlet_By_Where_InList.ROOM_ID_LIST,i_Params_Get_Outlet_By_Where_InList.OWNER_ID,i_Params_Get_Outlet_By_Where_InList.START_ROW,i_Params_Get_Outlet_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oList.Add(oOutlet);
}
}
i_Params_Get_Outlet_By_Where_InList.TOTAL_COUNT = oParams_Get_Outlet_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Outlet_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_Where_InList");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Criteria_InList(Params_Get_Outlet_ui_By_Criteria_InList i_Params_Get_Outlet_ui_By_Criteria_InList)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Outlet_ui_By_Criteria_InList_SP oParams_Get_Outlet_ui_By_Criteria_InList_SP = new Params_Get_Outlet_ui_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Outlet_ui_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Outlet_ui_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Outlet_ui_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_ui_By_Criteria_InList.START_ROW == null) { i_Params_Get_Outlet_ui_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Outlet_ui_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Outlet_ui_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Outlet_ui_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Outlet_ui_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Outlet_ui_By_Criteria_InList.OWNER_ID;
oParams_Get_Outlet_ui_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Outlet_ui_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Outlet_ui_By_Criteria_InList.OUTLET_ID_LIST == null)
{
i_Params_Get_Outlet_ui_By_Criteria_InList.OUTLET_ID_LIST = new List<long?>();
}
oParams_Get_Outlet_ui_By_Criteria_InList_SP.OUTLET_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Outlet_ui_By_Criteria_InList.OUTLET_ID_LIST);
if ( i_Params_Get_Outlet_ui_By_Criteria_InList.UI_ID_LIST == null)
{
i_Params_Get_Outlet_ui_By_Criteria_InList.UI_ID_LIST = new List<long?>();
}
oParams_Get_Outlet_ui_By_Criteria_InList_SP.UI_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Outlet_ui_By_Criteria_InList.UI_ID_LIST);
oParams_Get_Outlet_ui_By_Criteria_InList_SP.START_ROW = i_Params_Get_Outlet_ui_By_Criteria_InList.START_ROW;
oParams_Get_Outlet_ui_By_Criteria_InList_SP.END_ROW = i_Params_Get_Outlet_ui_By_Criteria_InList.END_ROW;
oParams_Get_Outlet_ui_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Outlet_ui_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_Criteria_InList(i_Params_Get_Outlet_ui_By_Criteria_InList.DESCRIPTION,i_Params_Get_Outlet_ui_By_Criteria_InList.OUTLET_ID_LIST,i_Params_Get_Outlet_ui_By_Criteria_InList.UI_ID_LIST,i_Params_Get_Outlet_ui_By_Criteria_InList.OWNER_ID,i_Params_Get_Outlet_ui_By_Criteria_InList.START_ROW,i_Params_Get_Outlet_ui_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oList.Add(oOutlet_ui);
}
}
i_Params_Get_Outlet_ui_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Outlet_ui_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Outlet_ui_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_Criteria_InList");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Where_InList(Params_Get_Outlet_ui_By_Where_InList i_Params_Get_Outlet_ui_By_Where_InList)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Outlet_ui_By_Where_InList_SP oParams_Get_Outlet_ui_By_Where_InList_SP = new Params_Get_Outlet_ui_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Outlet_ui_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Outlet_ui_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Outlet_ui_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_ui_By_Where_InList.START_ROW == null) { i_Params_Get_Outlet_ui_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Outlet_ui_By_Where_InList.END_ROW == null) || (i_Params_Get_Outlet_ui_By_Where_InList.END_ROW == 0)) { i_Params_Get_Outlet_ui_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Outlet_ui_By_Where_InList_SP.OWNER_ID = i_Params_Get_Outlet_ui_By_Where_InList.OWNER_ID;
oParams_Get_Outlet_ui_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Outlet_ui_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Outlet_ui_By_Where_InList.OUTLET_ID_LIST == null)
{
i_Params_Get_Outlet_ui_By_Where_InList.OUTLET_ID_LIST = new List<long?>();
}
oParams_Get_Outlet_ui_By_Where_InList_SP.OUTLET_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Outlet_ui_By_Where_InList.OUTLET_ID_LIST);
if ( i_Params_Get_Outlet_ui_By_Where_InList.UI_ID_LIST == null)
{
i_Params_Get_Outlet_ui_By_Where_InList.UI_ID_LIST = new List<long?>();
}
oParams_Get_Outlet_ui_By_Where_InList_SP.UI_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Outlet_ui_By_Where_InList.UI_ID_LIST);
oParams_Get_Outlet_ui_By_Where_InList_SP.START_ROW = i_Params_Get_Outlet_ui_By_Where_InList.START_ROW;
oParams_Get_Outlet_ui_By_Where_InList_SP.END_ROW = i_Params_Get_Outlet_ui_By_Where_InList.END_ROW;
oParams_Get_Outlet_ui_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Outlet_ui_By_Where_InList.TOTAL_COUNT;
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_Where_InList(i_Params_Get_Outlet_ui_By_Where_InList.DESCRIPTION,i_Params_Get_Outlet_ui_By_Where_InList.OUTLET_ID_LIST,i_Params_Get_Outlet_ui_By_Where_InList.UI_ID_LIST,i_Params_Get_Outlet_ui_By_Where_InList.OWNER_ID,i_Params_Get_Outlet_ui_By_Where_InList.START_ROW,i_Params_Get_Outlet_ui_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oList.Add(oOutlet_ui);
}
}
i_Params_Get_Outlet_ui_By_Where_InList.TOTAL_COUNT = oParams_Get_Outlet_ui_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Outlet_ui_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_Where_InList");}
return oList;
}
public List<Room> Get_Room_By_Criteria_InList(Params_Get_Room_By_Criteria_InList i_Params_Get_Room_By_Criteria_InList)
{
List<Room> oList = new List<Room>();
Room oRoom = new Room();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Room_By_Criteria_InList_SP oParams_Get_Room_By_Criteria_InList_SP = new Params_Get_Room_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_Criteria_InList");}
#region Body Section.
if ((i_Params_Get_Room_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Room_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Room_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Room_By_Criteria_InList.START_ROW == null) { i_Params_Get_Room_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Room_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Room_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Room_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Room_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Room_By_Criteria_InList.OWNER_ID;
oParams_Get_Room_By_Criteria_InList_SP.NAME = i_Params_Get_Room_By_Criteria_InList.NAME;
if ( i_Params_Get_Room_By_Criteria_InList.FLOOR_ID_LIST == null)
{
i_Params_Get_Room_By_Criteria_InList.FLOOR_ID_LIST = new List<Int32?>();
}
oParams_Get_Room_By_Criteria_InList_SP.FLOOR_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Room_By_Criteria_InList.FLOOR_ID_LIST);
oParams_Get_Room_By_Criteria_InList_SP.START_ROW = i_Params_Get_Room_By_Criteria_InList.START_ROW;
oParams_Get_Room_By_Criteria_InList_SP.END_ROW = i_Params_Get_Room_By_Criteria_InList.END_ROW;
oParams_Get_Room_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Room_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_Criteria_InList(i_Params_Get_Room_By_Criteria_InList.NAME,i_Params_Get_Room_By_Criteria_InList.FLOOR_ID_LIST,i_Params_Get_Room_By_Criteria_InList.OWNER_ID,i_Params_Get_Room_By_Criteria_InList.START_ROW,i_Params_Get_Room_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oList.Add(oRoom);
}
}
i_Params_Get_Room_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Room_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Room_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_Criteria_InList");}
return oList;
}
public List<Room> Get_Room_By_Where_InList(Params_Get_Room_By_Where_InList i_Params_Get_Room_By_Where_InList)
{
List<Room> oList = new List<Room>();
Room oRoom = new Room();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Room_By_Where_InList_SP oParams_Get_Room_By_Where_InList_SP = new Params_Get_Room_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_Where_InList");}
#region Body Section.
if ((i_Params_Get_Room_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Room_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Room_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Room_By_Where_InList.START_ROW == null) { i_Params_Get_Room_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Room_By_Where_InList.END_ROW == null) || (i_Params_Get_Room_By_Where_InList.END_ROW == 0)) { i_Params_Get_Room_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Room_By_Where_InList_SP.OWNER_ID = i_Params_Get_Room_By_Where_InList.OWNER_ID;
oParams_Get_Room_By_Where_InList_SP.NAME = i_Params_Get_Room_By_Where_InList.NAME;
if ( i_Params_Get_Room_By_Where_InList.FLOOR_ID_LIST == null)
{
i_Params_Get_Room_By_Where_InList.FLOOR_ID_LIST = new List<Int32?>();
}
oParams_Get_Room_By_Where_InList_SP.FLOOR_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Room_By_Where_InList.FLOOR_ID_LIST);
oParams_Get_Room_By_Where_InList_SP.START_ROW = i_Params_Get_Room_By_Where_InList.START_ROW;
oParams_Get_Room_By_Where_InList_SP.END_ROW = i_Params_Get_Room_By_Where_InList.END_ROW;
oParams_Get_Room_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Room_By_Where_InList.TOTAL_COUNT;
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_Where_InList(i_Params_Get_Room_By_Where_InList.NAME,i_Params_Get_Room_By_Where_InList.FLOOR_ID_LIST,i_Params_Get_Room_By_Where_InList.OWNER_ID,i_Params_Get_Room_By_Where_InList.START_ROW,i_Params_Get_Room_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oList.Add(oRoom);
}
}
i_Params_Get_Room_By_Where_InList.TOTAL_COUNT = oParams_Get_Room_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Room_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_Where_InList");}
return oList;
}
public void Delete_Floor(Params_Delete_Floor i_Params_Delete_Floor)
{
Params_Get_Floor_By_FLOOR_ID oParams_Get_Floor_By_FLOOR_ID = new Params_Get_Floor_By_FLOOR_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Floor");}
#region Body Section.
try
{
oParams_Get_Floor_By_FLOOR_ID.FLOOR_ID = i_Params_Delete_Floor.FLOOR_ID;
_Floor = Get_Floor_By_FLOOR_ID_Adv(oParams_Get_Floor_By_FLOOR_ID);
if (_Floor != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Floor_Execution)
{
_Stop_Delete_Floor_Execution = false;
return;
}
_AppContext.Delete_Floor(i_Params_Delete_Floor.FLOOR_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Floor");}
}
public void Delete_Hardware_link(Params_Delete_Hardware_link i_Params_Delete_Hardware_link)
{
Params_Get_Hardware_link_By_HARDWARE_LINK_ID oParams_Get_Hardware_link_By_HARDWARE_LINK_ID = new Params_Get_Hardware_link_By_HARDWARE_LINK_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Hardware_link");}
#region Body Section.
try
{
oParams_Get_Hardware_link_By_HARDWARE_LINK_ID.HARDWARE_LINK_ID = i_Params_Delete_Hardware_link.HARDWARE_LINK_ID;
_Hardware_link = Get_Hardware_link_By_HARDWARE_LINK_ID_Adv(oParams_Get_Hardware_link_By_HARDWARE_LINK_ID);
if (_Hardware_link != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Hardware_link_Execution)
{
_Stop_Delete_Hardware_link_Execution = false;
return;
}
_AppContext.Delete_Hardware_link(i_Params_Delete_Hardware_link.HARDWARE_LINK_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Hardware_link");}
}
public void Delete_Outlet(Params_Delete_Outlet i_Params_Delete_Outlet)
{
Params_Get_Outlet_By_OUTLET_ID oParams_Get_Outlet_By_OUTLET_ID = new Params_Get_Outlet_By_OUTLET_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Outlet");}
#region Body Section.
try
{
oParams_Get_Outlet_By_OUTLET_ID.OUTLET_ID = i_Params_Delete_Outlet.OUTLET_ID;
_Outlet = Get_Outlet_By_OUTLET_ID_Adv(oParams_Get_Outlet_By_OUTLET_ID);
if (_Outlet != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Outlet_Execution)
{
_Stop_Delete_Outlet_Execution = false;
return;
}
_AppContext.Delete_Outlet(i_Params_Delete_Outlet.OUTLET_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Outlet");}
}
public void Delete_Outlet_type(Params_Delete_Outlet_type i_Params_Delete_Outlet_type)
{
Params_Get_Outlet_type_By_OUTLET_TYPE_ID oParams_Get_Outlet_type_By_OUTLET_TYPE_ID = new Params_Get_Outlet_type_By_OUTLET_TYPE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Outlet_type");}
#region Body Section.
try
{
oParams_Get_Outlet_type_By_OUTLET_TYPE_ID.OUTLET_TYPE_ID = i_Params_Delete_Outlet_type.OUTLET_TYPE_ID;
_Outlet_type = Get_Outlet_type_By_OUTLET_TYPE_ID_Adv(oParams_Get_Outlet_type_By_OUTLET_TYPE_ID);
if (_Outlet_type != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Outlet_type_Execution)
{
_Stop_Delete_Outlet_type_Execution = false;
return;
}
_AppContext.Delete_Outlet_type(i_Params_Delete_Outlet_type.OUTLET_TYPE_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Outlet_type");}
}
public void Delete_Outlet_ui(Params_Delete_Outlet_ui i_Params_Delete_Outlet_ui)
{
Params_Get_Outlet_ui_By_OUTLET_UI_ID oParams_Get_Outlet_ui_By_OUTLET_UI_ID = new Params_Get_Outlet_ui_By_OUTLET_UI_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Outlet_ui");}
#region Body Section.
try
{
oParams_Get_Outlet_ui_By_OUTLET_UI_ID.OUTLET_UI_ID = i_Params_Delete_Outlet_ui.OUTLET_UI_ID;
_Outlet_ui = Get_Outlet_ui_By_OUTLET_UI_ID_Adv(oParams_Get_Outlet_ui_By_OUTLET_UI_ID);
if (_Outlet_ui != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Outlet_ui_Execution)
{
_Stop_Delete_Outlet_ui_Execution = false;
return;
}
_AppContext.Delete_Outlet_ui(i_Params_Delete_Outlet_ui.OUTLET_UI_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Outlet_ui");}
}
public void Delete_Owner(Params_Delete_Owner i_Params_Delete_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Owner");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Owner_Execution)
{
_Stop_Delete_Owner_Execution = false;
return;
}
_AppContext.Delete_Owner(i_Params_Delete_Owner.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Owner");}
}
public void Delete_Plc(Params_Delete_Plc i_Params_Delete_Plc)
{
Params_Get_Plc_By_PLC_ID oParams_Get_Plc_By_PLC_ID = new Params_Get_Plc_By_PLC_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Plc");}
#region Body Section.
try
{
oParams_Get_Plc_By_PLC_ID.PLC_ID = i_Params_Delete_Plc.PLC_ID;
_Plc = Get_Plc_By_PLC_ID_Adv(oParams_Get_Plc_By_PLC_ID);
if (_Plc != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Plc_Execution)
{
_Stop_Delete_Plc_Execution = false;
return;
}
_AppContext.Delete_Plc(i_Params_Delete_Plc.PLC_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Plc");}
}
public void Delete_Room(Params_Delete_Room i_Params_Delete_Room)
{
Params_Get_Room_By_ROOM_ID oParams_Get_Room_By_ROOM_ID = new Params_Get_Room_By_ROOM_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Room");}
#region Body Section.
try
{
oParams_Get_Room_By_ROOM_ID.ROOM_ID = i_Params_Delete_Room.ROOM_ID;
_Room = Get_Room_By_ROOM_ID_Adv(oParams_Get_Room_By_ROOM_ID);
if (_Room != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Room_Execution)
{
_Stop_Delete_Room_Execution = false;
return;
}
_AppContext.Delete_Room(i_Params_Delete_Room.ROOM_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Room");}
}
public void Delete_Ui(Params_Delete_Ui i_Params_Delete_Ui)
{
Params_Get_Ui_By_UI_ID oParams_Get_Ui_By_UI_ID = new Params_Get_Ui_By_UI_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Ui");}
#region Body Section.
try
{
oParams_Get_Ui_By_UI_ID.UI_ID = i_Params_Delete_Ui.UI_ID;
_Ui = Get_Ui_By_UI_ID_Adv(oParams_Get_Ui_By_UI_ID);
if (_Ui != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Ui_Execution)
{
_Stop_Delete_Ui_Execution = false;
return;
}
_AppContext.Delete_Ui(i_Params_Delete_Ui.UI_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Ui");}
}
public void Delete_Uploaded_file(Params_Delete_Uploaded_file i_Params_Delete_Uploaded_file)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Uploaded_file
if (OnPreEvent_Delete_Uploaded_file != null)
{
OnPreEvent_Delete_Uploaded_file(i_Params_Delete_Uploaded_file);
}
#endregion
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file(i_Params_Delete_Uploaded_file.UPLOADED_FILE_ID);
#region PostEvent_Delete_Uploaded_file
if (OnPostEvent_Delete_Uploaded_file != null)
{
OnPostEvent_Delete_Uploaded_file(i_Params_Delete_Uploaded_file);
}
#endregion
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file");}
}
public void Delete_User(Params_Delete_User i_Params_Delete_User)
{
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User");}
#region Body Section.
try
{
oParams_Get_User_By_USER_ID.USER_ID = i_Params_Delete_User.USER_ID;
_User = Get_User_By_USER_ID_Adv(oParams_Get_User_By_USER_ID);
if (_User != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User(i_Params_Delete_User.USER_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User");}
}
public void Delete_Floor_By_OWNER_ID(Params_Delete_Floor_By_OWNER_ID i_Params_Delete_Floor_By_OWNER_ID)
{
Params_Get_Floor_By_OWNER_ID oParams_Get_Floor_By_OWNER_ID = new Params_Get_Floor_By_OWNER_ID();
List<Floor> _List_Floor = new List<Floor>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Floor_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Floor_Execution)
{
_Stop_Delete_Floor_Execution = false;
return;
}
_AppContext.Delete_Floor_By_OWNER_ID(i_Params_Delete_Floor_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Floor_By_OWNER_ID");}
}
public void Delete_Hardware_link_By_OWNER_ID(Params_Delete_Hardware_link_By_OWNER_ID i_Params_Delete_Hardware_link_By_OWNER_ID)
{
Params_Get_Hardware_link_By_OWNER_ID oParams_Get_Hardware_link_By_OWNER_ID = new Params_Get_Hardware_link_By_OWNER_ID();
List<Hardware_link> _List_Hardware_link = new List<Hardware_link>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Hardware_link_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Hardware_link_Execution)
{
_Stop_Delete_Hardware_link_Execution = false;
return;
}
_AppContext.Delete_Hardware_link_By_OWNER_ID(i_Params_Delete_Hardware_link_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Hardware_link_By_OWNER_ID");}
}
public void Delete_Hardware_link_By_PLC_ID(Params_Delete_Hardware_link_By_PLC_ID i_Params_Delete_Hardware_link_By_PLC_ID)
{
Params_Get_Hardware_link_By_PLC_ID oParams_Get_Hardware_link_By_PLC_ID = new Params_Get_Hardware_link_By_PLC_ID();
List<Hardware_link> _List_Hardware_link = new List<Hardware_link>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Hardware_link_By_PLC_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Hardware_link_Execution)
{
_Stop_Delete_Hardware_link_Execution = false;
return;
}
_AppContext.Delete_Hardware_link_By_PLC_ID(i_Params_Delete_Hardware_link_By_PLC_ID.PLC_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Hardware_link_By_PLC_ID");}
}
public void Delete_Outlet_By_OWNER_ID(Params_Delete_Outlet_By_OWNER_ID i_Params_Delete_Outlet_By_OWNER_ID)
{
Params_Get_Outlet_By_OWNER_ID oParams_Get_Outlet_By_OWNER_ID = new Params_Get_Outlet_By_OWNER_ID();
List<Outlet> _List_Outlet = new List<Outlet>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Outlet_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Outlet_Execution)
{
_Stop_Delete_Outlet_Execution = false;
return;
}
_AppContext.Delete_Outlet_By_OWNER_ID(i_Params_Delete_Outlet_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Outlet_By_OWNER_ID");}
}
public void Delete_Outlet_By_ROOM_ID(Params_Delete_Outlet_By_ROOM_ID i_Params_Delete_Outlet_By_ROOM_ID)
{
Params_Get_Outlet_By_ROOM_ID oParams_Get_Outlet_By_ROOM_ID = new Params_Get_Outlet_By_ROOM_ID();
List<Outlet> _List_Outlet = new List<Outlet>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Outlet_By_ROOM_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Outlet_Execution)
{
_Stop_Delete_Outlet_Execution = false;
return;
}
_AppContext.Delete_Outlet_By_ROOM_ID(i_Params_Delete_Outlet_By_ROOM_ID.ROOM_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Outlet_By_ROOM_ID");}
}
public void Delete_Outlet_By_OUTLET_TYPE_ID(Params_Delete_Outlet_By_OUTLET_TYPE_ID i_Params_Delete_Outlet_By_OUTLET_TYPE_ID)
{
Params_Get_Outlet_By_OUTLET_TYPE_ID oParams_Get_Outlet_By_OUTLET_TYPE_ID = new Params_Get_Outlet_By_OUTLET_TYPE_ID();
List<Outlet> _List_Outlet = new List<Outlet>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Outlet_By_OUTLET_TYPE_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Outlet_Execution)
{
_Stop_Delete_Outlet_Execution = false;
return;
}
_AppContext.Delete_Outlet_By_OUTLET_TYPE_ID(i_Params_Delete_Outlet_By_OUTLET_TYPE_ID.OUTLET_TYPE_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Outlet_By_OUTLET_TYPE_ID");}
}
public void Delete_Outlet_By_HARDWARE_LINK_ID(Params_Delete_Outlet_By_HARDWARE_LINK_ID i_Params_Delete_Outlet_By_HARDWARE_LINK_ID)
{
Params_Get_Outlet_By_HARDWARE_LINK_ID oParams_Get_Outlet_By_HARDWARE_LINK_ID = new Params_Get_Outlet_By_HARDWARE_LINK_ID();
List<Outlet> _List_Outlet = new List<Outlet>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Outlet_By_HARDWARE_LINK_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Outlet_Execution)
{
_Stop_Delete_Outlet_Execution = false;
return;
}
_AppContext.Delete_Outlet_By_HARDWARE_LINK_ID(i_Params_Delete_Outlet_By_HARDWARE_LINK_ID.HARDWARE_LINK_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Outlet_By_HARDWARE_LINK_ID");}
}
public void Delete_Outlet_type_By_OWNER_ID(Params_Delete_Outlet_type_By_OWNER_ID i_Params_Delete_Outlet_type_By_OWNER_ID)
{
Params_Get_Outlet_type_By_OWNER_ID oParams_Get_Outlet_type_By_OWNER_ID = new Params_Get_Outlet_type_By_OWNER_ID();
List<Outlet_type> _List_Outlet_type = new List<Outlet_type>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Outlet_type_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Outlet_type_Execution)
{
_Stop_Delete_Outlet_type_Execution = false;
return;
}
_AppContext.Delete_Outlet_type_By_OWNER_ID(i_Params_Delete_Outlet_type_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Outlet_type_By_OWNER_ID");}
}
public void Delete_Outlet_ui_By_OWNER_ID(Params_Delete_Outlet_ui_By_OWNER_ID i_Params_Delete_Outlet_ui_By_OWNER_ID)
{
Params_Get_Outlet_ui_By_OWNER_ID oParams_Get_Outlet_ui_By_OWNER_ID = new Params_Get_Outlet_ui_By_OWNER_ID();
List<Outlet_ui> _List_Outlet_ui = new List<Outlet_ui>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Outlet_ui_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Outlet_ui_Execution)
{
_Stop_Delete_Outlet_ui_Execution = false;
return;
}
_AppContext.Delete_Outlet_ui_By_OWNER_ID(i_Params_Delete_Outlet_ui_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Outlet_ui_By_OWNER_ID");}
}
public void Delete_Outlet_ui_By_OUTLET_ID(Params_Delete_Outlet_ui_By_OUTLET_ID i_Params_Delete_Outlet_ui_By_OUTLET_ID)
{
Params_Get_Outlet_ui_By_OUTLET_ID oParams_Get_Outlet_ui_By_OUTLET_ID = new Params_Get_Outlet_ui_By_OUTLET_ID();
List<Outlet_ui> _List_Outlet_ui = new List<Outlet_ui>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Outlet_ui_By_OUTLET_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Outlet_ui_Execution)
{
_Stop_Delete_Outlet_ui_Execution = false;
return;
}
_AppContext.Delete_Outlet_ui_By_OUTLET_ID(i_Params_Delete_Outlet_ui_By_OUTLET_ID.OUTLET_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Outlet_ui_By_OUTLET_ID");}
}
public void Delete_Outlet_ui_By_UI_ID(Params_Delete_Outlet_ui_By_UI_ID i_Params_Delete_Outlet_ui_By_UI_ID)
{
Params_Get_Outlet_ui_By_UI_ID oParams_Get_Outlet_ui_By_UI_ID = new Params_Get_Outlet_ui_By_UI_ID();
List<Outlet_ui> _List_Outlet_ui = new List<Outlet_ui>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Outlet_ui_By_UI_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Outlet_ui_Execution)
{
_Stop_Delete_Outlet_ui_Execution = false;
return;
}
_AppContext.Delete_Outlet_ui_By_UI_ID(i_Params_Delete_Outlet_ui_By_UI_ID.UI_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Outlet_ui_By_UI_ID");}
}
public void Delete_Outlet_ui_By_USER_ID(Params_Delete_Outlet_ui_By_USER_ID i_Params_Delete_Outlet_ui_By_USER_ID)
{
Params_Get_Outlet_ui_By_USER_ID oParams_Get_Outlet_ui_By_USER_ID = new Params_Get_Outlet_ui_By_USER_ID();
List<Outlet_ui> _List_Outlet_ui = new List<Outlet_ui>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Outlet_ui_By_USER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Outlet_ui_Execution)
{
_Stop_Delete_Outlet_ui_Execution = false;
return;
}
_AppContext.Delete_Outlet_ui_By_USER_ID(i_Params_Delete_Outlet_ui_By_USER_ID.USER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Outlet_ui_By_USER_ID");}
}
public void Delete_Plc_By_OWNER_ID(Params_Delete_Plc_By_OWNER_ID i_Params_Delete_Plc_By_OWNER_ID)
{
Params_Get_Plc_By_OWNER_ID oParams_Get_Plc_By_OWNER_ID = new Params_Get_Plc_By_OWNER_ID();
List<Plc> _List_Plc = new List<Plc>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Plc_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Plc_Execution)
{
_Stop_Delete_Plc_Execution = false;
return;
}
_AppContext.Delete_Plc_By_OWNER_ID(i_Params_Delete_Plc_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Plc_By_OWNER_ID");}
}
public void Delete_Room_By_OWNER_ID(Params_Delete_Room_By_OWNER_ID i_Params_Delete_Room_By_OWNER_ID)
{
Params_Get_Room_By_OWNER_ID oParams_Get_Room_By_OWNER_ID = new Params_Get_Room_By_OWNER_ID();
List<Room> _List_Room = new List<Room>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Room_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Room_Execution)
{
_Stop_Delete_Room_Execution = false;
return;
}
_AppContext.Delete_Room_By_OWNER_ID(i_Params_Delete_Room_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Room_By_OWNER_ID");}
}
public void Delete_Room_By_FLOOR_ID(Params_Delete_Room_By_FLOOR_ID i_Params_Delete_Room_By_FLOOR_ID)
{
Params_Get_Room_By_FLOOR_ID oParams_Get_Room_By_FLOOR_ID = new Params_Get_Room_By_FLOOR_ID();
List<Room> _List_Room = new List<Room>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Room_By_FLOOR_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Room_Execution)
{
_Stop_Delete_Room_Execution = false;
return;
}
_AppContext.Delete_Room_By_FLOOR_ID(i_Params_Delete_Room_By_FLOOR_ID.FLOOR_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Room_By_FLOOR_ID");}
}
public void Delete_Ui_By_OWNER_ID(Params_Delete_Ui_By_OWNER_ID i_Params_Delete_Ui_By_OWNER_ID)
{
Params_Get_Ui_By_OWNER_ID oParams_Get_Ui_By_OWNER_ID = new Params_Get_Ui_By_OWNER_ID();
List<Ui> _List_Ui = new List<Ui>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Ui_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Ui_Execution)
{
_Stop_Delete_Ui_Execution = false;
return;
}
_AppContext.Delete_Ui_By_OWNER_ID(i_Params_Delete_Ui_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Ui_By_OWNER_ID");}
}
public void Delete_Uploaded_file_By_OWNER_ID(Params_Delete_Uploaded_file_By_OWNER_ID i_Params_Delete_Uploaded_file_By_OWNER_ID)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_OWNER_ID(i_Params_Delete_Uploaded_file_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_OWNER_ID");}
}
public void Delete_Uploaded_file_By_REL_ENTITY(Params_Delete_Uploaded_file_By_REL_ENTITY i_Params_Delete_Uploaded_file_By_REL_ENTITY)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_REL_ENTITY");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_REL_ENTITY(i_Params_Delete_Uploaded_file_By_REL_ENTITY.REL_ENTITY);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_REL_ENTITY");}
}
public void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_REL_ENTITY_REL_KEY(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_ENTITY,i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY.REL_KEY);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY");}
}
public void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
if (OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD != null)
{
OnPreEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
}
#endregion
if (_Stop_Delete_Uploaded_file_Execution)
{
_Stop_Delete_Uploaded_file_Execution = false;
return;
}
_AppContext.Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_ENTITY,i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_KEY,i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD.REL_FIELD);
#region PostEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
if (OnPostEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD != null)
{
OnPostEvent_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD(i_Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD);
}
#endregion
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");}
}
public void Delete_User_By_OWNER_ID(Params_Delete_User_By_OWNER_ID i_Params_Delete_User_By_OWNER_ID)
{
Params_Get_User_By_OWNER_ID oParams_Get_User_By_OWNER_ID = new Params_Get_User_By_OWNER_ID();
List<User> _List_User = new List<User>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_OWNER_ID(i_Params_Delete_User_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_OWNER_ID");}
}
public void Delete_User_By_USERNAME(Params_Delete_User_By_USERNAME i_Params_Delete_User_By_USERNAME)
{
Params_Get_User_By_USERNAME oParams_Get_User_By_USERNAME = new Params_Get_User_By_USERNAME();
List<User> _List_User = new List<User>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_USERNAME");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_USERNAME(i_Params_Delete_User_By_USERNAME.USERNAME);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_USERNAME");}
}
public void Edit_Floor(Floor i_Floor) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Floor.FLOOR_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Floor");}
#region Body Section.
if ((i_Floor.FLOOR_ID == null) || (i_Floor.FLOOR_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Floor"); }
i_Floor.ENTRY_USER_ID = this.UserID;
i_Floor.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Floor.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Floor_Execution)
{
_Stop_Edit_Floor_Execution = false;
return;
}
i_Floor.FLOOR_ID = _AppContext.Edit_Floor
(
i_Floor.FLOOR_ID
,i_Floor.NAME
,i_Floor.ENTRY_USER_ID
,i_Floor.ENTRY_DATE
,i_Floor.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Floor");}
}
public void Edit_Hardware_link(Hardware_link i_Hardware_link) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Hardware_link.HARDWARE_LINK_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Hardware_link");}
#region Body Section.
if ((i_Hardware_link.HARDWARE_LINK_ID == null) || (i_Hardware_link.HARDWARE_LINK_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Hardware_link"); }
i_Hardware_link.ENTRY_USER_ID = this.UserID;
i_Hardware_link.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Hardware_link.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Hardware_link_Execution)
{
_Stop_Edit_Hardware_link_Execution = false;
return;
}
i_Hardware_link.HARDWARE_LINK_ID = _AppContext.Edit_Hardware_link
(
i_Hardware_link.HARDWARE_LINK_ID
,i_Hardware_link.PLC_ID
,i_Hardware_link.PLC_ADDRESS
,i_Hardware_link.ENTRY_USER_ID
,i_Hardware_link.ENTRY_DATE
,i_Hardware_link.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Hardware_link");}
}
public void Edit_Outlet(Outlet i_Outlet) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Outlet.OUTLET_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Outlet");}
#region Body Section.
if ((i_Outlet.OUTLET_ID == null) || (i_Outlet.OUTLET_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Outlet"); }
i_Outlet.ENTRY_USER_ID = this.UserID;
i_Outlet.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Outlet.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Outlet
if (OnPreEvent_Edit_Outlet != null)
{
OnPreEvent_Edit_Outlet(i_Outlet,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Outlet_Execution)
{
_Stop_Edit_Outlet_Execution = false;
return;
}
i_Outlet.OUTLET_ID = _AppContext.Edit_Outlet
(
i_Outlet.OUTLET_ID
,i_Outlet.OUTLET_TYPE_ID
,i_Outlet.HARDWARE_LINK_ID
,i_Outlet.ROOM_ID
,i_Outlet.NAME
,i_Outlet.CURRENT_VALUE
,i_Outlet.ENTRY_USER_ID
,i_Outlet.ENTRY_DATE
,i_Outlet.OWNER_ID
);
#region PostEvent_Edit_Outlet
if (OnPostEvent_Edit_Outlet != null)
{
OnPostEvent_Edit_Outlet(i_Outlet,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Outlet");}
}
public void Edit_Outlet_type(Outlet_type i_Outlet_type) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Outlet_type.OUTLET_TYPE_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Outlet_type");}
#region Body Section.
if ((i_Outlet_type.OUTLET_TYPE_ID == null) || (i_Outlet_type.OUTLET_TYPE_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Outlet_type"); }
i_Outlet_type.ENTRY_USER_ID = this.UserID;
i_Outlet_type.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Outlet_type.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Outlet_type_Execution)
{
_Stop_Edit_Outlet_type_Execution = false;
return;
}
i_Outlet_type.OUTLET_TYPE_ID = _AppContext.Edit_Outlet_type
(
i_Outlet_type.OUTLET_TYPE_ID
,i_Outlet_type.NAME
,i_Outlet_type.MIN_VALUE
,i_Outlet_type.MAX_VALUE
,i_Outlet_type.IS_DIGITAL
,i_Outlet_type.ENTRY_USER_ID
,i_Outlet_type.ENTRY_DATE
,i_Outlet_type.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Outlet_type");}
}
public void Edit_Outlet_ui(Outlet_ui i_Outlet_ui) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Outlet_ui.OUTLET_UI_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Outlet_ui");}
#region Body Section.
if ((i_Outlet_ui.OUTLET_UI_ID == null) || (i_Outlet_ui.OUTLET_UI_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Outlet_ui"); }
i_Outlet_ui.ENTRY_USER_ID = this.UserID;
i_Outlet_ui.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Outlet_ui.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Outlet_ui_Execution)
{
_Stop_Edit_Outlet_ui_Execution = false;
return;
}
i_Outlet_ui.OUTLET_UI_ID = _AppContext.Edit_Outlet_ui
(
i_Outlet_ui.OUTLET_UI_ID
,i_Outlet_ui.OUTLET_ID
,i_Outlet_ui.UI_ID
,i_Outlet_ui.USER_ID
,i_Outlet_ui.ENTRY_USER_ID
,i_Outlet_ui.ENTRY_DATE
,i_Outlet_ui.OWNER_ID
,i_Outlet_ui.DESCRIPTION
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Outlet_ui");}
}
public void Edit_Owner(Owner i_Owner) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Owner.OWNER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner");}
#region Body Section.
if ((i_Owner.OWNER_ID == null) || (i_Owner.OWNER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Owner"); }
i_Owner.ENTRY_DATE    = oTools.GetDateTimeString(DateTime.Now);
i_Owner.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Owner_Execution)
{
_Stop_Edit_Owner_Execution = false;
return;
}
i_Owner.OWNER_ID = _AppContext.Edit_Owner
(
i_Owner.OWNER_ID
,i_Owner.CODE
,i_Owner.MAINTENANCE_DUE_DATE
,i_Owner.DESCRIPTION
,i_Owner.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner");}
}
public void Edit_Plc(Plc i_Plc) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Plc.PLC_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Plc");}
#region Body Section.
if ((i_Plc.PLC_ID == null) || (i_Plc.PLC_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Plc"); }
i_Plc.ENTRY_USER_ID = this.UserID;
i_Plc.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Plc.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Plc_Execution)
{
_Stop_Edit_Plc_Execution = false;
return;
}
i_Plc.PLC_ID = _AppContext.Edit_Plc
(
i_Plc.PLC_ID
,i_Plc.LOCATION
,i_Plc.PORT
,i_Plc.TYPE
,i_Plc.CURRENT_INPUTS
,i_Plc.MAX_INPUTS
,i_Plc.CURRENT_OUTPUTS
,i_Plc.MAX_OUTPUTS
,i_Plc.ENTRY_USER_ID
,i_Plc.ENTRY_DATE
,i_Plc.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Plc");}
}
public void Edit_Room(Room i_Room) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Room.ROOM_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Room");}
#region Body Section.
if ((i_Room.ROOM_ID == null) || (i_Room.ROOM_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Room"); }
i_Room.ENTRY_USER_ID = this.UserID;
i_Room.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Room.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Room_Execution)
{
_Stop_Edit_Room_Execution = false;
return;
}
i_Room.ROOM_ID = _AppContext.Edit_Room
(
i_Room.ROOM_ID
,i_Room.FLOOR_ID
,i_Room.NAME
,i_Room.ENTRY_USER_ID
,i_Room.ENTRY_DATE
,i_Room.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Room");}
}
public void Edit_Ui(Ui i_Ui) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Ui.UI_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Ui");}
#region Body Section.
if ((i_Ui.UI_ID == null) || (i_Ui.UI_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Ui"); }
i_Ui.ENTRY_USER_ID = this.UserID;
i_Ui.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Ui.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Ui_Execution)
{
_Stop_Edit_Ui_Execution = false;
return;
}
i_Ui.UI_ID = _AppContext.Edit_Ui
(
i_Ui.UI_ID
,i_Ui.COLOR
,i_Ui.OTHER
,i_Ui.ENTRY_USER_ID
,i_Ui.ENTRY_DATE
,i_Ui.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Ui");}
}
public void Edit_Uploaded_file(Uploaded_file i_Uploaded_file) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Uploaded_file.UPLOADED_FILE_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Uploaded_file");}
#region Body Section.
if ((i_Uploaded_file.UPLOADED_FILE_ID == null) || (i_Uploaded_file.UPLOADED_FILE_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Uploaded_file"); }
i_Uploaded_file.ENTRY_USER_ID = this.UserID;
i_Uploaded_file.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Uploaded_file.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Uploaded_file
if (OnPreEvent_Edit_Uploaded_file != null)
{
OnPreEvent_Edit_Uploaded_file(i_Uploaded_file,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Uploaded_file_Execution)
{
_Stop_Edit_Uploaded_file_Execution = false;
return;
}
i_Uploaded_file.UPLOADED_FILE_ID = _AppContext.Edit_Uploaded_file
(
i_Uploaded_file.UPLOADED_FILE_ID
,i_Uploaded_file.REL_ENTITY
,i_Uploaded_file.REL_KEY
,i_Uploaded_file.REL_FIELD
,i_Uploaded_file.SIZE
,i_Uploaded_file.EXTENSION
,i_Uploaded_file.URL
,i_Uploaded_file.STAMP
,i_Uploaded_file.ENTRY_USER_ID
,i_Uploaded_file.ENTRY_DATE
,i_Uploaded_file.OWNER_ID
);
#region PostEvent_Edit_Uploaded_file
if (OnPostEvent_Edit_Uploaded_file != null)
{
OnPostEvent_Edit_Uploaded_file(i_Uploaded_file,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Uploaded_file");}
}
public void Edit_User(User i_User) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_User.USER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User");}
#region Body Section.
if ((i_User.USER_ID == null) || (i_User.USER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_User"); }
i_User.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_User.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_User
if (OnPreEvent_Edit_User != null)
{
OnPreEvent_Edit_User(i_User,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_User_Execution)
{
_Stop_Edit_User_Execution = false;
return;
}
i_User.USER_ID = _AppContext.Edit_User
(
i_User.USER_ID
,i_User.OWNER_ID
,i_User.USERNAME
,i_User.PASSWORD
,i_User.USER_TYPE_CODE
,i_User.IS_ACTIVE
,i_User.ENTRY_DATE
);
#region PostEvent_Edit_User
if (OnPostEvent_Edit_User != null)
{
OnPostEvent_Edit_User(i_User,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User");}
}
public void Edit_Floor_List(List<Floor> i_List_Floor)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Floor_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Floor != null)
{
foreach (var oRow in i_List_Floor)
{
Edit_Floor(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Floor_List");}
}
public void Edit_Floor_List(Params_Edit_Floor_List i_Params_Edit_Floor_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Floor_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Floor_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Floor_List.My_List_To_Delete)
{
Delete_Floor(new Params_Delete_Floor() { FLOOR_ID = oRow.FLOOR_ID });
}
}
if (i_Params_Edit_Floor_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Floor_List.My_List_To_Edit)
{
Edit_Floor(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Floor_List");}
}
public void Edit_Hardware_link_List(List<Hardware_link> i_List_Hardware_link)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Hardware_link_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Hardware_link != null)
{
foreach (var oRow in i_List_Hardware_link)
{
Edit_Hardware_link(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Hardware_link_List");}
}
public void Edit_Hardware_link_List(Params_Edit_Hardware_link_List i_Params_Edit_Hardware_link_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Hardware_link_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Hardware_link_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Hardware_link_List.My_List_To_Delete)
{
Delete_Hardware_link(new Params_Delete_Hardware_link() { HARDWARE_LINK_ID = oRow.HARDWARE_LINK_ID });
}
}
if (i_Params_Edit_Hardware_link_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Hardware_link_List.My_List_To_Edit)
{
Edit_Hardware_link(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Hardware_link_List");}
}
public void Edit_Outlet_List(List<Outlet> i_List_Outlet)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Outlet_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Outlet != null)
{
foreach (var oRow in i_List_Outlet)
{
Edit_Outlet(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Outlet_List");}
}
public void Edit_Outlet_List(Params_Edit_Outlet_List i_Params_Edit_Outlet_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Outlet_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Outlet_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Outlet_List.My_List_To_Delete)
{
Delete_Outlet(new Params_Delete_Outlet() { OUTLET_ID = oRow.OUTLET_ID });
}
}
if (i_Params_Edit_Outlet_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Outlet_List.My_List_To_Edit)
{
Edit_Outlet(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Outlet_List");}
}
public void Edit_Outlet_type_List(List<Outlet_type> i_List_Outlet_type)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Outlet_type_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Outlet_type != null)
{
foreach (var oRow in i_List_Outlet_type)
{
Edit_Outlet_type(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Outlet_type_List");}
}
public void Edit_Outlet_type_List(Params_Edit_Outlet_type_List i_Params_Edit_Outlet_type_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Outlet_type_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Outlet_type_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Outlet_type_List.My_List_To_Delete)
{
Delete_Outlet_type(new Params_Delete_Outlet_type() { OUTLET_TYPE_ID = oRow.OUTLET_TYPE_ID });
}
}
if (i_Params_Edit_Outlet_type_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Outlet_type_List.My_List_To_Edit)
{
Edit_Outlet_type(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Outlet_type_List");}
}
public void Edit_Outlet_ui_List(List<Outlet_ui> i_List_Outlet_ui)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Outlet_ui_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Outlet_ui != null)
{
foreach (var oRow in i_List_Outlet_ui)
{
Edit_Outlet_ui(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Outlet_ui_List");}
}
public void Edit_Outlet_ui_List(Params_Edit_Outlet_ui_List i_Params_Edit_Outlet_ui_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Outlet_ui_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Outlet_ui_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Outlet_ui_List.My_List_To_Delete)
{
Delete_Outlet_ui(new Params_Delete_Outlet_ui() { OUTLET_UI_ID = oRow.OUTLET_UI_ID });
}
}
if (i_Params_Edit_Outlet_ui_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Outlet_ui_List.My_List_To_Edit)
{
Edit_Outlet_ui(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Outlet_ui_List");}
}
public void Edit_Owner_List(List<Owner> i_List_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Owner != null)
{
foreach (var oRow in i_List_Owner)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Owner_List(Params_Edit_Owner_List i_Params_Edit_Owner_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Owner_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Delete)
{
Delete_Owner(new Params_Delete_Owner() { OWNER_ID = oRow.OWNER_ID });
}
}
if (i_Params_Edit_Owner_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Edit)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Plc_List(List<Plc> i_List_Plc)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Plc_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Plc != null)
{
foreach (var oRow in i_List_Plc)
{
Edit_Plc(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Plc_List");}
}
public void Edit_Plc_List(Params_Edit_Plc_List i_Params_Edit_Plc_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Plc_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Plc_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Plc_List.My_List_To_Delete)
{
Delete_Plc(new Params_Delete_Plc() { PLC_ID = oRow.PLC_ID });
}
}
if (i_Params_Edit_Plc_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Plc_List.My_List_To_Edit)
{
Edit_Plc(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Plc_List");}
}
public void Edit_Room_List(List<Room> i_List_Room)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Room_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Room != null)
{
foreach (var oRow in i_List_Room)
{
Edit_Room(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Room_List");}
}
public void Edit_Room_List(Params_Edit_Room_List i_Params_Edit_Room_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Room_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Room_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Room_List.My_List_To_Delete)
{
Delete_Room(new Params_Delete_Room() { ROOM_ID = oRow.ROOM_ID });
}
}
if (i_Params_Edit_Room_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Room_List.My_List_To_Edit)
{
Edit_Room(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Room_List");}
}
public void Edit_Ui_List(List<Ui> i_List_Ui)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Ui_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Ui != null)
{
foreach (var oRow in i_List_Ui)
{
Edit_Ui(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Ui_List");}
}
public void Edit_Ui_List(Params_Edit_Ui_List i_Params_Edit_Ui_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Ui_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Ui_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Ui_List.My_List_To_Delete)
{
Delete_Ui(new Params_Delete_Ui() { UI_ID = oRow.UI_ID });
}
}
if (i_Params_Edit_Ui_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Ui_List.My_List_To_Edit)
{
Edit_Ui(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Ui_List");}
}
public void Edit_Uploaded_file_List(List<Uploaded_file> i_List_Uploaded_file)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Uploaded_file_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Uploaded_file != null)
{
foreach (var oRow in i_List_Uploaded_file)
{
Edit_Uploaded_file(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Uploaded_file_List");}
}
public void Edit_Uploaded_file_List(Params_Edit_Uploaded_file_List i_Params_Edit_Uploaded_file_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Uploaded_file_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Uploaded_file_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Uploaded_file_List.My_List_To_Delete)
{
Delete_Uploaded_file(new Params_Delete_Uploaded_file() { UPLOADED_FILE_ID = oRow.UPLOADED_FILE_ID });
}
}
if (i_Params_Edit_Uploaded_file_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Uploaded_file_List.My_List_To_Edit)
{
Edit_Uploaded_file(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Uploaded_file_List");}
}
public void Edit_User_List(List<User> i_List_User)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_User != null)
{
foreach (var oRow in i_List_User)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
public void Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_User_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Delete)
{
Delete_User(new Params_Delete_User() { USER_ID = oRow.USER_ID });
}
}
if (i_Params_Edit_User_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Edit)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
}
}
