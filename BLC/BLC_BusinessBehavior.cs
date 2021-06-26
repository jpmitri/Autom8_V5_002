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
#region Reset_Room_By_Floor
public void Reset_Room_By_Floor(Floor i_Floor, List<Room> i_Room_List)
{
#region Declaration And Initialization Section.
Params_Delete_Room_By_FLOOR_ID oParams_Delete_Room_By_FLOOR_ID = new Params_Delete_Room_By_FLOOR_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Room_By_Floor");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Room
//---------------------------------
oParams_Delete_Room_By_FLOOR_ID.FLOOR_ID = i_Floor.FLOOR_ID;
Delete_Room_By_FLOOR_ID(oParams_Delete_Room_By_FLOOR_ID);
//---------------------------------
// Edit Room
//---------------------------------
Edit_Floor_WithRoom(i_Floor, i_Room_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Room_By_Floor");}
}
#endregion
#region Reset_Room_By_Floor
public void Reset_Room_By_Floor(Floor i_Floor, List<Room> i_Room_List_To_Delete,List<Room> i_Room_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Room oParams_Delete_Room = new Params_Delete_Room();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Room_By_Floor");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Room_List_To_Delete != null)
{
foreach (var oRow in i_Room_List_To_Delete)
{
oParams_Delete_Room.ROOM_ID = oRow.ROOM_ID;
Delete_Room(oParams_Delete_Room);
}
}
//---------------------------------
// Edit Room
//---------------------------------
Edit_Floor_WithRoom(i_Floor, i_Room_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Room_By_Floor");}
}
#endregion
#region Edit_Floor_With_Room(Floor i_Floor,List<Room> i_RoomList)
public void Edit_Floor_WithRoom(Floor i_Floor,List<Room> i_List_Room)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Floor_WithRoom");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Floor(i_Floor);
if (i_List_Room != null)
{
foreach(Room oRoom in i_List_Room)
{
oRoom.FLOOR_ID = i_Floor.FLOOR_ID;
Edit_Room(oRoom);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Floor_WithRoom");}
}
#endregion
#region Edit_Floor_WithRelatedData(Floor i_Floor,List<Room> i_List_Room)
public void Edit_Floor_WithRelatedData(Floor i_Floor,List<Room> i_List_Room)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Floor_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Floor(i_Floor);
if (i_List_Room != null)
{
foreach(Room oRoom in i_List_Room)
{
oRoom.FLOOR_ID = i_Floor.FLOOR_ID;
Edit_Room(oRoom);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Floor_WithRelatedData");}
}
#endregion
#region Delete_Floor_With_Children(Floor i_Floor)
public void Delete_Floor_With_Children(Floor i_Floor)
{
 #region Declaration And Initialization Section.
Params_Delete_Floor oParams_Delete_Floor = new Params_Delete_Floor();
Params_Delete_Room_By_FLOOR_ID oParams_Delete_Room_By_FLOOR_ID = new Params_Delete_Room_By_FLOOR_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Floor_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Room_By_FLOOR_ID.FLOOR_ID = i_Floor.FLOOR_ID;
Delete_Room_By_FLOOR_ID(oParams_Delete_Room_By_FLOOR_ID);
//-------------------------

//-------------------------
oParams_Delete_Floor.FLOOR_ID = i_Floor.FLOOR_ID;
Delete_Floor(oParams_Delete_Floor);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Floor_With_Children");}
}
#endregion
#region Reset_Outlet_By_Hardware_link
public void Reset_Outlet_By_Hardware_link(Hardware_link i_Hardware_link, List<Outlet> i_Outlet_List)
{
#region Declaration And Initialization Section.
Params_Delete_Outlet_By_HARDWARE_LINK_ID oParams_Delete_Outlet_By_HARDWARE_LINK_ID = new Params_Delete_Outlet_By_HARDWARE_LINK_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Outlet_By_Hardware_link");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Outlet
//---------------------------------
oParams_Delete_Outlet_By_HARDWARE_LINK_ID.HARDWARE_LINK_ID = i_Hardware_link.HARDWARE_LINK_ID;
Delete_Outlet_By_HARDWARE_LINK_ID(oParams_Delete_Outlet_By_HARDWARE_LINK_ID);
//---------------------------------
// Edit Outlet
//---------------------------------
Edit_Hardware_link_WithOutlet(i_Hardware_link, i_Outlet_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Outlet_By_Hardware_link");}
}
#endregion
#region Reset_Outlet_By_Hardware_link
public void Reset_Outlet_By_Hardware_link(Hardware_link i_Hardware_link, List<Outlet> i_Outlet_List_To_Delete,List<Outlet> i_Outlet_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Outlet oParams_Delete_Outlet = new Params_Delete_Outlet();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Outlet_By_Hardware_link");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Outlet_List_To_Delete != null)
{
foreach (var oRow in i_Outlet_List_To_Delete)
{
oParams_Delete_Outlet.OUTLET_ID = oRow.OUTLET_ID;
Delete_Outlet(oParams_Delete_Outlet);
}
}
//---------------------------------
// Edit Outlet
//---------------------------------
Edit_Hardware_link_WithOutlet(i_Hardware_link, i_Outlet_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Outlet_By_Hardware_link");}
}
#endregion
#region Edit_Hardware_link_With_Outlet(Hardware_link i_Hardware_link,List<Outlet> i_OutletList)
public void Edit_Hardware_link_WithOutlet(Hardware_link i_Hardware_link,List<Outlet> i_List_Outlet)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Hardware_link_WithOutlet");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Hardware_link(i_Hardware_link);
if (i_List_Outlet != null)
{
foreach(Outlet oOutlet in i_List_Outlet)
{
oOutlet.HARDWARE_LINK_ID = i_Hardware_link.HARDWARE_LINK_ID;
Edit_Outlet(oOutlet);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Hardware_link_WithOutlet");}
}
#endregion
#region Edit_Hardware_link_WithRelatedData(Hardware_link i_Hardware_link,List<Outlet> i_List_Outlet)
public void Edit_Hardware_link_WithRelatedData(Hardware_link i_Hardware_link,List<Outlet> i_List_Outlet)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Hardware_link_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Hardware_link(i_Hardware_link);
if (i_List_Outlet != null)
{
foreach(Outlet oOutlet in i_List_Outlet)
{
oOutlet.HARDWARE_LINK_ID = i_Hardware_link.HARDWARE_LINK_ID;
Edit_Outlet(oOutlet);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Hardware_link_WithRelatedData");}
}
#endregion
#region Delete_Hardware_link_With_Children(Hardware_link i_Hardware_link)
public void Delete_Hardware_link_With_Children(Hardware_link i_Hardware_link)
{
 #region Declaration And Initialization Section.
Params_Delete_Hardware_link oParams_Delete_Hardware_link = new Params_Delete_Hardware_link();
Params_Delete_Outlet_By_HARDWARE_LINK_ID oParams_Delete_Outlet_By_HARDWARE_LINK_ID = new Params_Delete_Outlet_By_HARDWARE_LINK_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Hardware_link_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Outlet_By_HARDWARE_LINK_ID.HARDWARE_LINK_ID = i_Hardware_link.HARDWARE_LINK_ID;
Delete_Outlet_By_HARDWARE_LINK_ID(oParams_Delete_Outlet_By_HARDWARE_LINK_ID);
//-------------------------

//-------------------------
oParams_Delete_Hardware_link.HARDWARE_LINK_ID = i_Hardware_link.HARDWARE_LINK_ID;
Delete_Hardware_link(oParams_Delete_Hardware_link);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Hardware_link_With_Children");}
}
#endregion
#region Reset_Outlet_ui_By_Outlet
public void Reset_Outlet_ui_By_Outlet(Outlet i_Outlet, List<Outlet_ui> i_Outlet_ui_List)
{
#region Declaration And Initialization Section.
Params_Delete_Outlet_ui_By_OUTLET_ID oParams_Delete_Outlet_ui_By_OUTLET_ID = new Params_Delete_Outlet_ui_By_OUTLET_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Outlet_ui_By_Outlet");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Outlet_ui
//---------------------------------
oParams_Delete_Outlet_ui_By_OUTLET_ID.OUTLET_ID = i_Outlet.OUTLET_ID;
Delete_Outlet_ui_By_OUTLET_ID(oParams_Delete_Outlet_ui_By_OUTLET_ID);
//---------------------------------
// Edit Outlet_ui
//---------------------------------
Edit_Outlet_WithOutlet_ui(i_Outlet, i_Outlet_ui_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Outlet_ui_By_Outlet");}
}
#endregion
#region Reset_Outlet_ui_By_Outlet
public void Reset_Outlet_ui_By_Outlet(Outlet i_Outlet, List<Outlet_ui> i_Outlet_ui_List_To_Delete,List<Outlet_ui> i_Outlet_ui_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Outlet_ui oParams_Delete_Outlet_ui = new Params_Delete_Outlet_ui();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Outlet_ui_By_Outlet");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Outlet_ui_List_To_Delete != null)
{
foreach (var oRow in i_Outlet_ui_List_To_Delete)
{
oParams_Delete_Outlet_ui.OUTLET_UI_ID = oRow.OUTLET_UI_ID;
Delete_Outlet_ui(oParams_Delete_Outlet_ui);
}
}
//---------------------------------
// Edit Outlet_ui
//---------------------------------
Edit_Outlet_WithOutlet_ui(i_Outlet, i_Outlet_ui_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Outlet_ui_By_Outlet");}
}
#endregion
#region Edit_Outlet_With_Outlet_ui(Outlet i_Outlet,List<Outlet_ui> i_Outlet_uiList)
public void Edit_Outlet_WithOutlet_ui(Outlet i_Outlet,List<Outlet_ui> i_List_Outlet_ui)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Outlet_WithOutlet_ui");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Outlet(i_Outlet);
if (i_List_Outlet_ui != null)
{
foreach(Outlet_ui oOutlet_ui in i_List_Outlet_ui)
{
oOutlet_ui.OUTLET_ID = i_Outlet.OUTLET_ID;
Edit_Outlet_ui(oOutlet_ui);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Outlet_WithOutlet_ui");}
}
#endregion
#region Edit_Outlet_WithRelatedData(Outlet i_Outlet,List<Outlet_ui> i_List_Outlet_ui)
public void Edit_Outlet_WithRelatedData(Outlet i_Outlet,List<Outlet_ui> i_List_Outlet_ui)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Outlet_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Outlet(i_Outlet);
if (i_List_Outlet_ui != null)
{
foreach(Outlet_ui oOutlet_ui in i_List_Outlet_ui)
{
oOutlet_ui.OUTLET_ID = i_Outlet.OUTLET_ID;
Edit_Outlet_ui(oOutlet_ui);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Outlet_WithRelatedData");}
}
#endregion
#region Delete_Outlet_With_Children(Outlet i_Outlet)
public void Delete_Outlet_With_Children(Outlet i_Outlet)
{
 #region Declaration And Initialization Section.
Params_Delete_Outlet oParams_Delete_Outlet = new Params_Delete_Outlet();
Params_Delete_Outlet_ui_By_OUTLET_ID oParams_Delete_Outlet_ui_By_OUTLET_ID = new Params_Delete_Outlet_ui_By_OUTLET_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Outlet_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Outlet_ui_By_OUTLET_ID.OUTLET_ID = i_Outlet.OUTLET_ID;
Delete_Outlet_ui_By_OUTLET_ID(oParams_Delete_Outlet_ui_By_OUTLET_ID);
//-------------------------

//-------------------------
oParams_Delete_Outlet.OUTLET_ID = i_Outlet.OUTLET_ID;
Delete_Outlet(oParams_Delete_Outlet);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Outlet_With_Children");}
}
#endregion
#region Reset_Outlet_By_Outlet_type
public void Reset_Outlet_By_Outlet_type(Outlet_type i_Outlet_type, List<Outlet> i_Outlet_List)
{
#region Declaration And Initialization Section.
Params_Delete_Outlet_By_OUTLET_TYPE_ID oParams_Delete_Outlet_By_OUTLET_TYPE_ID = new Params_Delete_Outlet_By_OUTLET_TYPE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Outlet_By_Outlet_type");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Outlet
//---------------------------------
oParams_Delete_Outlet_By_OUTLET_TYPE_ID.OUTLET_TYPE_ID = i_Outlet_type.OUTLET_TYPE_ID;
Delete_Outlet_By_OUTLET_TYPE_ID(oParams_Delete_Outlet_By_OUTLET_TYPE_ID);
//---------------------------------
// Edit Outlet
//---------------------------------
Edit_Outlet_type_WithOutlet(i_Outlet_type, i_Outlet_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Outlet_By_Outlet_type");}
}
#endregion
#region Reset_Outlet_By_Outlet_type
public void Reset_Outlet_By_Outlet_type(Outlet_type i_Outlet_type, List<Outlet> i_Outlet_List_To_Delete,List<Outlet> i_Outlet_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Outlet oParams_Delete_Outlet = new Params_Delete_Outlet();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Outlet_By_Outlet_type");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Outlet_List_To_Delete != null)
{
foreach (var oRow in i_Outlet_List_To_Delete)
{
oParams_Delete_Outlet.OUTLET_ID = oRow.OUTLET_ID;
Delete_Outlet(oParams_Delete_Outlet);
}
}
//---------------------------------
// Edit Outlet
//---------------------------------
Edit_Outlet_type_WithOutlet(i_Outlet_type, i_Outlet_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Outlet_By_Outlet_type");}
}
#endregion
#region Edit_Outlet_type_With_Outlet(Outlet_type i_Outlet_type,List<Outlet> i_OutletList)
public void Edit_Outlet_type_WithOutlet(Outlet_type i_Outlet_type,List<Outlet> i_List_Outlet)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Outlet_type_WithOutlet");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Outlet_type(i_Outlet_type);
if (i_List_Outlet != null)
{
foreach(Outlet oOutlet in i_List_Outlet)
{
oOutlet.OUTLET_TYPE_ID = i_Outlet_type.OUTLET_TYPE_ID;
Edit_Outlet(oOutlet);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Outlet_type_WithOutlet");}
}
#endregion
#region Edit_Outlet_type_WithRelatedData(Outlet_type i_Outlet_type,List<Outlet> i_List_Outlet)
public void Edit_Outlet_type_WithRelatedData(Outlet_type i_Outlet_type,List<Outlet> i_List_Outlet)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Outlet_type_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Outlet_type(i_Outlet_type);
if (i_List_Outlet != null)
{
foreach(Outlet oOutlet in i_List_Outlet)
{
oOutlet.OUTLET_TYPE_ID = i_Outlet_type.OUTLET_TYPE_ID;
Edit_Outlet(oOutlet);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Outlet_type_WithRelatedData");}
}
#endregion
#region Delete_Outlet_type_With_Children(Outlet_type i_Outlet_type)
public void Delete_Outlet_type_With_Children(Outlet_type i_Outlet_type)
{
 #region Declaration And Initialization Section.
Params_Delete_Outlet_type oParams_Delete_Outlet_type = new Params_Delete_Outlet_type();
Params_Delete_Outlet_By_OUTLET_TYPE_ID oParams_Delete_Outlet_By_OUTLET_TYPE_ID = new Params_Delete_Outlet_By_OUTLET_TYPE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Outlet_type_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Outlet_By_OUTLET_TYPE_ID.OUTLET_TYPE_ID = i_Outlet_type.OUTLET_TYPE_ID;
Delete_Outlet_By_OUTLET_TYPE_ID(oParams_Delete_Outlet_By_OUTLET_TYPE_ID);
//-------------------------

//-------------------------
oParams_Delete_Outlet_type.OUTLET_TYPE_ID = i_Outlet_type.OUTLET_TYPE_ID;
Delete_Outlet_type(oParams_Delete_Outlet_type);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Outlet_type_With_Children");}
}
#endregion
#region Reset_Hardware_link_By_Plc
public void Reset_Hardware_link_By_Plc(Plc i_Plc, List<Hardware_link> i_Hardware_link_List)
{
#region Declaration And Initialization Section.
Params_Delete_Hardware_link_By_PLC_ID oParams_Delete_Hardware_link_By_PLC_ID = new Params_Delete_Hardware_link_By_PLC_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Hardware_link_By_Plc");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Hardware_link
//---------------------------------
oParams_Delete_Hardware_link_By_PLC_ID.PLC_ID = i_Plc.PLC_ID;
Delete_Hardware_link_By_PLC_ID(oParams_Delete_Hardware_link_By_PLC_ID);
//---------------------------------
// Edit Hardware_link
//---------------------------------
Edit_Plc_WithHardware_link(i_Plc, i_Hardware_link_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Hardware_link_By_Plc");}
}
#endregion
#region Reset_Hardware_link_By_Plc
public void Reset_Hardware_link_By_Plc(Plc i_Plc, List<Hardware_link> i_Hardware_link_List_To_Delete,List<Hardware_link> i_Hardware_link_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Hardware_link oParams_Delete_Hardware_link = new Params_Delete_Hardware_link();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Hardware_link_By_Plc");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Hardware_link_List_To_Delete != null)
{
foreach (var oRow in i_Hardware_link_List_To_Delete)
{
oParams_Delete_Hardware_link.HARDWARE_LINK_ID = oRow.HARDWARE_LINK_ID;
Delete_Hardware_link(oParams_Delete_Hardware_link);
}
}
//---------------------------------
// Edit Hardware_link
//---------------------------------
Edit_Plc_WithHardware_link(i_Plc, i_Hardware_link_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Hardware_link_By_Plc");}
}
#endregion
#region Edit_Plc_With_Hardware_link(Plc i_Plc,List<Hardware_link> i_Hardware_linkList)
public void Edit_Plc_WithHardware_link(Plc i_Plc,List<Hardware_link> i_List_Hardware_link)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Plc_WithHardware_link");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Plc(i_Plc);
if (i_List_Hardware_link != null)
{
foreach(Hardware_link oHardware_link in i_List_Hardware_link)
{
oHardware_link.PLC_ID = i_Plc.PLC_ID;
Edit_Hardware_link(oHardware_link);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Plc_WithHardware_link");}
}
#endregion
#region Edit_Plc_WithRelatedData(Plc i_Plc,List<Hardware_link> i_List_Hardware_link)
public void Edit_Plc_WithRelatedData(Plc i_Plc,List<Hardware_link> i_List_Hardware_link)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Plc_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Plc(i_Plc);
if (i_List_Hardware_link != null)
{
foreach(Hardware_link oHardware_link in i_List_Hardware_link)
{
oHardware_link.PLC_ID = i_Plc.PLC_ID;
Edit_Hardware_link(oHardware_link);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Plc_WithRelatedData");}
}
#endregion
#region Delete_Plc_With_Children(Plc i_Plc)
public void Delete_Plc_With_Children(Plc i_Plc)
{
 #region Declaration And Initialization Section.
Params_Delete_Plc oParams_Delete_Plc = new Params_Delete_Plc();
Params_Delete_Hardware_link_By_PLC_ID oParams_Delete_Hardware_link_By_PLC_ID = new Params_Delete_Hardware_link_By_PLC_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Plc_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Hardware_link_By_PLC_ID.PLC_ID = i_Plc.PLC_ID;
Delete_Hardware_link_By_PLC_ID(oParams_Delete_Hardware_link_By_PLC_ID);
//-------------------------

//-------------------------
oParams_Delete_Plc.PLC_ID = i_Plc.PLC_ID;
Delete_Plc(oParams_Delete_Plc);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Plc_With_Children");}
}
#endregion
#region Reset_Outlet_By_Room
public void Reset_Outlet_By_Room(Room i_Room, List<Outlet> i_Outlet_List)
{
#region Declaration And Initialization Section.
Params_Delete_Outlet_By_ROOM_ID oParams_Delete_Outlet_By_ROOM_ID = new Params_Delete_Outlet_By_ROOM_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Outlet_By_Room");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Outlet
//---------------------------------
oParams_Delete_Outlet_By_ROOM_ID.ROOM_ID = i_Room.ROOM_ID;
Delete_Outlet_By_ROOM_ID(oParams_Delete_Outlet_By_ROOM_ID);
//---------------------------------
// Edit Outlet
//---------------------------------
Edit_Room_WithOutlet(i_Room, i_Outlet_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Outlet_By_Room");}
}
#endregion
#region Reset_Outlet_By_Room
public void Reset_Outlet_By_Room(Room i_Room, List<Outlet> i_Outlet_List_To_Delete,List<Outlet> i_Outlet_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Outlet oParams_Delete_Outlet = new Params_Delete_Outlet();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Outlet_By_Room");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Outlet_List_To_Delete != null)
{
foreach (var oRow in i_Outlet_List_To_Delete)
{
oParams_Delete_Outlet.OUTLET_ID = oRow.OUTLET_ID;
Delete_Outlet(oParams_Delete_Outlet);
}
}
//---------------------------------
// Edit Outlet
//---------------------------------
Edit_Room_WithOutlet(i_Room, i_Outlet_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Outlet_By_Room");}
}
#endregion
#region Edit_Room_With_Outlet(Room i_Room,List<Outlet> i_OutletList)
public void Edit_Room_WithOutlet(Room i_Room,List<Outlet> i_List_Outlet)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Room_WithOutlet");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Room(i_Room);
if (i_List_Outlet != null)
{
foreach(Outlet oOutlet in i_List_Outlet)
{
oOutlet.ROOM_ID = i_Room.ROOM_ID;
Edit_Outlet(oOutlet);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Room_WithOutlet");}
}
#endregion
#region Edit_Room_WithRelatedData(Room i_Room,List<Outlet> i_List_Outlet)
public void Edit_Room_WithRelatedData(Room i_Room,List<Outlet> i_List_Outlet)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Room_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Room(i_Room);
if (i_List_Outlet != null)
{
foreach(Outlet oOutlet in i_List_Outlet)
{
oOutlet.ROOM_ID = i_Room.ROOM_ID;
Edit_Outlet(oOutlet);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Room_WithRelatedData");}
}
#endregion
#region Delete_Room_With_Children(Room i_Room)
public void Delete_Room_With_Children(Room i_Room)
{
 #region Declaration And Initialization Section.
Params_Delete_Room oParams_Delete_Room = new Params_Delete_Room();
Params_Delete_Outlet_By_ROOM_ID oParams_Delete_Outlet_By_ROOM_ID = new Params_Delete_Outlet_By_ROOM_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Room_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Outlet_By_ROOM_ID.ROOM_ID = i_Room.ROOM_ID;
Delete_Outlet_By_ROOM_ID(oParams_Delete_Outlet_By_ROOM_ID);
//-------------------------

//-------------------------
oParams_Delete_Room.ROOM_ID = i_Room.ROOM_ID;
Delete_Room(oParams_Delete_Room);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Room_With_Children");}
}
#endregion
#region Reset_Outlet_ui_By_Ui
public void Reset_Outlet_ui_By_Ui(Ui i_Ui, List<Outlet_ui> i_Outlet_ui_List)
{
#region Declaration And Initialization Section.
Params_Delete_Outlet_ui_By_UI_ID oParams_Delete_Outlet_ui_By_UI_ID = new Params_Delete_Outlet_ui_By_UI_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Outlet_ui_By_Ui");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Outlet_ui
//---------------------------------
oParams_Delete_Outlet_ui_By_UI_ID.UI_ID = i_Ui.UI_ID;
Delete_Outlet_ui_By_UI_ID(oParams_Delete_Outlet_ui_By_UI_ID);
//---------------------------------
// Edit Outlet_ui
//---------------------------------
Edit_Ui_WithOutlet_ui(i_Ui, i_Outlet_ui_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Outlet_ui_By_Ui");}
}
#endregion
#region Reset_Outlet_ui_By_Ui
public void Reset_Outlet_ui_By_Ui(Ui i_Ui, List<Outlet_ui> i_Outlet_ui_List_To_Delete,List<Outlet_ui> i_Outlet_ui_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Outlet_ui oParams_Delete_Outlet_ui = new Params_Delete_Outlet_ui();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Outlet_ui_By_Ui");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Outlet_ui_List_To_Delete != null)
{
foreach (var oRow in i_Outlet_ui_List_To_Delete)
{
oParams_Delete_Outlet_ui.OUTLET_UI_ID = oRow.OUTLET_UI_ID;
Delete_Outlet_ui(oParams_Delete_Outlet_ui);
}
}
//---------------------------------
// Edit Outlet_ui
//---------------------------------
Edit_Ui_WithOutlet_ui(i_Ui, i_Outlet_ui_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Outlet_ui_By_Ui");}
}
#endregion
#region Edit_Ui_With_Outlet_ui(Ui i_Ui,List<Outlet_ui> i_Outlet_uiList)
public void Edit_Ui_WithOutlet_ui(Ui i_Ui,List<Outlet_ui> i_List_Outlet_ui)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Ui_WithOutlet_ui");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Ui(i_Ui);
if (i_List_Outlet_ui != null)
{
foreach(Outlet_ui oOutlet_ui in i_List_Outlet_ui)
{
oOutlet_ui.UI_ID = i_Ui.UI_ID;
Edit_Outlet_ui(oOutlet_ui);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Ui_WithOutlet_ui");}
}
#endregion
#region Edit_Ui_WithRelatedData(Ui i_Ui,List<Outlet_ui> i_List_Outlet_ui)
public void Edit_Ui_WithRelatedData(Ui i_Ui,List<Outlet_ui> i_List_Outlet_ui)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Ui_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Ui(i_Ui);
if (i_List_Outlet_ui != null)
{
foreach(Outlet_ui oOutlet_ui in i_List_Outlet_ui)
{
oOutlet_ui.UI_ID = i_Ui.UI_ID;
Edit_Outlet_ui(oOutlet_ui);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Ui_WithRelatedData");}
}
#endregion
#region Delete_Ui_With_Children(Ui i_Ui)
public void Delete_Ui_With_Children(Ui i_Ui)
{
 #region Declaration And Initialization Section.
Params_Delete_Ui oParams_Delete_Ui = new Params_Delete_Ui();
Params_Delete_Outlet_ui_By_UI_ID oParams_Delete_Outlet_ui_By_UI_ID = new Params_Delete_Outlet_ui_By_UI_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Ui_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Outlet_ui_By_UI_ID.UI_ID = i_Ui.UI_ID;
Delete_Outlet_ui_By_UI_ID(oParams_Delete_Outlet_ui_By_UI_ID);
//-------------------------

//-------------------------
oParams_Delete_Ui.UI_ID = i_Ui.UI_ID;
Delete_Ui(oParams_Delete_Ui);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Ui_With_Children");}
}
#endregion
}
}
