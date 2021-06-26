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
public Floor Get_Floor_By_FLOOR_ID_Adv(Params_Get_Floor_By_FLOOR_ID i_Params_Get_Floor_By_FLOOR_ID)
{
Floor oFloor = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Floor_By_FLOOR_ID_Adv");}
#region Body Section.
DALC.Floor oDBEntry = _AppContext.Get_Floor_By_FLOOR_ID_Adv(i_Params_Get_Floor_By_FLOOR_ID.FLOOR_ID);
oFloor = new Floor();
oTools.CopyPropValues(oDBEntry, oFloor);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Floor_By_FLOOR_ID_Adv");}
return oFloor;
}
public Hardware_link Get_Hardware_link_By_HARDWARE_LINK_ID_Adv(Params_Get_Hardware_link_By_HARDWARE_LINK_ID i_Params_Get_Hardware_link_By_HARDWARE_LINK_ID)
{
Hardware_link oHardware_link = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_HARDWARE_LINK_ID_Adv");}
#region Body Section.
DALC.Hardware_link oDBEntry = _AppContext.Get_Hardware_link_By_HARDWARE_LINK_ID_Adv(i_Params_Get_Hardware_link_By_HARDWARE_LINK_ID.HARDWARE_LINK_ID);
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oHardware_link.My_Plc = new Plc();
oTools.CopyPropValues(oDBEntry.My_Plc, oHardware_link.My_Plc);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_HARDWARE_LINK_ID_Adv");}
return oHardware_link;
}
public Outlet Get_Outlet_By_OUTLET_ID_Adv(Params_Get_Outlet_By_OUTLET_ID i_Params_Get_Outlet_By_OUTLET_ID)
{
Outlet oOutlet = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_OUTLET_ID_Adv");}
#region Body Section.
DALC.Outlet oDBEntry = _AppContext.Get_Outlet_By_OUTLET_ID_Adv(i_Params_Get_Outlet_By_OUTLET_ID.OUTLET_ID);
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oOutlet.My_Outlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry.My_Outlet_type, oOutlet.My_Outlet_type);
oOutlet.My_Hardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry.My_Hardware_link, oOutlet.My_Hardware_link);
oOutlet.My_Room = new Room();
oTools.CopyPropValues(oDBEntry.My_Room, oOutlet.My_Room);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_OUTLET_ID_Adv");}
return oOutlet;
}
public Outlet_type Get_Outlet_type_By_OUTLET_TYPE_ID_Adv(Params_Get_Outlet_type_By_OUTLET_TYPE_ID i_Params_Get_Outlet_type_By_OUTLET_TYPE_ID)
{
Outlet_type oOutlet_type = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_type_By_OUTLET_TYPE_ID_Adv");}
#region Body Section.
DALC.Outlet_type oDBEntry = _AppContext.Get_Outlet_type_By_OUTLET_TYPE_ID_Adv(i_Params_Get_Outlet_type_By_OUTLET_TYPE_ID.OUTLET_TYPE_ID);
oOutlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry, oOutlet_type);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_type_By_OUTLET_TYPE_ID_Adv");}
return oOutlet_type;
}
public Outlet_ui Get_Outlet_ui_By_OUTLET_UI_ID_Adv(Params_Get_Outlet_ui_By_OUTLET_UI_ID i_Params_Get_Outlet_ui_By_OUTLET_UI_ID)
{
Outlet_ui oOutlet_ui = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_OUTLET_UI_ID_Adv");}
#region Body Section.
DALC.Outlet_ui oDBEntry = _AppContext.Get_Outlet_ui_By_OUTLET_UI_ID_Adv(i_Params_Get_Outlet_ui_By_OUTLET_UI_ID.OUTLET_UI_ID);
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oOutlet_ui.My_Outlet = new Outlet();
oTools.CopyPropValues(oDBEntry.My_Outlet, oOutlet_ui.My_Outlet);
oOutlet_ui.My_Ui = new Ui();
oTools.CopyPropValues(oDBEntry.My_Ui, oOutlet_ui.My_Ui);
oOutlet_ui.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oOutlet_ui.My_User);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_OUTLET_UI_ID_Adv");}
return oOutlet_ui;
}
public Plc Get_Plc_By_PLC_ID_Adv(Params_Get_Plc_By_PLC_ID i_Params_Get_Plc_By_PLC_ID)
{
Plc oPlc = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Plc_By_PLC_ID_Adv");}
#region Body Section.
DALC.Plc oDBEntry = _AppContext.Get_Plc_By_PLC_ID_Adv(i_Params_Get_Plc_By_PLC_ID.PLC_ID);
oPlc = new Plc();
oTools.CopyPropValues(oDBEntry, oPlc);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Plc_By_PLC_ID_Adv");}
return oPlc;
}
public Room Get_Room_By_ROOM_ID_Adv(Params_Get_Room_By_ROOM_ID i_Params_Get_Room_By_ROOM_ID)
{
Room oRoom = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_ROOM_ID_Adv");}
#region Body Section.
DALC.Room oDBEntry = _AppContext.Get_Room_By_ROOM_ID_Adv(i_Params_Get_Room_By_ROOM_ID.ROOM_ID);
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oRoom.My_Floor = new Floor();
oTools.CopyPropValues(oDBEntry.My_Floor, oRoom.My_Floor);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_ROOM_ID_Adv");}
return oRoom;
}
public Ui Get_Ui_By_UI_ID_Adv(Params_Get_Ui_By_UI_ID i_Params_Get_Ui_By_UI_ID)
{
Ui oUi = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Ui_By_UI_ID_Adv");}
#region Body Section.
DALC.Ui oDBEntry = _AppContext.Get_Ui_By_UI_ID_Adv(i_Params_Get_Ui_By_UI_ID.UI_ID);
oUi = new Ui();
oTools.CopyPropValues(oDBEntry, oUi);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Ui_By_UI_ID_Adv");}
return oUi;
}
public User Get_User_By_USER_ID_Adv(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_Adv");}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID_Adv(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_Adv");}
return oUser;
}
public List<Floor> Get_Floor_By_FLOOR_ID_List_Adv(Params_Get_Floor_By_FLOOR_ID_List i_Params_Get_Floor_By_FLOOR_ID_List)
{
Floor oFloor = null;
List<Floor> oList = new List<Floor>();
Params_Get_Floor_By_FLOOR_ID_List_SP oParams_Get_Floor_By_FLOOR_ID_List_SP = new Params_Get_Floor_By_FLOOR_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Floor_By_FLOOR_ID_List_Adv");}
#region Body Section.
List<DALC.Floor> oList_DBEntries = _AppContext.Get_Floor_By_FLOOR_ID_List_Adv(i_Params_Get_Floor_By_FLOOR_ID_List.FLOOR_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Floor_By_FLOOR_ID_List_Adv");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_HARDWARE_LINK_ID_List_Adv(Params_Get_Hardware_link_By_HARDWARE_LINK_ID_List i_Params_Get_Hardware_link_By_HARDWARE_LINK_ID_List)
{
Hardware_link oHardware_link = null;
List<Hardware_link> oList = new List<Hardware_link>();
Params_Get_Hardware_link_By_HARDWARE_LINK_ID_List_SP oParams_Get_Hardware_link_By_HARDWARE_LINK_ID_List_SP = new Params_Get_Hardware_link_By_HARDWARE_LINK_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_HARDWARE_LINK_ID_List_Adv");}
#region Body Section.
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_HARDWARE_LINK_ID_List_Adv(i_Params_Get_Hardware_link_By_HARDWARE_LINK_ID_List.HARDWARE_LINK_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oHardware_link.My_Plc = new Plc();
oTools.CopyPropValues(oDBEntry.My_Plc, oHardware_link.My_Plc);
oList.Add(oHardware_link);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_HARDWARE_LINK_ID_List_Adv");}
return oList;
}
public List<Outlet> Get_Outlet_By_OUTLET_ID_List_Adv(Params_Get_Outlet_By_OUTLET_ID_List i_Params_Get_Outlet_By_OUTLET_ID_List)
{
Outlet oOutlet = null;
List<Outlet> oList = new List<Outlet>();
Params_Get_Outlet_By_OUTLET_ID_List_SP oParams_Get_Outlet_By_OUTLET_ID_List_SP = new Params_Get_Outlet_By_OUTLET_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_OUTLET_ID_List_Adv");}
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_OUTLET_ID_List_Adv(i_Params_Get_Outlet_By_OUTLET_ID_List.OUTLET_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oOutlet.My_Outlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry.My_Outlet_type, oOutlet.My_Outlet_type);
oOutlet.My_Hardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry.My_Hardware_link, oOutlet.My_Hardware_link);
oOutlet.My_Room = new Room();
oTools.CopyPropValues(oDBEntry.My_Room, oOutlet.My_Room);
oList.Add(oOutlet);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_OUTLET_ID_List_Adv");}
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_OUTLET_TYPE_ID_List_Adv(Params_Get_Outlet_type_By_OUTLET_TYPE_ID_List i_Params_Get_Outlet_type_By_OUTLET_TYPE_ID_List)
{
Outlet_type oOutlet_type = null;
List<Outlet_type> oList = new List<Outlet_type>();
Params_Get_Outlet_type_By_OUTLET_TYPE_ID_List_SP oParams_Get_Outlet_type_By_OUTLET_TYPE_ID_List_SP = new Params_Get_Outlet_type_By_OUTLET_TYPE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_type_By_OUTLET_TYPE_ID_List_Adv");}
#region Body Section.
List<DALC.Outlet_type> oList_DBEntries = _AppContext.Get_Outlet_type_By_OUTLET_TYPE_ID_List_Adv(i_Params_Get_Outlet_type_By_OUTLET_TYPE_ID_List.OUTLET_TYPE_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_type_By_OUTLET_TYPE_ID_List_Adv");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OUTLET_UI_ID_List_Adv(Params_Get_Outlet_ui_By_OUTLET_UI_ID_List i_Params_Get_Outlet_ui_By_OUTLET_UI_ID_List)
{
Outlet_ui oOutlet_ui = null;
List<Outlet_ui> oList = new List<Outlet_ui>();
Params_Get_Outlet_ui_By_OUTLET_UI_ID_List_SP oParams_Get_Outlet_ui_By_OUTLET_UI_ID_List_SP = new Params_Get_Outlet_ui_By_OUTLET_UI_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_OUTLET_UI_ID_List_Adv");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_OUTLET_UI_ID_List_Adv(i_Params_Get_Outlet_ui_By_OUTLET_UI_ID_List.OUTLET_UI_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oOutlet_ui.My_Outlet = new Outlet();
oTools.CopyPropValues(oDBEntry.My_Outlet, oOutlet_ui.My_Outlet);
oOutlet_ui.My_Ui = new Ui();
oTools.CopyPropValues(oDBEntry.My_Ui, oOutlet_ui.My_Ui);
oOutlet_ui.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oOutlet_ui.My_User);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_OUTLET_UI_ID_List_Adv");}
return oList;
}
public List<Plc> Get_Plc_By_PLC_ID_List_Adv(Params_Get_Plc_By_PLC_ID_List i_Params_Get_Plc_By_PLC_ID_List)
{
Plc oPlc = null;
List<Plc> oList = new List<Plc>();
Params_Get_Plc_By_PLC_ID_List_SP oParams_Get_Plc_By_PLC_ID_List_SP = new Params_Get_Plc_By_PLC_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Plc_By_PLC_ID_List_Adv");}
#region Body Section.
List<DALC.Plc> oList_DBEntries = _AppContext.Get_Plc_By_PLC_ID_List_Adv(i_Params_Get_Plc_By_PLC_ID_List.PLC_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Plc_By_PLC_ID_List_Adv");}
return oList;
}
public List<Room> Get_Room_By_ROOM_ID_List_Adv(Params_Get_Room_By_ROOM_ID_List i_Params_Get_Room_By_ROOM_ID_List)
{
Room oRoom = null;
List<Room> oList = new List<Room>();
Params_Get_Room_By_ROOM_ID_List_SP oParams_Get_Room_By_ROOM_ID_List_SP = new Params_Get_Room_By_ROOM_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_ROOM_ID_List_Adv");}
#region Body Section.
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_ROOM_ID_List_Adv(i_Params_Get_Room_By_ROOM_ID_List.ROOM_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oRoom.My_Floor = new Floor();
oTools.CopyPropValues(oDBEntry.My_Floor, oRoom.My_Floor);
oList.Add(oRoom);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_ROOM_ID_List_Adv");}
return oList;
}
public List<Ui> Get_Ui_By_UI_ID_List_Adv(Params_Get_Ui_By_UI_ID_List i_Params_Get_Ui_By_UI_ID_List)
{
Ui oUi = null;
List<Ui> oList = new List<Ui>();
Params_Get_Ui_By_UI_ID_List_SP oParams_Get_Ui_By_UI_ID_List_SP = new Params_Get_Ui_By_UI_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Ui_By_UI_ID_List_Adv");}
#region Body Section.
List<DALC.Ui> oList_DBEntries = _AppContext.Get_Ui_By_UI_ID_List_Adv(i_Params_Get_Ui_By_UI_ID_List.UI_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Ui_By_UI_ID_List_Adv");}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List_Adv(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List_Adv");}
return oList;
}
public List<Floor> Get_Floor_By_OWNER_ID_Adv(Params_Get_Floor_By_OWNER_ID i_Params_Get_Floor_By_OWNER_ID)
{
List<Floor> oList = new List<Floor>();
Floor oFloor = new Floor();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Floor_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Floor> oList_DBEntries = _AppContext.Get_Floor_By_OWNER_ID_Adv(i_Params_Get_Floor_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Floor_By_OWNER_ID_Adv");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_OWNER_ID_Adv(Params_Get_Hardware_link_By_OWNER_ID i_Params_Get_Hardware_link_By_OWNER_ID)
{
List<Hardware_link> oList = new List<Hardware_link>();
Hardware_link oHardware_link = new Hardware_link();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_OWNER_ID_Adv(i_Params_Get_Hardware_link_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oHardware_link.My_Plc = new Plc();
oTools.CopyPropValues(oDBEntry.My_Plc, oHardware_link.My_Plc);
oList.Add(oHardware_link);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_OWNER_ID_Adv");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_PLC_ID_Adv(Params_Get_Hardware_link_By_PLC_ID i_Params_Get_Hardware_link_By_PLC_ID)
{
List<Hardware_link> oList = new List<Hardware_link>();
Hardware_link oHardware_link = new Hardware_link();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_PLC_ID_Adv");}
#region Body Section.
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_PLC_ID_Adv(i_Params_Get_Hardware_link_By_PLC_ID.PLC_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oHardware_link.My_Plc = new Plc();
oTools.CopyPropValues(oDBEntry.My_Plc, oHardware_link.My_Plc);
oList.Add(oHardware_link);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_PLC_ID_Adv");}
return oList;
}
public List<Outlet> Get_Outlet_By_OWNER_ID_Adv(Params_Get_Outlet_By_OWNER_ID i_Params_Get_Outlet_By_OWNER_ID)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_OWNER_ID_Adv(i_Params_Get_Outlet_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oOutlet.My_Outlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry.My_Outlet_type, oOutlet.My_Outlet_type);
oOutlet.My_Hardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry.My_Hardware_link, oOutlet.My_Hardware_link);
oOutlet.My_Room = new Room();
oTools.CopyPropValues(oDBEntry.My_Room, oOutlet.My_Room);
oList.Add(oOutlet);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_OWNER_ID_Adv");}
return oList;
}
public List<Outlet> Get_Outlet_By_ROOM_ID_Adv(Params_Get_Outlet_By_ROOM_ID i_Params_Get_Outlet_By_ROOM_ID)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_ROOM_ID_Adv");}
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_ROOM_ID_Adv(i_Params_Get_Outlet_By_ROOM_ID.ROOM_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oOutlet.My_Outlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry.My_Outlet_type, oOutlet.My_Outlet_type);
oOutlet.My_Hardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry.My_Hardware_link, oOutlet.My_Hardware_link);
oOutlet.My_Room = new Room();
oTools.CopyPropValues(oDBEntry.My_Room, oOutlet.My_Room);
oList.Add(oOutlet);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_ROOM_ID_Adv");}
return oList;
}
public List<Outlet> Get_Outlet_By_OUTLET_TYPE_ID_Adv(Params_Get_Outlet_By_OUTLET_TYPE_ID i_Params_Get_Outlet_By_OUTLET_TYPE_ID)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_OUTLET_TYPE_ID_Adv");}
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_OUTLET_TYPE_ID_Adv(i_Params_Get_Outlet_By_OUTLET_TYPE_ID.OUTLET_TYPE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oOutlet.My_Outlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry.My_Outlet_type, oOutlet.My_Outlet_type);
oOutlet.My_Hardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry.My_Hardware_link, oOutlet.My_Hardware_link);
oOutlet.My_Room = new Room();
oTools.CopyPropValues(oDBEntry.My_Room, oOutlet.My_Room);
oList.Add(oOutlet);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_OUTLET_TYPE_ID_Adv");}
return oList;
}
public List<Outlet> Get_Outlet_By_HARDWARE_LINK_ID_Adv(Params_Get_Outlet_By_HARDWARE_LINK_ID i_Params_Get_Outlet_By_HARDWARE_LINK_ID)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_HARDWARE_LINK_ID_Adv");}
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_HARDWARE_LINK_ID_Adv(i_Params_Get_Outlet_By_HARDWARE_LINK_ID.HARDWARE_LINK_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oOutlet.My_Outlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry.My_Outlet_type, oOutlet.My_Outlet_type);
oOutlet.My_Hardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry.My_Hardware_link, oOutlet.My_Hardware_link);
oOutlet.My_Room = new Room();
oTools.CopyPropValues(oDBEntry.My_Room, oOutlet.My_Room);
oList.Add(oOutlet);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_HARDWARE_LINK_ID_Adv");}
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_OWNER_ID_Adv(Params_Get_Outlet_type_By_OWNER_ID i_Params_Get_Outlet_type_By_OWNER_ID)
{
List<Outlet_type> oList = new List<Outlet_type>();
Outlet_type oOutlet_type = new Outlet_type();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_type_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Outlet_type> oList_DBEntries = _AppContext.Get_Outlet_type_By_OWNER_ID_Adv(i_Params_Get_Outlet_type_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_type_By_OWNER_ID_Adv");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OWNER_ID_Adv(Params_Get_Outlet_ui_By_OWNER_ID i_Params_Get_Outlet_ui_By_OWNER_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_OWNER_ID_Adv(i_Params_Get_Outlet_ui_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oOutlet_ui.My_Outlet = new Outlet();
oTools.CopyPropValues(oDBEntry.My_Outlet, oOutlet_ui.My_Outlet);
oOutlet_ui.My_Ui = new Ui();
oTools.CopyPropValues(oDBEntry.My_Ui, oOutlet_ui.My_Ui);
oOutlet_ui.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oOutlet_ui.My_User);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_OWNER_ID_Adv");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OUTLET_ID_Adv(Params_Get_Outlet_ui_By_OUTLET_ID i_Params_Get_Outlet_ui_By_OUTLET_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_OUTLET_ID_Adv");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_OUTLET_ID_Adv(i_Params_Get_Outlet_ui_By_OUTLET_ID.OUTLET_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oOutlet_ui.My_Outlet = new Outlet();
oTools.CopyPropValues(oDBEntry.My_Outlet, oOutlet_ui.My_Outlet);
oOutlet_ui.My_Ui = new Ui();
oTools.CopyPropValues(oDBEntry.My_Ui, oOutlet_ui.My_Ui);
oOutlet_ui.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oOutlet_ui.My_User);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_OUTLET_ID_Adv");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_UI_ID_Adv(Params_Get_Outlet_ui_By_UI_ID i_Params_Get_Outlet_ui_By_UI_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_UI_ID_Adv");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_UI_ID_Adv(i_Params_Get_Outlet_ui_By_UI_ID.UI_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oOutlet_ui.My_Outlet = new Outlet();
oTools.CopyPropValues(oDBEntry.My_Outlet, oOutlet_ui.My_Outlet);
oOutlet_ui.My_Ui = new Ui();
oTools.CopyPropValues(oDBEntry.My_Ui, oOutlet_ui.My_Ui);
oOutlet_ui.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oOutlet_ui.My_User);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_UI_ID_Adv");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_USER_ID_Adv(Params_Get_Outlet_ui_By_USER_ID i_Params_Get_Outlet_ui_By_USER_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_USER_ID_Adv");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_USER_ID_Adv(i_Params_Get_Outlet_ui_By_USER_ID.USER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oOutlet_ui.My_Outlet = new Outlet();
oTools.CopyPropValues(oDBEntry.My_Outlet, oOutlet_ui.My_Outlet);
oOutlet_ui.My_Ui = new Ui();
oTools.CopyPropValues(oDBEntry.My_Ui, oOutlet_ui.My_Ui);
oOutlet_ui.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oOutlet_ui.My_User);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_USER_ID_Adv");}
return oList;
}
public List<Plc> Get_Plc_By_OWNER_ID_Adv(Params_Get_Plc_By_OWNER_ID i_Params_Get_Plc_By_OWNER_ID)
{
List<Plc> oList = new List<Plc>();
Plc oPlc = new Plc();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Plc_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Plc> oList_DBEntries = _AppContext.Get_Plc_By_OWNER_ID_Adv(i_Params_Get_Plc_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Plc_By_OWNER_ID_Adv");}
return oList;
}
public List<Room> Get_Room_By_OWNER_ID_Adv(Params_Get_Room_By_OWNER_ID i_Params_Get_Room_By_OWNER_ID)
{
List<Room> oList = new List<Room>();
Room oRoom = new Room();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_OWNER_ID_Adv(i_Params_Get_Room_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oRoom.My_Floor = new Floor();
oTools.CopyPropValues(oDBEntry.My_Floor, oRoom.My_Floor);
oList.Add(oRoom);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_OWNER_ID_Adv");}
return oList;
}
public List<Room> Get_Room_By_FLOOR_ID_Adv(Params_Get_Room_By_FLOOR_ID i_Params_Get_Room_By_FLOOR_ID)
{
List<Room> oList = new List<Room>();
Room oRoom = new Room();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_FLOOR_ID_Adv");}
#region Body Section.
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_FLOOR_ID_Adv(i_Params_Get_Room_By_FLOOR_ID.FLOOR_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oRoom.My_Floor = new Floor();
oTools.CopyPropValues(oDBEntry.My_Floor, oRoom.My_Floor);
oList.Add(oRoom);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_FLOOR_ID_Adv");}
return oList;
}
public List<Ui> Get_Ui_By_OWNER_ID_Adv(Params_Get_Ui_By_OWNER_ID i_Params_Get_Ui_By_OWNER_ID)
{
List<Ui> oList = new List<Ui>();
Ui oUi = new Ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Ui_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Ui> oList_DBEntries = _AppContext.Get_Ui_By_OWNER_ID_Adv(i_Params_Get_Ui_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Ui_By_OWNER_ID_Adv");}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID_Adv(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID_Adv");}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME_Adv(i_Params_Get_User_By_USERNAME.USERNAME);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME_Adv");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_PLC_ID_List_Adv(Params_Get_Hardware_link_By_PLC_ID_List i_Params_Get_Hardware_link_By_PLC_ID_List)
{
List<Hardware_link> oList = new List<Hardware_link>();
Hardware_link oHardware_link = new Hardware_link();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_PLC_ID_List_Adv");}
#region Body Section.
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_PLC_ID_List_Adv(i_Params_Get_Hardware_link_By_PLC_ID_List.PLC_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oHardware_link.My_Plc = new Plc();
oTools.CopyPropValues(oDBEntry.My_Plc, oHardware_link.My_Plc);
oList.Add(oHardware_link);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_PLC_ID_List_Adv");}
return oList;
}
public List<Outlet> Get_Outlet_By_ROOM_ID_List_Adv(Params_Get_Outlet_By_ROOM_ID_List i_Params_Get_Outlet_By_ROOM_ID_List)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_ROOM_ID_List_Adv");}
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_ROOM_ID_List_Adv(i_Params_Get_Outlet_By_ROOM_ID_List.ROOM_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oOutlet.My_Outlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry.My_Outlet_type, oOutlet.My_Outlet_type);
oOutlet.My_Hardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry.My_Hardware_link, oOutlet.My_Hardware_link);
oOutlet.My_Room = new Room();
oTools.CopyPropValues(oDBEntry.My_Room, oOutlet.My_Room);
oList.Add(oOutlet);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_ROOM_ID_List_Adv");}
return oList;
}
public List<Outlet> Get_Outlet_By_OUTLET_TYPE_ID_List_Adv(Params_Get_Outlet_By_OUTLET_TYPE_ID_List i_Params_Get_Outlet_By_OUTLET_TYPE_ID_List)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_OUTLET_TYPE_ID_List_Adv");}
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_OUTLET_TYPE_ID_List_Adv(i_Params_Get_Outlet_By_OUTLET_TYPE_ID_List.OUTLET_TYPE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oOutlet.My_Outlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry.My_Outlet_type, oOutlet.My_Outlet_type);
oOutlet.My_Hardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry.My_Hardware_link, oOutlet.My_Hardware_link);
oOutlet.My_Room = new Room();
oTools.CopyPropValues(oDBEntry.My_Room, oOutlet.My_Room);
oList.Add(oOutlet);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_OUTLET_TYPE_ID_List_Adv");}
return oList;
}
public List<Outlet> Get_Outlet_By_HARDWARE_LINK_ID_List_Adv(Params_Get_Outlet_By_HARDWARE_LINK_ID_List i_Params_Get_Outlet_By_HARDWARE_LINK_ID_List)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_HARDWARE_LINK_ID_List_Adv");}
#region Body Section.
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_HARDWARE_LINK_ID_List_Adv(i_Params_Get_Outlet_By_HARDWARE_LINK_ID_List.HARDWARE_LINK_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oOutlet.My_Outlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry.My_Outlet_type, oOutlet.My_Outlet_type);
oOutlet.My_Hardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry.My_Hardware_link, oOutlet.My_Hardware_link);
oOutlet.My_Room = new Room();
oTools.CopyPropValues(oDBEntry.My_Room, oOutlet.My_Room);
oList.Add(oOutlet);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_HARDWARE_LINK_ID_List_Adv");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OUTLET_ID_List_Adv(Params_Get_Outlet_ui_By_OUTLET_ID_List i_Params_Get_Outlet_ui_By_OUTLET_ID_List)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_OUTLET_ID_List_Adv");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_OUTLET_ID_List_Adv(i_Params_Get_Outlet_ui_By_OUTLET_ID_List.OUTLET_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oOutlet_ui.My_Outlet = new Outlet();
oTools.CopyPropValues(oDBEntry.My_Outlet, oOutlet_ui.My_Outlet);
oOutlet_ui.My_Ui = new Ui();
oTools.CopyPropValues(oDBEntry.My_Ui, oOutlet_ui.My_Ui);
oOutlet_ui.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oOutlet_ui.My_User);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_OUTLET_ID_List_Adv");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_UI_ID_List_Adv(Params_Get_Outlet_ui_By_UI_ID_List i_Params_Get_Outlet_ui_By_UI_ID_List)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_UI_ID_List_Adv");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_UI_ID_List_Adv(i_Params_Get_Outlet_ui_By_UI_ID_List.UI_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oOutlet_ui.My_Outlet = new Outlet();
oTools.CopyPropValues(oDBEntry.My_Outlet, oOutlet_ui.My_Outlet);
oOutlet_ui.My_Ui = new Ui();
oTools.CopyPropValues(oDBEntry.My_Ui, oOutlet_ui.My_Ui);
oOutlet_ui.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oOutlet_ui.My_User);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_UI_ID_List_Adv");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_USER_ID_List_Adv(Params_Get_Outlet_ui_By_USER_ID_List i_Params_Get_Outlet_ui_By_USER_ID_List)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_USER_ID_List_Adv");}
#region Body Section.
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_USER_ID_List_Adv(i_Params_Get_Outlet_ui_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oOutlet_ui.My_Outlet = new Outlet();
oTools.CopyPropValues(oDBEntry.My_Outlet, oOutlet_ui.My_Outlet);
oOutlet_ui.My_Ui = new Ui();
oTools.CopyPropValues(oDBEntry.My_Ui, oOutlet_ui.My_Ui);
oOutlet_ui.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oOutlet_ui.My_User);
oList.Add(oOutlet_ui);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_USER_ID_List_Adv");}
return oList;
}
public List<Room> Get_Room_By_FLOOR_ID_List_Adv(Params_Get_Room_By_FLOOR_ID_List i_Params_Get_Room_By_FLOOR_ID_List)
{
List<Room> oList = new List<Room>();
Room oRoom = new Room();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_FLOOR_ID_List_Adv");}
#region Body Section.
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_FLOOR_ID_List_Adv(i_Params_Get_Room_By_FLOOR_ID_List.FLOOR_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oRoom.My_Floor = new Floor();
oTools.CopyPropValues(oDBEntry.My_Floor, oRoom.My_Floor);
oList.Add(oRoom);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_FLOOR_ID_List_Adv");}
return oList;
}
public List<Floor> Get_Floor_By_Criteria_Adv(Params_Get_Floor_By_Criteria i_Params_Get_Floor_By_Criteria)
{
List<Floor> oList = new List<Floor>();
long? tmp_TOTAL_COUNT = 0;
Floor oFloor = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Floor_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Floor_By_Criteria.OWNER_ID == null) || (i_Params_Get_Floor_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Floor_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Floor_By_Criteria.START_ROW == null) { i_Params_Get_Floor_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Floor_By_Criteria.END_ROW == null) || (i_Params_Get_Floor_By_Criteria.END_ROW == 0)) { i_Params_Get_Floor_By_Criteria.END_ROW = 1000000; }
List<DALC.Floor> oList_DBEntries = _AppContext.Get_Floor_By_Criteria_Adv(i_Params_Get_Floor_By_Criteria.NAME,i_Params_Get_Floor_By_Criteria.OWNER_ID,i_Params_Get_Floor_By_Criteria.START_ROW,i_Params_Get_Floor_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Floor_By_Criteria_Adv");}
return oList;
}
public List<Floor> Get_Floor_By_Where_Adv(Params_Get_Floor_By_Where i_Params_Get_Floor_By_Where)
{
List<Floor> oList = new List<Floor>();
long? tmp_TOTAL_COUNT = 0;
Floor oFloor = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Floor_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Floor_By_Where.OWNER_ID == null) || (i_Params_Get_Floor_By_Where.OWNER_ID == 0)) { i_Params_Get_Floor_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Floor_By_Where.START_ROW == null) { i_Params_Get_Floor_By_Where.START_ROW = 0; }
if ((i_Params_Get_Floor_By_Where.END_ROW == null) || (i_Params_Get_Floor_By_Where.END_ROW == 0)) { i_Params_Get_Floor_By_Where.END_ROW = 1000000; }
List<DALC.Floor> oList_DBEntries = _AppContext.Get_Floor_By_Where_Adv(i_Params_Get_Floor_By_Where.NAME,i_Params_Get_Floor_By_Where.OWNER_ID,i_Params_Get_Floor_By_Where.START_ROW,i_Params_Get_Floor_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Floor_By_Where_Adv");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Criteria_Adv(Params_Get_Hardware_link_By_Criteria i_Params_Get_Hardware_link_By_Criteria)
{
List<Hardware_link> oList = new List<Hardware_link>();
long? tmp_TOTAL_COUNT = 0;
Hardware_link oHardware_link = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Hardware_link_By_Criteria.OWNER_ID == null) || (i_Params_Get_Hardware_link_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Hardware_link_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Hardware_link_By_Criteria.START_ROW == null) { i_Params_Get_Hardware_link_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Hardware_link_By_Criteria.END_ROW == null) || (i_Params_Get_Hardware_link_By_Criteria.END_ROW == 0)) { i_Params_Get_Hardware_link_By_Criteria.END_ROW = 1000000; }
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_Criteria_Adv(i_Params_Get_Hardware_link_By_Criteria.PLC_ADDRESS,i_Params_Get_Hardware_link_By_Criteria.OWNER_ID,i_Params_Get_Hardware_link_By_Criteria.START_ROW,i_Params_Get_Hardware_link_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oHardware_link.My_Plc = new Plc();
oTools.CopyPropValues(oDBEntry.My_Plc, oHardware_link.My_Plc);
oList.Add(oHardware_link);
}
}
i_Params_Get_Hardware_link_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_Criteria_Adv");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Where_Adv(Params_Get_Hardware_link_By_Where i_Params_Get_Hardware_link_By_Where)
{
List<Hardware_link> oList = new List<Hardware_link>();
long? tmp_TOTAL_COUNT = 0;
Hardware_link oHardware_link = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Hardware_link_By_Where.OWNER_ID == null) || (i_Params_Get_Hardware_link_By_Where.OWNER_ID == 0)) { i_Params_Get_Hardware_link_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Hardware_link_By_Where.START_ROW == null) { i_Params_Get_Hardware_link_By_Where.START_ROW = 0; }
if ((i_Params_Get_Hardware_link_By_Where.END_ROW == null) || (i_Params_Get_Hardware_link_By_Where.END_ROW == 0)) { i_Params_Get_Hardware_link_By_Where.END_ROW = 1000000; }
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_Where_Adv(i_Params_Get_Hardware_link_By_Where.PLC_ADDRESS,i_Params_Get_Hardware_link_By_Where.OWNER_ID,i_Params_Get_Hardware_link_By_Where.START_ROW,i_Params_Get_Hardware_link_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oHardware_link.My_Plc = new Plc();
oTools.CopyPropValues(oDBEntry.My_Plc, oHardware_link.My_Plc);
oList.Add(oHardware_link);
}
}
i_Params_Get_Hardware_link_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_Where_Adv");}
return oList;
}
public List<Outlet> Get_Outlet_By_Criteria_Adv(Params_Get_Outlet_By_Criteria i_Params_Get_Outlet_By_Criteria)
{
List<Outlet> oList = new List<Outlet>();
long? tmp_TOTAL_COUNT = 0;
Outlet oOutlet = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Outlet_By_Criteria.OWNER_ID == null) || (i_Params_Get_Outlet_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Outlet_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_By_Criteria.START_ROW == null) { i_Params_Get_Outlet_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Outlet_By_Criteria.END_ROW == null) || (i_Params_Get_Outlet_By_Criteria.END_ROW == 0)) { i_Params_Get_Outlet_By_Criteria.END_ROW = 1000000; }
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_Criteria_Adv(i_Params_Get_Outlet_By_Criteria.NAME,i_Params_Get_Outlet_By_Criteria.CURRENT_VALUE,i_Params_Get_Outlet_By_Criteria.OWNER_ID,i_Params_Get_Outlet_By_Criteria.START_ROW,i_Params_Get_Outlet_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oOutlet.My_Outlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry.My_Outlet_type, oOutlet.My_Outlet_type);
oOutlet.My_Hardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry.My_Hardware_link, oOutlet.My_Hardware_link);
oOutlet.My_Room = new Room();
oTools.CopyPropValues(oDBEntry.My_Room, oOutlet.My_Room);
oList.Add(oOutlet);
}
}
i_Params_Get_Outlet_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_Criteria_Adv");}
return oList;
}
public List<Outlet> Get_Outlet_By_Where_Adv(Params_Get_Outlet_By_Where i_Params_Get_Outlet_By_Where)
{
List<Outlet> oList = new List<Outlet>();
long? tmp_TOTAL_COUNT = 0;
Outlet oOutlet = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Outlet_By_Where.OWNER_ID == null) || (i_Params_Get_Outlet_By_Where.OWNER_ID == 0)) { i_Params_Get_Outlet_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_By_Where.START_ROW == null) { i_Params_Get_Outlet_By_Where.START_ROW = 0; }
if ((i_Params_Get_Outlet_By_Where.END_ROW == null) || (i_Params_Get_Outlet_By_Where.END_ROW == 0)) { i_Params_Get_Outlet_By_Where.END_ROW = 1000000; }
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_Where_Adv(i_Params_Get_Outlet_By_Where.NAME,i_Params_Get_Outlet_By_Where.CURRENT_VALUE,i_Params_Get_Outlet_By_Where.OWNER_ID,i_Params_Get_Outlet_By_Where.START_ROW,i_Params_Get_Outlet_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oOutlet.My_Outlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry.My_Outlet_type, oOutlet.My_Outlet_type);
oOutlet.My_Hardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry.My_Hardware_link, oOutlet.My_Hardware_link);
oOutlet.My_Room = new Room();
oTools.CopyPropValues(oDBEntry.My_Room, oOutlet.My_Room);
oList.Add(oOutlet);
}
}
i_Params_Get_Outlet_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_Where_Adv");}
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_Criteria_Adv(Params_Get_Outlet_type_By_Criteria i_Params_Get_Outlet_type_By_Criteria)
{
List<Outlet_type> oList = new List<Outlet_type>();
long? tmp_TOTAL_COUNT = 0;
Outlet_type oOutlet_type = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_type_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Outlet_type_By_Criteria.OWNER_ID == null) || (i_Params_Get_Outlet_type_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Outlet_type_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_type_By_Criteria.START_ROW == null) { i_Params_Get_Outlet_type_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Outlet_type_By_Criteria.END_ROW == null) || (i_Params_Get_Outlet_type_By_Criteria.END_ROW == 0)) { i_Params_Get_Outlet_type_By_Criteria.END_ROW = 1000000; }
List<DALC.Outlet_type> oList_DBEntries = _AppContext.Get_Outlet_type_By_Criteria_Adv(i_Params_Get_Outlet_type_By_Criteria.NAME,i_Params_Get_Outlet_type_By_Criteria.OWNER_ID,i_Params_Get_Outlet_type_By_Criteria.START_ROW,i_Params_Get_Outlet_type_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_type_By_Criteria_Adv");}
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_Where_Adv(Params_Get_Outlet_type_By_Where i_Params_Get_Outlet_type_By_Where)
{
List<Outlet_type> oList = new List<Outlet_type>();
long? tmp_TOTAL_COUNT = 0;
Outlet_type oOutlet_type = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_type_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Outlet_type_By_Where.OWNER_ID == null) || (i_Params_Get_Outlet_type_By_Where.OWNER_ID == 0)) { i_Params_Get_Outlet_type_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_type_By_Where.START_ROW == null) { i_Params_Get_Outlet_type_By_Where.START_ROW = 0; }
if ((i_Params_Get_Outlet_type_By_Where.END_ROW == null) || (i_Params_Get_Outlet_type_By_Where.END_ROW == 0)) { i_Params_Get_Outlet_type_By_Where.END_ROW = 1000000; }
List<DALC.Outlet_type> oList_DBEntries = _AppContext.Get_Outlet_type_By_Where_Adv(i_Params_Get_Outlet_type_By_Where.NAME,i_Params_Get_Outlet_type_By_Where.OWNER_ID,i_Params_Get_Outlet_type_By_Where.START_ROW,i_Params_Get_Outlet_type_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_type_By_Where_Adv");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Criteria_Adv(Params_Get_Outlet_ui_By_Criteria i_Params_Get_Outlet_ui_By_Criteria)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
long? tmp_TOTAL_COUNT = 0;
Outlet_ui oOutlet_ui = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Outlet_ui_By_Criteria.OWNER_ID == null) || (i_Params_Get_Outlet_ui_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Outlet_ui_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_ui_By_Criteria.START_ROW == null) { i_Params_Get_Outlet_ui_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Outlet_ui_By_Criteria.END_ROW == null) || (i_Params_Get_Outlet_ui_By_Criteria.END_ROW == 0)) { i_Params_Get_Outlet_ui_By_Criteria.END_ROW = 1000000; }
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_Criteria_Adv(i_Params_Get_Outlet_ui_By_Criteria.DESCRIPTION,i_Params_Get_Outlet_ui_By_Criteria.OWNER_ID,i_Params_Get_Outlet_ui_By_Criteria.START_ROW,i_Params_Get_Outlet_ui_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oOutlet_ui.My_Outlet = new Outlet();
oTools.CopyPropValues(oDBEntry.My_Outlet, oOutlet_ui.My_Outlet);
oOutlet_ui.My_Ui = new Ui();
oTools.CopyPropValues(oDBEntry.My_Ui, oOutlet_ui.My_Ui);
oOutlet_ui.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oOutlet_ui.My_User);
oList.Add(oOutlet_ui);
}
}
i_Params_Get_Outlet_ui_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_Criteria_Adv");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Where_Adv(Params_Get_Outlet_ui_By_Where i_Params_Get_Outlet_ui_By_Where)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
long? tmp_TOTAL_COUNT = 0;
Outlet_ui oOutlet_ui = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Outlet_ui_By_Where.OWNER_ID == null) || (i_Params_Get_Outlet_ui_By_Where.OWNER_ID == 0)) { i_Params_Get_Outlet_ui_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Outlet_ui_By_Where.START_ROW == null) { i_Params_Get_Outlet_ui_By_Where.START_ROW = 0; }
if ((i_Params_Get_Outlet_ui_By_Where.END_ROW == null) || (i_Params_Get_Outlet_ui_By_Where.END_ROW == 0)) { i_Params_Get_Outlet_ui_By_Where.END_ROW = 1000000; }
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_Where_Adv(i_Params_Get_Outlet_ui_By_Where.DESCRIPTION,i_Params_Get_Outlet_ui_By_Where.OWNER_ID,i_Params_Get_Outlet_ui_By_Where.START_ROW,i_Params_Get_Outlet_ui_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oOutlet_ui.My_Outlet = new Outlet();
oTools.CopyPropValues(oDBEntry.My_Outlet, oOutlet_ui.My_Outlet);
oOutlet_ui.My_Ui = new Ui();
oTools.CopyPropValues(oDBEntry.My_Ui, oOutlet_ui.My_Ui);
oOutlet_ui.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oOutlet_ui.My_User);
oList.Add(oOutlet_ui);
}
}
i_Params_Get_Outlet_ui_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_Where_Adv");}
return oList;
}
public List<Plc> Get_Plc_By_Criteria_Adv(Params_Get_Plc_By_Criteria i_Params_Get_Plc_By_Criteria)
{
List<Plc> oList = new List<Plc>();
long? tmp_TOTAL_COUNT = 0;
Plc oPlc = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Plc_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Plc_By_Criteria.OWNER_ID == null) || (i_Params_Get_Plc_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Plc_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Plc_By_Criteria.START_ROW == null) { i_Params_Get_Plc_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Plc_By_Criteria.END_ROW == null) || (i_Params_Get_Plc_By_Criteria.END_ROW == 0)) { i_Params_Get_Plc_By_Criteria.END_ROW = 1000000; }
List<DALC.Plc> oList_DBEntries = _AppContext.Get_Plc_By_Criteria_Adv(i_Params_Get_Plc_By_Criteria.LOCATION,i_Params_Get_Plc_By_Criteria.PORT,i_Params_Get_Plc_By_Criteria.TYPE,i_Params_Get_Plc_By_Criteria.OWNER_ID,i_Params_Get_Plc_By_Criteria.START_ROW,i_Params_Get_Plc_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Plc_By_Criteria_Adv");}
return oList;
}
public List<Plc> Get_Plc_By_Where_Adv(Params_Get_Plc_By_Where i_Params_Get_Plc_By_Where)
{
List<Plc> oList = new List<Plc>();
long? tmp_TOTAL_COUNT = 0;
Plc oPlc = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Plc_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Plc_By_Where.OWNER_ID == null) || (i_Params_Get_Plc_By_Where.OWNER_ID == 0)) { i_Params_Get_Plc_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Plc_By_Where.START_ROW == null) { i_Params_Get_Plc_By_Where.START_ROW = 0; }
if ((i_Params_Get_Plc_By_Where.END_ROW == null) || (i_Params_Get_Plc_By_Where.END_ROW == 0)) { i_Params_Get_Plc_By_Where.END_ROW = 1000000; }
List<DALC.Plc> oList_DBEntries = _AppContext.Get_Plc_By_Where_Adv(i_Params_Get_Plc_By_Where.LOCATION,i_Params_Get_Plc_By_Where.PORT,i_Params_Get_Plc_By_Where.TYPE,i_Params_Get_Plc_By_Where.OWNER_ID,i_Params_Get_Plc_By_Where.START_ROW,i_Params_Get_Plc_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Plc_By_Where_Adv");}
return oList;
}
public List<Room> Get_Room_By_Criteria_Adv(Params_Get_Room_By_Criteria i_Params_Get_Room_By_Criteria)
{
List<Room> oList = new List<Room>();
long? tmp_TOTAL_COUNT = 0;
Room oRoom = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Room_By_Criteria.OWNER_ID == null) || (i_Params_Get_Room_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Room_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Room_By_Criteria.START_ROW == null) { i_Params_Get_Room_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Room_By_Criteria.END_ROW == null) || (i_Params_Get_Room_By_Criteria.END_ROW == 0)) { i_Params_Get_Room_By_Criteria.END_ROW = 1000000; }
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_Criteria_Adv(i_Params_Get_Room_By_Criteria.NAME,i_Params_Get_Room_By_Criteria.OWNER_ID,i_Params_Get_Room_By_Criteria.START_ROW,i_Params_Get_Room_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oRoom.My_Floor = new Floor();
oTools.CopyPropValues(oDBEntry.My_Floor, oRoom.My_Floor);
oList.Add(oRoom);
}
}
i_Params_Get_Room_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_Criteria_Adv");}
return oList;
}
public List<Room> Get_Room_By_Where_Adv(Params_Get_Room_By_Where i_Params_Get_Room_By_Where)
{
List<Room> oList = new List<Room>();
long? tmp_TOTAL_COUNT = 0;
Room oRoom = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Room_By_Where.OWNER_ID == null) || (i_Params_Get_Room_By_Where.OWNER_ID == 0)) { i_Params_Get_Room_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Room_By_Where.START_ROW == null) { i_Params_Get_Room_By_Where.START_ROW = 0; }
if ((i_Params_Get_Room_By_Where.END_ROW == null) || (i_Params_Get_Room_By_Where.END_ROW == 0)) { i_Params_Get_Room_By_Where.END_ROW = 1000000; }
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_Where_Adv(i_Params_Get_Room_By_Where.NAME,i_Params_Get_Room_By_Where.OWNER_ID,i_Params_Get_Room_By_Where.START_ROW,i_Params_Get_Room_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oRoom.My_Floor = new Floor();
oTools.CopyPropValues(oDBEntry.My_Floor, oRoom.My_Floor);
oList.Add(oRoom);
}
}
i_Params_Get_Room_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_Where_Adv");}
return oList;
}
public List<Ui> Get_Ui_By_Criteria_Adv(Params_Get_Ui_By_Criteria i_Params_Get_Ui_By_Criteria)
{
List<Ui> oList = new List<Ui>();
long? tmp_TOTAL_COUNT = 0;
Ui oUi = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Ui_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Ui_By_Criteria.OWNER_ID == null) || (i_Params_Get_Ui_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Ui_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Ui_By_Criteria.START_ROW == null) { i_Params_Get_Ui_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Ui_By_Criteria.END_ROW == null) || (i_Params_Get_Ui_By_Criteria.END_ROW == 0)) { i_Params_Get_Ui_By_Criteria.END_ROW = 1000000; }
List<DALC.Ui> oList_DBEntries = _AppContext.Get_Ui_By_Criteria_Adv(i_Params_Get_Ui_By_Criteria.COLOR,i_Params_Get_Ui_By_Criteria.OTHER,i_Params_Get_Ui_By_Criteria.OWNER_ID,i_Params_Get_Ui_By_Criteria.START_ROW,i_Params_Get_Ui_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Ui_By_Criteria_Adv");}
return oList;
}
public List<Ui> Get_Ui_By_Where_Adv(Params_Get_Ui_By_Where i_Params_Get_Ui_By_Where)
{
List<Ui> oList = new List<Ui>();
long? tmp_TOTAL_COUNT = 0;
Ui oUi = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Ui_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Ui_By_Where.OWNER_ID == null) || (i_Params_Get_Ui_By_Where.OWNER_ID == 0)) { i_Params_Get_Ui_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Ui_By_Where.START_ROW == null) { i_Params_Get_Ui_By_Where.START_ROW = 0; }
if ((i_Params_Get_Ui_By_Where.END_ROW == null) || (i_Params_Get_Ui_By_Where.END_ROW == 0)) { i_Params_Get_Ui_By_Where.END_ROW = 1000000; }
List<DALC.Ui> oList_DBEntries = _AppContext.Get_Ui_By_Where_Adv(i_Params_Get_Ui_By_Where.COLOR,i_Params_Get_Ui_By_Where.OTHER,i_Params_Get_Ui_By_Where.OWNER_ID,i_Params_Get_Ui_By_Where.START_ROW,i_Params_Get_Ui_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Ui_By_Where_Adv");}
return oList;
}
public List<User> Get_User_By_Criteria_Adv(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria_Adv(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria_Adv");}
return oList;
}
public List<User> Get_User_By_Where_Adv(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where_Adv(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where_Adv");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Criteria_InList_Adv(Params_Get_Hardware_link_By_Criteria_InList i_Params_Get_Hardware_link_By_Criteria_InList)
{
List<Hardware_link> oList = new List<Hardware_link>();
Hardware_link oHardware_link = new Hardware_link();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Hardware_link_By_Criteria_InList_SP oParams_Get_Hardware_link_By_Criteria_InList_SP = new Params_Get_Hardware_link_By_Criteria_InList_SP();
Params_Get_Plc_By_PLC_ID oParams_Get_Plc_By_PLC_ID = new Params_Get_Plc_By_PLC_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_Criteria_InList_Adv");}
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
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_Criteria_InList_Adv(i_Params_Get_Hardware_link_By_Criteria_InList.PLC_ADDRESS,i_Params_Get_Hardware_link_By_Criteria_InList.PLC_ID_LIST,i_Params_Get_Hardware_link_By_Criteria_InList.OWNER_ID,i_Params_Get_Hardware_link_By_Criteria_InList.START_ROW,i_Params_Get_Hardware_link_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oHardware_link.My_Plc = new Plc();
oTools.CopyPropValues(oDBEntry.My_Plc, oHardware_link.My_Plc);
oList.Add(oHardware_link);
}
}
i_Params_Get_Hardware_link_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Hardware_link_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Hardware_link_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_Criteria_InList_Adv");}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Where_InList_Adv(Params_Get_Hardware_link_By_Where_InList i_Params_Get_Hardware_link_By_Where_InList)
{
List<Hardware_link> oList = new List<Hardware_link>();
Hardware_link oHardware_link = new Hardware_link();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Hardware_link_By_Where_InList_SP oParams_Get_Hardware_link_By_Where_InList_SP = new Params_Get_Hardware_link_By_Where_InList_SP();
Params_Get_Plc_By_PLC_ID oParams_Get_Plc_By_PLC_ID = new Params_Get_Plc_By_PLC_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Hardware_link_By_Where_InList_Adv");}
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
List<DALC.Hardware_link> oList_DBEntries = _AppContext.Get_Hardware_link_By_Where_InList_Adv(i_Params_Get_Hardware_link_By_Where_InList.PLC_ADDRESS,i_Params_Get_Hardware_link_By_Where_InList.PLC_ID_LIST,i_Params_Get_Hardware_link_By_Where_InList.OWNER_ID,i_Params_Get_Hardware_link_By_Where_InList.START_ROW,i_Params_Get_Hardware_link_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oHardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry, oHardware_link);
oHardware_link.My_Plc = new Plc();
oTools.CopyPropValues(oDBEntry.My_Plc, oHardware_link.My_Plc);
oList.Add(oHardware_link);
}
}
i_Params_Get_Hardware_link_By_Where_InList.TOTAL_COUNT = oParams_Get_Hardware_link_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Hardware_link_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Hardware_link_By_Where_InList_Adv");}
return oList;
}
public List<Outlet> Get_Outlet_By_Criteria_InList_Adv(Params_Get_Outlet_By_Criteria_InList i_Params_Get_Outlet_By_Criteria_InList)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Outlet_By_Criteria_InList_SP oParams_Get_Outlet_By_Criteria_InList_SP = new Params_Get_Outlet_By_Criteria_InList_SP();
Params_Get_Outlet_type_By_OUTLET_TYPE_ID oParams_Get_Outlet_type_By_OUTLET_TYPE_ID = new Params_Get_Outlet_type_By_OUTLET_TYPE_ID();
Params_Get_Hardware_link_By_HARDWARE_LINK_ID oParams_Get_Hardware_link_By_HARDWARE_LINK_ID = new Params_Get_Hardware_link_By_HARDWARE_LINK_ID();
Params_Get_Room_By_ROOM_ID oParams_Get_Room_By_ROOM_ID = new Params_Get_Room_By_ROOM_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_Criteria_InList_Adv");}
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
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_Criteria_InList_Adv(i_Params_Get_Outlet_By_Criteria_InList.NAME,i_Params_Get_Outlet_By_Criteria_InList.CURRENT_VALUE,i_Params_Get_Outlet_By_Criteria_InList.OUTLET_TYPE_ID_LIST,i_Params_Get_Outlet_By_Criteria_InList.HARDWARE_LINK_ID_LIST,i_Params_Get_Outlet_By_Criteria_InList.ROOM_ID_LIST,i_Params_Get_Outlet_By_Criteria_InList.OWNER_ID,i_Params_Get_Outlet_By_Criteria_InList.START_ROW,i_Params_Get_Outlet_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oOutlet.My_Outlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry.My_Outlet_type, oOutlet.My_Outlet_type);
oOutlet.My_Hardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry.My_Hardware_link, oOutlet.My_Hardware_link);
oOutlet.My_Room = new Room();
oTools.CopyPropValues(oDBEntry.My_Room, oOutlet.My_Room);
oList.Add(oOutlet);
}
}
i_Params_Get_Outlet_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Outlet_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Outlet_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_Criteria_InList_Adv");}
return oList;
}
public List<Outlet> Get_Outlet_By_Where_InList_Adv(Params_Get_Outlet_By_Where_InList i_Params_Get_Outlet_By_Where_InList)
{
List<Outlet> oList = new List<Outlet>();
Outlet oOutlet = new Outlet();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Outlet_By_Where_InList_SP oParams_Get_Outlet_By_Where_InList_SP = new Params_Get_Outlet_By_Where_InList_SP();
Params_Get_Outlet_type_By_OUTLET_TYPE_ID oParams_Get_Outlet_type_By_OUTLET_TYPE_ID = new Params_Get_Outlet_type_By_OUTLET_TYPE_ID();
Params_Get_Hardware_link_By_HARDWARE_LINK_ID oParams_Get_Hardware_link_By_HARDWARE_LINK_ID = new Params_Get_Hardware_link_By_HARDWARE_LINK_ID();
Params_Get_Room_By_ROOM_ID oParams_Get_Room_By_ROOM_ID = new Params_Get_Room_By_ROOM_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_By_Where_InList_Adv");}
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
List<DALC.Outlet> oList_DBEntries = _AppContext.Get_Outlet_By_Where_InList_Adv(i_Params_Get_Outlet_By_Where_InList.NAME,i_Params_Get_Outlet_By_Where_InList.CURRENT_VALUE,i_Params_Get_Outlet_By_Where_InList.OUTLET_TYPE_ID_LIST,i_Params_Get_Outlet_By_Where_InList.HARDWARE_LINK_ID_LIST,i_Params_Get_Outlet_By_Where_InList.ROOM_ID_LIST,i_Params_Get_Outlet_By_Where_InList.OWNER_ID,i_Params_Get_Outlet_By_Where_InList.START_ROW,i_Params_Get_Outlet_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet = new Outlet();
oTools.CopyPropValues(oDBEntry, oOutlet);
oOutlet.My_Outlet_type = new Outlet_type();
oTools.CopyPropValues(oDBEntry.My_Outlet_type, oOutlet.My_Outlet_type);
oOutlet.My_Hardware_link = new Hardware_link();
oTools.CopyPropValues(oDBEntry.My_Hardware_link, oOutlet.My_Hardware_link);
oOutlet.My_Room = new Room();
oTools.CopyPropValues(oDBEntry.My_Room, oOutlet.My_Room);
oList.Add(oOutlet);
}
}
i_Params_Get_Outlet_By_Where_InList.TOTAL_COUNT = oParams_Get_Outlet_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Outlet_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_By_Where_InList_Adv");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Criteria_InList_Adv(Params_Get_Outlet_ui_By_Criteria_InList i_Params_Get_Outlet_ui_By_Criteria_InList)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Outlet_ui_By_Criteria_InList_SP oParams_Get_Outlet_ui_By_Criteria_InList_SP = new Params_Get_Outlet_ui_By_Criteria_InList_SP();
Params_Get_Outlet_By_OUTLET_ID oParams_Get_Outlet_By_OUTLET_ID = new Params_Get_Outlet_By_OUTLET_ID();
Params_Get_Ui_By_UI_ID oParams_Get_Ui_By_UI_ID = new Params_Get_Ui_By_UI_ID();
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_Criteria_InList_Adv");}
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
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_Criteria_InList_Adv(i_Params_Get_Outlet_ui_By_Criteria_InList.DESCRIPTION,i_Params_Get_Outlet_ui_By_Criteria_InList.OUTLET_ID_LIST,i_Params_Get_Outlet_ui_By_Criteria_InList.UI_ID_LIST,i_Params_Get_Outlet_ui_By_Criteria_InList.OWNER_ID,i_Params_Get_Outlet_ui_By_Criteria_InList.START_ROW,i_Params_Get_Outlet_ui_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oOutlet_ui.My_Outlet = new Outlet();
oTools.CopyPropValues(oDBEntry.My_Outlet, oOutlet_ui.My_Outlet);
oOutlet_ui.My_Ui = new Ui();
oTools.CopyPropValues(oDBEntry.My_Ui, oOutlet_ui.My_Ui);
oOutlet_ui.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oOutlet_ui.My_User);
oList.Add(oOutlet_ui);
}
}
i_Params_Get_Outlet_ui_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Outlet_ui_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Outlet_ui_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_Criteria_InList_Adv");}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Where_InList_Adv(Params_Get_Outlet_ui_By_Where_InList i_Params_Get_Outlet_ui_By_Where_InList)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
Outlet_ui oOutlet_ui = new Outlet_ui();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Outlet_ui_By_Where_InList_SP oParams_Get_Outlet_ui_By_Where_InList_SP = new Params_Get_Outlet_ui_By_Where_InList_SP();
Params_Get_Outlet_By_OUTLET_ID oParams_Get_Outlet_By_OUTLET_ID = new Params_Get_Outlet_By_OUTLET_ID();
Params_Get_Ui_By_UI_ID oParams_Get_Ui_By_UI_ID = new Params_Get_Ui_By_UI_ID();
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Outlet_ui_By_Where_InList_Adv");}
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
List<DALC.Outlet_ui> oList_DBEntries = _AppContext.Get_Outlet_ui_By_Where_InList_Adv(i_Params_Get_Outlet_ui_By_Where_InList.DESCRIPTION,i_Params_Get_Outlet_ui_By_Where_InList.OUTLET_ID_LIST,i_Params_Get_Outlet_ui_By_Where_InList.UI_ID_LIST,i_Params_Get_Outlet_ui_By_Where_InList.OWNER_ID,i_Params_Get_Outlet_ui_By_Where_InList.START_ROW,i_Params_Get_Outlet_ui_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOutlet_ui = new Outlet_ui();
oTools.CopyPropValues(oDBEntry, oOutlet_ui);
oOutlet_ui.My_Outlet = new Outlet();
oTools.CopyPropValues(oDBEntry.My_Outlet, oOutlet_ui.My_Outlet);
oOutlet_ui.My_Ui = new Ui();
oTools.CopyPropValues(oDBEntry.My_Ui, oOutlet_ui.My_Ui);
oOutlet_ui.My_User = new User();
oTools.CopyPropValues(oDBEntry.My_User, oOutlet_ui.My_User);
oList.Add(oOutlet_ui);
}
}
i_Params_Get_Outlet_ui_By_Where_InList.TOTAL_COUNT = oParams_Get_Outlet_ui_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Outlet_ui_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Outlet_ui_By_Where_InList_Adv");}
return oList;
}
public List<Room> Get_Room_By_Criteria_InList_Adv(Params_Get_Room_By_Criteria_InList i_Params_Get_Room_By_Criteria_InList)
{
List<Room> oList = new List<Room>();
Room oRoom = new Room();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Room_By_Criteria_InList_SP oParams_Get_Room_By_Criteria_InList_SP = new Params_Get_Room_By_Criteria_InList_SP();
Params_Get_Floor_By_FLOOR_ID oParams_Get_Floor_By_FLOOR_ID = new Params_Get_Floor_By_FLOOR_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_Criteria_InList_Adv");}
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
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_Criteria_InList_Adv(i_Params_Get_Room_By_Criteria_InList.NAME,i_Params_Get_Room_By_Criteria_InList.FLOOR_ID_LIST,i_Params_Get_Room_By_Criteria_InList.OWNER_ID,i_Params_Get_Room_By_Criteria_InList.START_ROW,i_Params_Get_Room_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oRoom.My_Floor = new Floor();
oTools.CopyPropValues(oDBEntry.My_Floor, oRoom.My_Floor);
oList.Add(oRoom);
}
}
i_Params_Get_Room_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Room_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Room_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_Criteria_InList_Adv");}
return oList;
}
public List<Room> Get_Room_By_Where_InList_Adv(Params_Get_Room_By_Where_InList i_Params_Get_Room_By_Where_InList)
{
List<Room> oList = new List<Room>();
Room oRoom = new Room();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Room_By_Where_InList_SP oParams_Get_Room_By_Where_InList_SP = new Params_Get_Room_By_Where_InList_SP();
Params_Get_Floor_By_FLOOR_ID oParams_Get_Floor_By_FLOOR_ID = new Params_Get_Floor_By_FLOOR_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Room_By_Where_InList_Adv");}
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
List<DALC.Room> oList_DBEntries = _AppContext.Get_Room_By_Where_InList_Adv(i_Params_Get_Room_By_Where_InList.NAME,i_Params_Get_Room_By_Where_InList.FLOOR_ID_LIST,i_Params_Get_Room_By_Where_InList.OWNER_ID,i_Params_Get_Room_By_Where_InList.START_ROW,i_Params_Get_Room_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRoom = new Room();
oTools.CopyPropValues(oDBEntry, oRoom);
oRoom.My_Floor = new Floor();
oTools.CopyPropValues(oDBEntry.My_Floor, oRoom.My_Floor);
oList.Add(oRoom);
}
}
i_Params_Get_Room_By_Where_InList.TOTAL_COUNT = oParams_Get_Room_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Room_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Room_By_Where_InList_Adv");}
return oList;
}
}
}
