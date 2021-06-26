using System;
using System.Collections.Generic;
namespace DALC
{
#region Repositories
public partial class Floor
{
public Int32? FLOOR_ID {get;set;}
public string NAME {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Hardware_link
{
public long? HARDWARE_LINK_ID {get;set;}
public Int32? PLC_ID {get;set;}
public string PLC_ADDRESS {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Plc My_Plc {get;set;}
}
public partial class Outlet
{
public long? OUTLET_ID {get;set;}
public Int32? OUTLET_TYPE_ID {get;set;}
public long? HARDWARE_LINK_ID {get;set;}
public Int32? ROOM_ID {get;set;}
public string NAME {get;set;}
public string CURRENT_VALUE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Outlet_type My_Outlet_type {get;set;}
public Hardware_link My_Hardware_link {get;set;}
public Room My_Room {get;set;}
}
public partial class Outlet_type
{
public Int32? OUTLET_TYPE_ID {get;set;}
public string NAME {get;set;}
public Int32? MIN_VALUE {get;set;}
public Int32? MAX_VALUE {get;set;}
public bool? IS_DIGITAL {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Outlet_ui
{
public long? OUTLET_UI_ID {get;set;}
public long? OUTLET_ID {get;set;}
public long? UI_ID {get;set;}
public long? USER_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public Outlet My_Outlet {get;set;}
public Ui My_Ui {get;set;}
public User My_User {get;set;}
}
public partial class Owner
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Plc
{
public Int32? PLC_ID {get;set;}
public string LOCATION {get;set;}
public string PORT {get;set;}
public string TYPE {get;set;}
public Int32? CURRENT_INPUTS {get;set;}
public Int32? MAX_INPUTS {get;set;}
public Int32? CURRENT_OUTPUTS {get;set;}
public Int32? MAX_OUTPUTS {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Room
{
public Int32? ROOM_ID {get;set;}
public Int32? FLOOR_ID {get;set;}
public string NAME {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Floor My_Floor {get;set;}
}
public partial class Ui
{
public long? UI_ID {get;set;}
public string COLOR {get;set;}
public string OTHER {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Uploaded_file
{
public long? UPLOADED_FILE_ID {get;set;}
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
public string REL_FIELD {get;set;}
public Int32? SIZE {get;set;}
public string EXTENSION {get;set;}
public string URL {get;set;}
public string STAMP {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class User
{
public long? USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public bool? IS_ACTIVE {get;set;}
public string ENTRY_DATE {get;set;}
}
#endregion 
public partial interface IDALC
{
Floor Get_Floor_By_FLOOR_ID ( Int32? FLOOR_ID);
Hardware_link Get_Hardware_link_By_HARDWARE_LINK_ID ( long? HARDWARE_LINK_ID);
Outlet Get_Outlet_By_OUTLET_ID ( long? OUTLET_ID);
Outlet_type Get_Outlet_type_By_OUTLET_TYPE_ID ( Int32? OUTLET_TYPE_ID);
Outlet_ui Get_Outlet_ui_By_OUTLET_UI_ID ( long? OUTLET_UI_ID);
Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID);
Plc Get_Plc_By_PLC_ID ( Int32? PLC_ID);
Room Get_Room_By_ROOM_ID ( Int32? ROOM_ID);
Ui Get_Ui_By_UI_ID ( long? UI_ID);
Uploaded_file Get_Uploaded_file_By_UPLOADED_FILE_ID ( long? UPLOADED_FILE_ID);
User Get_User_By_USER_ID ( long? USER_ID);
Floor Get_Floor_By_FLOOR_ID_Adv ( Int32? FLOOR_ID);
Hardware_link Get_Hardware_link_By_HARDWARE_LINK_ID_Adv ( long? HARDWARE_LINK_ID);
Outlet Get_Outlet_By_OUTLET_ID_Adv ( long? OUTLET_ID);
Outlet_type Get_Outlet_type_By_OUTLET_TYPE_ID_Adv ( Int32? OUTLET_TYPE_ID);
Outlet_ui Get_Outlet_ui_By_OUTLET_UI_ID_Adv ( long? OUTLET_UI_ID);
Plc Get_Plc_By_PLC_ID_Adv ( Int32? PLC_ID);
Room Get_Room_By_ROOM_ID_Adv ( Int32? ROOM_ID);
Ui Get_Ui_By_UI_ID_Adv ( long? UI_ID);
User Get_User_By_USER_ID_Adv ( long? USER_ID);
List<Floor> Get_Floor_By_FLOOR_ID_List ( List<Int32?> FLOOR_ID_LIST);
List<Hardware_link> Get_Hardware_link_By_HARDWARE_LINK_ID_List ( List<long?> HARDWARE_LINK_ID_LIST);
List<Outlet> Get_Outlet_By_OUTLET_ID_List ( List<long?> OUTLET_ID_LIST);
List<Outlet_type> Get_Outlet_type_By_OUTLET_TYPE_ID_List ( List<Int32?> OUTLET_TYPE_ID_LIST);
List<Outlet_ui> Get_Outlet_ui_By_OUTLET_UI_ID_List ( List<long?> OUTLET_UI_ID_LIST);
List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST);
List<Plc> Get_Plc_By_PLC_ID_List ( List<Int32?> PLC_ID_LIST);
List<Room> Get_Room_By_ROOM_ID_List ( List<Int32?> ROOM_ID_LIST);
List<Ui> Get_Ui_By_UI_ID_List ( List<long?> UI_ID_LIST);
List<Uploaded_file> Get_Uploaded_file_By_UPLOADED_FILE_ID_List ( List<long?> UPLOADED_FILE_ID_LIST);
List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST);
List<Floor> Get_Floor_By_FLOOR_ID_List_Adv ( List<Int32?> FLOOR_ID_LIST);
List<Hardware_link> Get_Hardware_link_By_HARDWARE_LINK_ID_List_Adv ( List<long?> HARDWARE_LINK_ID_LIST);
List<Outlet> Get_Outlet_By_OUTLET_ID_List_Adv ( List<long?> OUTLET_ID_LIST);
List<Outlet_type> Get_Outlet_type_By_OUTLET_TYPE_ID_List_Adv ( List<Int32?> OUTLET_TYPE_ID_LIST);
List<Outlet_ui> Get_Outlet_ui_By_OUTLET_UI_ID_List_Adv ( List<long?> OUTLET_UI_ID_LIST);
List<Plc> Get_Plc_By_PLC_ID_List_Adv ( List<Int32?> PLC_ID_LIST);
List<Room> Get_Room_By_ROOM_ID_List_Adv ( List<Int32?> ROOM_ID_LIST);
List<Ui> Get_Ui_By_UI_ID_List_Adv ( List<long?> UI_ID_LIST);
List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST);
List<Floor> Get_Floor_By_OWNER_ID ( Int32? OWNER_ID);
List<Hardware_link> Get_Hardware_link_By_OWNER_ID ( Int32? OWNER_ID);
List<Hardware_link> Get_Hardware_link_By_PLC_ID ( Int32? PLC_ID);
List<Outlet> Get_Outlet_By_OWNER_ID ( Int32? OWNER_ID);
List<Outlet> Get_Outlet_By_ROOM_ID ( Int32? ROOM_ID);
List<Outlet> Get_Outlet_By_OUTLET_TYPE_ID ( Int32? OUTLET_TYPE_ID);
List<Outlet> Get_Outlet_By_HARDWARE_LINK_ID ( long? HARDWARE_LINK_ID);
List<Outlet_type> Get_Outlet_type_By_OWNER_ID ( Int32? OWNER_ID);
List<Outlet_ui> Get_Outlet_ui_By_OWNER_ID ( Int32? OWNER_ID);
List<Outlet_ui> Get_Outlet_ui_By_OUTLET_ID ( long? OUTLET_ID);
List<Outlet_ui> Get_Outlet_ui_By_UI_ID ( long? UI_ID);
List<Outlet_ui> Get_Outlet_ui_By_USER_ID ( long? USER_ID);
List<Plc> Get_Plc_By_OWNER_ID ( Int32? OWNER_ID);
List<Room> Get_Room_By_OWNER_ID ( Int32? OWNER_ID);
List<Room> Get_Room_By_FLOOR_ID ( Int32? FLOOR_ID);
List<Ui> Get_Ui_By_OWNER_ID ( Int32? OWNER_ID);
List<Uploaded_file> Get_Uploaded_file_By_OWNER_ID ( Int32? OWNER_ID);
List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY ( string REL_ENTITY);
List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY ( string REL_ENTITY, long? REL_KEY);
List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD ( string REL_ENTITY, long? REL_KEY, string REL_FIELD);
List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME ( string USERNAME);
List<Floor> Get_Floor_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Hardware_link> Get_Hardware_link_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Hardware_link> Get_Hardware_link_By_PLC_ID_Adv ( Int32? PLC_ID);
List<Outlet> Get_Outlet_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Outlet> Get_Outlet_By_ROOM_ID_Adv ( Int32? ROOM_ID);
List<Outlet> Get_Outlet_By_OUTLET_TYPE_ID_Adv ( Int32? OUTLET_TYPE_ID);
List<Outlet> Get_Outlet_By_HARDWARE_LINK_ID_Adv ( long? HARDWARE_LINK_ID);
List<Outlet_type> Get_Outlet_type_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Outlet_ui> Get_Outlet_ui_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Outlet_ui> Get_Outlet_ui_By_OUTLET_ID_Adv ( long? OUTLET_ID);
List<Outlet_ui> Get_Outlet_ui_By_UI_ID_Adv ( long? UI_ID);
List<Outlet_ui> Get_Outlet_ui_By_USER_ID_Adv ( long? USER_ID);
List<Plc> Get_Plc_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Room> Get_Room_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Room> Get_Room_By_FLOOR_ID_Adv ( Int32? FLOOR_ID);
List<Ui> Get_Ui_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME_Adv ( string USERNAME);
List<Hardware_link> Get_Hardware_link_By_PLC_ID_List ( List<Int32?> PLC_ID_LIST);
List<Outlet> Get_Outlet_By_ROOM_ID_List ( List<Int32?> ROOM_ID_LIST);
List<Outlet> Get_Outlet_By_OUTLET_TYPE_ID_List ( List<Int32?> OUTLET_TYPE_ID_LIST);
List<Outlet> Get_Outlet_By_HARDWARE_LINK_ID_List ( List<long?> HARDWARE_LINK_ID_LIST);
List<Outlet_ui> Get_Outlet_ui_By_OUTLET_ID_List ( List<long?> OUTLET_ID_LIST);
List<Outlet_ui> Get_Outlet_ui_By_UI_ID_List ( List<long?> UI_ID_LIST);
List<Outlet_ui> Get_Outlet_ui_By_USER_ID_List ( List<long?> USER_ID_LIST);
List<Room> Get_Room_By_FLOOR_ID_List ( List<Int32?> FLOOR_ID_LIST);
List<Hardware_link> Get_Hardware_link_By_PLC_ID_List_Adv ( List<Int32?> PLC_ID_LIST);
List<Outlet> Get_Outlet_By_ROOM_ID_List_Adv ( List<Int32?> ROOM_ID_LIST);
List<Outlet> Get_Outlet_By_OUTLET_TYPE_ID_List_Adv ( List<Int32?> OUTLET_TYPE_ID_LIST);
List<Outlet> Get_Outlet_By_HARDWARE_LINK_ID_List_Adv ( List<long?> HARDWARE_LINK_ID_LIST);
List<Outlet_ui> Get_Outlet_ui_By_OUTLET_ID_List_Adv ( List<long?> OUTLET_ID_LIST);
List<Outlet_ui> Get_Outlet_ui_By_UI_ID_List_Adv ( List<long?> UI_ID_LIST);
List<Outlet_ui> Get_Outlet_ui_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST);
List<Room> Get_Room_By_FLOOR_ID_List_Adv ( List<Int32?> FLOOR_ID_LIST);
List<Floor> Get_Floor_By_Criteria ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Floor> Get_Floor_By_Where ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Hardware_link> Get_Hardware_link_By_Criteria ( string PLC_ADDRESS, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Hardware_link> Get_Hardware_link_By_Where ( string PLC_ADDRESS, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet> Get_Outlet_By_Criteria ( string NAME, string CURRENT_VALUE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet> Get_Outlet_By_Where ( string NAME, string CURRENT_VALUE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet_type> Get_Outlet_type_By_Criteria ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet_type> Get_Outlet_type_By_Where ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet_ui> Get_Outlet_ui_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet_ui> Get_Outlet_ui_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Plc> Get_Plc_By_Criteria ( string LOCATION, string PORT, string TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Plc> Get_Plc_By_Where ( string LOCATION, string PORT, string TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Room> Get_Room_By_Criteria ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Room> Get_Room_By_Where ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Ui> Get_Ui_By_Criteria ( string COLOR, string OTHER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Ui> Get_Ui_By_Where ( string COLOR, string OTHER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Uploaded_file> Get_Uploaded_file_By_Criteria ( string REL_ENTITY, string REL_FIELD, string EXTENSION, string URL, string STAMP, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Uploaded_file> Get_Uploaded_file_By_Where ( string REL_ENTITY, string REL_FIELD, string EXTENSION, string URL, string STAMP, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Floor> Get_Floor_By_Criteria_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Floor> Get_Floor_By_Where_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Hardware_link> Get_Hardware_link_By_Criteria_Adv ( string PLC_ADDRESS, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Hardware_link> Get_Hardware_link_By_Where_Adv ( string PLC_ADDRESS, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet> Get_Outlet_By_Criteria_Adv ( string NAME, string CURRENT_VALUE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet> Get_Outlet_By_Where_Adv ( string NAME, string CURRENT_VALUE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet_type> Get_Outlet_type_By_Criteria_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet_type> Get_Outlet_type_By_Where_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet_ui> Get_Outlet_ui_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet_ui> Get_Outlet_ui_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Plc> Get_Plc_By_Criteria_Adv ( string LOCATION, string PORT, string TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Plc> Get_Plc_By_Where_Adv ( string LOCATION, string PORT, string TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Room> Get_Room_By_Criteria_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Room> Get_Room_By_Where_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Ui> Get_Ui_By_Criteria_Adv ( string COLOR, string OTHER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Ui> Get_Ui_By_Where_Adv ( string COLOR, string OTHER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Hardware_link> Get_Hardware_link_By_Criteria_InList ( string PLC_ADDRESS, List<Int32?> PLC_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Hardware_link> Get_Hardware_link_By_Where_InList ( string PLC_ADDRESS, List<Int32?> PLC_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet> Get_Outlet_By_Criteria_InList ( string NAME, string CURRENT_VALUE, List<Int32?> OUTLET_TYPE_ID_LIST, List<long?> HARDWARE_LINK_ID_LIST, List<Int32?> ROOM_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet> Get_Outlet_By_Where_InList ( string NAME, string CURRENT_VALUE, List<Int32?> OUTLET_TYPE_ID_LIST, List<long?> HARDWARE_LINK_ID_LIST, List<Int32?> ROOM_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet_ui> Get_Outlet_ui_By_Criteria_InList ( string DESCRIPTION, List<long?> OUTLET_ID_LIST, List<long?> UI_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet_ui> Get_Outlet_ui_By_Where_InList ( string DESCRIPTION, List<long?> OUTLET_ID_LIST, List<long?> UI_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Room> Get_Room_By_Criteria_InList ( string NAME, List<Int32?> FLOOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Room> Get_Room_By_Where_InList ( string NAME, List<Int32?> FLOOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Hardware_link> Get_Hardware_link_By_Criteria_InList_Adv ( string PLC_ADDRESS, List<Int32?> PLC_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Hardware_link> Get_Hardware_link_By_Where_InList_Adv ( string PLC_ADDRESS, List<Int32?> PLC_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet> Get_Outlet_By_Criteria_InList_Adv ( string NAME, string CURRENT_VALUE, List<Int32?> OUTLET_TYPE_ID_LIST, List<long?> HARDWARE_LINK_ID_LIST, List<Int32?> ROOM_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet> Get_Outlet_By_Where_InList_Adv ( string NAME, string CURRENT_VALUE, List<Int32?> OUTLET_TYPE_ID_LIST, List<long?> HARDWARE_LINK_ID_LIST, List<Int32?> ROOM_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet_ui> Get_Outlet_ui_By_Criteria_InList_Adv ( string DESCRIPTION, List<long?> OUTLET_ID_LIST, List<long?> UI_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Outlet_ui> Get_Outlet_ui_By_Where_InList_Adv ( string DESCRIPTION, List<long?> OUTLET_ID_LIST, List<long?> UI_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Room> Get_Room_By_Criteria_InList_Adv ( string NAME, List<Int32?> FLOOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Room> Get_Room_By_Where_InList_Adv ( string NAME, List<Int32?> FLOOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
void Delete_Floor ( Int32? FLOOR_ID);
void Delete_Hardware_link ( long? HARDWARE_LINK_ID);
void Delete_Outlet ( long? OUTLET_ID);
void Delete_Outlet_type ( Int32? OUTLET_TYPE_ID);
void Delete_Outlet_ui ( long? OUTLET_UI_ID);
void Delete_Owner ( Int32? OWNER_ID);
void Delete_Plc ( Int32? PLC_ID);
void Delete_Room ( Int32? ROOM_ID);
void Delete_Ui ( long? UI_ID);
void Delete_Uploaded_file ( long? UPLOADED_FILE_ID);
void Delete_User ( long? USER_ID);
void Delete_Floor_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Hardware_link_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Hardware_link_By_PLC_ID ( Int32? PLC_ID);
void Delete_Outlet_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Outlet_By_ROOM_ID ( Int32? ROOM_ID);
void Delete_Outlet_By_OUTLET_TYPE_ID ( Int32? OUTLET_TYPE_ID);
void Delete_Outlet_By_HARDWARE_LINK_ID ( long? HARDWARE_LINK_ID);
void Delete_Outlet_type_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Outlet_ui_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Outlet_ui_By_OUTLET_ID ( long? OUTLET_ID);
void Delete_Outlet_ui_By_UI_ID ( long? UI_ID);
void Delete_Outlet_ui_By_USER_ID ( long? USER_ID);
void Delete_Plc_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Room_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Room_By_FLOOR_ID ( Int32? FLOOR_ID);
void Delete_Ui_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Uploaded_file_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Uploaded_file_By_REL_ENTITY ( string REL_ENTITY);
void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY ( string REL_ENTITY, long? REL_KEY);
void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD ( string REL_ENTITY, long? REL_KEY, string REL_FIELD);
void Delete_User_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_User_By_USERNAME ( string USERNAME);
Int32? Edit_Floor ( Int32? FLOOR_ID, string NAME, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Hardware_link ( long? HARDWARE_LINK_ID, Int32? PLC_ID, string PLC_ADDRESS, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Outlet ( long? OUTLET_ID, Int32? OUTLET_TYPE_ID, long? HARDWARE_LINK_ID, Int32? ROOM_ID, string NAME, string CURRENT_VALUE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Outlet_type ( Int32? OUTLET_TYPE_ID, string NAME, Int32? MIN_VALUE, Int32? MAX_VALUE, bool? IS_DIGITAL, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Outlet_ui ( long? OUTLET_UI_ID, long? OUTLET_ID, long? UI_ID, long? USER_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION);
Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE);
Int32? Edit_Plc ( Int32? PLC_ID, string LOCATION, string PORT, string TYPE, Int32? CURRENT_INPUTS, Int32? MAX_INPUTS, Int32? CURRENT_OUTPUTS, Int32? MAX_OUTPUTS, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Room ( Int32? ROOM_ID, Int32? FLOOR_ID, string NAME, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Ui ( long? UI_ID, string COLOR, string OTHER, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_Uploaded_file ( long? UPLOADED_FILE_ID, string REL_ENTITY, long? REL_KEY, string REL_FIELD, Int32? SIZE, string EXTENSION, string URL, string STAMP, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE);
List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID);
List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE);
List<dynamic> GET_TBL_SETUP ();
List<dynamic> UP_BULK_UPSERT_FLOOR ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_HARDWARE_LINK ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_OUTLET ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_OUTLET_TYPE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_OUTLET_UI ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_PLC ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_ROOM ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_UI ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_UPLOADED_FILE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT);
List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS);
List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES);
List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME);
List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME);
List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName);
List<dynamic> UP_GET_ALL_DATA ( string USERNAME, string PASSWORD);
List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE);
List<dynamic> UP_GET_OUTLET_UI_BY_OUTLET_USER ( long? OUTLET_ID, long? USER_ID);
List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE);
List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME);
List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD);
List<dynamic> UP_UPDATE_OUTLET_UI_BY_OUTLET_USER ( long? UI_ID, long? OUTLET_ID, long? USER_ID);
}
}
