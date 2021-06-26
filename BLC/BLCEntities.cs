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
#region Params_Get_Floor_By_FLOOR_ID
public partial class Params_Get_Floor_By_FLOOR_ID
{
#region Properties
public Int32? FLOOR_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Hardware_link_By_HARDWARE_LINK_ID
public partial class Params_Get_Hardware_link_By_HARDWARE_LINK_ID
{
#region Properties
public long? HARDWARE_LINK_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Outlet_By_OUTLET_ID
public partial class Params_Get_Outlet_By_OUTLET_ID
{
#region Properties
public long? OUTLET_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Outlet_type_By_OUTLET_TYPE_ID
public partial class Params_Get_Outlet_type_By_OUTLET_TYPE_ID
{
#region Properties
public Int32? OUTLET_TYPE_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Outlet_ui_By_OUTLET_UI_ID
public partial class Params_Get_Outlet_ui_By_OUTLET_UI_ID
{
#region Properties
public long? OUTLET_UI_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Owner_By_OWNER_ID
public partial class Params_Get_Owner_By_OWNER_ID
{
#region Properties
public Int32? OWNER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Plc_By_PLC_ID
public partial class Params_Get_Plc_By_PLC_ID
{
#region Properties
public Int32? PLC_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Room_By_ROOM_ID
public partial class Params_Get_Room_By_ROOM_ID
{
#region Properties
public Int32? ROOM_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Ui_By_UI_ID
public partial class Params_Get_Ui_By_UI_ID
{
#region Properties
public long? UI_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Uploaded_file_By_UPLOADED_FILE_ID
public partial class Params_Get_Uploaded_file_By_UPLOADED_FILE_ID
{
#region Properties
public long? UPLOADED_FILE_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_User_By_USER_ID
public partial class Params_Get_User_By_USER_ID
{
#region Properties
public long? USER_ID {get;set;}

#endregion
}
#endregion
public partial class Params_Get_Floor_By_FLOOR_ID_List
{
public List<Int32?> FLOOR_ID_LIST {get;set;}
}
public partial class Params_Get_Floor_By_FLOOR_ID_List_SP
{
public string FLOOR_ID_LIST {get;set;}

}
public partial class Params_Get_Hardware_link_By_HARDWARE_LINK_ID_List
{
public List<long?> HARDWARE_LINK_ID_LIST {get;set;}
}
public partial class Params_Get_Hardware_link_By_HARDWARE_LINK_ID_List_SP
{
public string HARDWARE_LINK_ID_LIST {get;set;}

}
public partial class Params_Get_Outlet_By_OUTLET_ID_List
{
public List<long?> OUTLET_ID_LIST {get;set;}
}
public partial class Params_Get_Outlet_By_OUTLET_ID_List_SP
{
public string OUTLET_ID_LIST {get;set;}

}
public partial class Params_Get_Outlet_type_By_OUTLET_TYPE_ID_List
{
public List<Int32?> OUTLET_TYPE_ID_LIST {get;set;}
}
public partial class Params_Get_Outlet_type_By_OUTLET_TYPE_ID_List_SP
{
public string OUTLET_TYPE_ID_LIST {get;set;}

}
public partial class Params_Get_Outlet_ui_By_OUTLET_UI_ID_List
{
public List<long?> OUTLET_UI_ID_LIST {get;set;}
}
public partial class Params_Get_Outlet_ui_By_OUTLET_UI_ID_List_SP
{
public string OUTLET_UI_ID_LIST {get;set;}

}
public partial class Params_Get_Owner_By_OWNER_ID_List
{
public List<Int32?> OWNER_ID_LIST {get;set;}
}
public partial class Params_Get_Owner_By_OWNER_ID_List_SP
{
public string OWNER_ID_LIST {get;set;}

}
public partial class Params_Get_Plc_By_PLC_ID_List
{
public List<Int32?> PLC_ID_LIST {get;set;}
}
public partial class Params_Get_Plc_By_PLC_ID_List_SP
{
public string PLC_ID_LIST {get;set;}

}
public partial class Params_Get_Room_By_ROOM_ID_List
{
public List<Int32?> ROOM_ID_LIST {get;set;}
}
public partial class Params_Get_Room_By_ROOM_ID_List_SP
{
public string ROOM_ID_LIST {get;set;}

}
public partial class Params_Get_Ui_By_UI_ID_List
{
public List<long?> UI_ID_LIST {get;set;}
}
public partial class Params_Get_Ui_By_UI_ID_List_SP
{
public string UI_ID_LIST {get;set;}

}
public partial class Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List
{
public List<long?> UPLOADED_FILE_ID_LIST {get;set;}
}
public partial class Params_Get_Uploaded_file_By_UPLOADED_FILE_ID_List_SP
{
public string UPLOADED_FILE_ID_LIST {get;set;}

}
public partial class Params_Get_User_By_USER_ID_List
{
public List<long?> USER_ID_LIST {get;set;}
}
public partial class Params_Get_User_By_USER_ID_List_SP
{
public string USER_ID_LIST {get;set;}

}
public partial class Params_Get_Floor_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Hardware_link_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Hardware_link_By_PLC_ID
{
public Int32? PLC_ID {get;set;}

}
public partial class Params_Get_Outlet_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Outlet_By_ROOM_ID
{
public Int32? ROOM_ID {get;set;}

}
public partial class Params_Get_Outlet_By_OUTLET_TYPE_ID
{
public Int32? OUTLET_TYPE_ID {get;set;}

}
public partial class Params_Get_Outlet_By_HARDWARE_LINK_ID
{
public long? HARDWARE_LINK_ID {get;set;}

}
public partial class Params_Get_Outlet_type_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Outlet_ui_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Outlet_ui_By_OUTLET_ID
{
public long? OUTLET_ID {get;set;}

}
public partial class Params_Get_Outlet_ui_By_UI_ID
{
public long? UI_ID {get;set;}

}
public partial class Params_Get_Outlet_ui_By_USER_ID
{
public long? USER_ID {get;set;}

}
public partial class Params_Get_Plc_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Room_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Room_By_FLOOR_ID
{
public Int32? FLOOR_ID {get;set;}

}
public partial class Params_Get_Ui_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Uploaded_file_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Uploaded_file_By_REL_ENTITY
{
public string REL_ENTITY {get;set;}

}
public partial class Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}

}
public partial class Params_Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
public string REL_FIELD {get;set;}

}
public partial class Params_Get_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_User_By_USERNAME
{
public string USERNAME {get;set;}

}
public partial class Params_Get_Hardware_link_By_PLC_ID_List
{
public List<Int32?> PLC_ID_LIST {get;set;}

}
public partial class Params_Get_Outlet_By_ROOM_ID_List
{
public List<Int32?> ROOM_ID_LIST {get;set;}

}
public partial class Params_Get_Outlet_By_OUTLET_TYPE_ID_List
{
public List<Int32?> OUTLET_TYPE_ID_LIST {get;set;}

}
public partial class Params_Get_Outlet_By_HARDWARE_LINK_ID_List
{
public List<long?> HARDWARE_LINK_ID_LIST {get;set;}

}
public partial class Params_Get_Outlet_ui_By_OUTLET_ID_List
{
public List<long?> OUTLET_ID_LIST {get;set;}

}
public partial class Params_Get_Outlet_ui_By_UI_ID_List
{
public List<long?> UI_ID_LIST {get;set;}

}
public partial class Params_Get_Outlet_ui_By_USER_ID_List
{
public List<long?> USER_ID_LIST {get;set;}

}
public partial class Params_Get_Room_By_FLOOR_ID_List
{
public List<Int32?> FLOOR_ID_LIST {get;set;}

}
public partial class Params_Get_Floor_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Floor_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Hardware_link_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string PLC_ADDRESS {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Hardware_link_By_Where
{

public Int32? OWNER_ID {get;set;}
public string PLC_ADDRESS {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Outlet_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string CURRENT_VALUE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Outlet_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string CURRENT_VALUE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Outlet_type_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Outlet_type_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Outlet_ui_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Outlet_ui_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Plc_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string LOCATION {get;set;}
public string PORT {get;set;}
public string TYPE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Plc_By_Where
{

public Int32? OWNER_ID {get;set;}
public string LOCATION {get;set;}
public string PORT {get;set;}
public string TYPE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Room_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Room_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Ui_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string COLOR {get;set;}
public string OTHER {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Ui_By_Where
{

public Int32? OWNER_ID {get;set;}
public string COLOR {get;set;}
public string OTHER {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Uploaded_file_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string REL_ENTITY {get;set;}
public string REL_FIELD {get;set;}
public string EXTENSION {get;set;}
public string URL {get;set;}
public string STAMP {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Uploaded_file_By_Where
{

public Int32? OWNER_ID {get;set;}
public string REL_ENTITY {get;set;}
public string REL_FIELD {get;set;}
public string EXTENSION {get;set;}
public string URL {get;set;}
public string STAMP {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Where
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Hardware_link_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string PLC_ADDRESS {get;set;}
public List<Int32?> PLC_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Hardware_link_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string PLC_ADDRESS {get;set;}
public string PLC_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Hardware_link_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string PLC_ADDRESS {get;set;}
public List<Int32?> PLC_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Hardware_link_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string PLC_ADDRESS {get;set;}
public string PLC_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Outlet_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string CURRENT_VALUE {get;set;}
public List<Int32?> OUTLET_TYPE_ID_LIST {get;set;}
public List<long?> HARDWARE_LINK_ID_LIST {get;set;}
public List<Int32?> ROOM_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Outlet_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string CURRENT_VALUE {get;set;}
public string OUTLET_TYPE_ID_LIST {get;set;}
public string HARDWARE_LINK_ID_LIST {get;set;}
public string ROOM_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Outlet_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string CURRENT_VALUE {get;set;}
public List<Int32?> OUTLET_TYPE_ID_LIST {get;set;}
public List<long?> HARDWARE_LINK_ID_LIST {get;set;}
public List<Int32?> ROOM_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Outlet_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string CURRENT_VALUE {get;set;}
public string OUTLET_TYPE_ID_LIST {get;set;}
public string HARDWARE_LINK_ID_LIST {get;set;}
public string ROOM_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Outlet_ui_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> OUTLET_ID_LIST {get;set;}
public List<long?> UI_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Outlet_ui_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string OUTLET_ID_LIST {get;set;}
public string UI_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Outlet_ui_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> OUTLET_ID_LIST {get;set;}
public List<long?> UI_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Outlet_ui_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string OUTLET_ID_LIST {get;set;}
public string UI_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Room_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public List<Int32?> FLOOR_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Room_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string FLOOR_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Room_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public List<Int32?> FLOOR_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Room_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string FLOOR_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
#region Params_Delete_Floor
public partial class Params_Delete_Floor
{
#region Properties
public Int32? FLOOR_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Hardware_link
public partial class Params_Delete_Hardware_link
{
#region Properties
public long? HARDWARE_LINK_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Outlet
public partial class Params_Delete_Outlet
{
#region Properties
public long? OUTLET_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Outlet_type
public partial class Params_Delete_Outlet_type
{
#region Properties
public Int32? OUTLET_TYPE_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Outlet_ui
public partial class Params_Delete_Outlet_ui
{
#region Properties
public long? OUTLET_UI_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Owner
public partial class Params_Delete_Owner
{
#region Properties
public Int32? OWNER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Plc
public partial class Params_Delete_Plc
{
#region Properties
public Int32? PLC_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Room
public partial class Params_Delete_Room
{
#region Properties
public Int32? ROOM_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Ui
public partial class Params_Delete_Ui
{
#region Properties
public long? UI_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Uploaded_file
public partial class Params_Delete_Uploaded_file
{
#region Properties
public long? UPLOADED_FILE_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_User
public partial class Params_Delete_User
{
#region Properties
public long? USER_ID {get;set;}
#endregion
}
#endregion
public partial class Params_Delete_Floor_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Hardware_link_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Hardware_link_By_PLC_ID
{
public Int32? PLC_ID {get;set;}
}
public partial class Params_Delete_Outlet_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Outlet_By_ROOM_ID
{
public Int32? ROOM_ID {get;set;}
}
public partial class Params_Delete_Outlet_By_OUTLET_TYPE_ID
{
public Int32? OUTLET_TYPE_ID {get;set;}
}
public partial class Params_Delete_Outlet_By_HARDWARE_LINK_ID
{
public long? HARDWARE_LINK_ID {get;set;}
}
public partial class Params_Delete_Outlet_type_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Outlet_ui_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Outlet_ui_By_OUTLET_ID
{
public long? OUTLET_ID {get;set;}
}
public partial class Params_Delete_Outlet_ui_By_UI_ID
{
public long? UI_ID {get;set;}
}
public partial class Params_Delete_Outlet_ui_By_USER_ID
{
public long? USER_ID {get;set;}
}
public partial class Params_Delete_Plc_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Room_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Room_By_FLOOR_ID
{
public Int32? FLOOR_ID {get;set;}
}
public partial class Params_Delete_Ui_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_REL_ENTITY
{
public string REL_ENTITY {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
}
public partial class Params_Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD
{
public string REL_ENTITY {get;set;}
public long? REL_KEY {get;set;}
public string REL_FIELD {get;set;}
}
public partial class Params_Delete_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_User_By_USERNAME
{
public string USERNAME {get;set;}
}
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
#region Params_Edit_Floor_List
public partial class Params_Edit_Floor_List
{
#region Properties
public List<Floor> My_List_To_Edit { get; set; }
public List<Floor> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Hardware_link_List
public partial class Params_Edit_Hardware_link_List
{
#region Properties
public List<Hardware_link> My_List_To_Edit { get; set; }
public List<Hardware_link> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Outlet_List
public partial class Params_Edit_Outlet_List
{
#region Properties
public List<Outlet> My_List_To_Edit { get; set; }
public List<Outlet> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Outlet_type_List
public partial class Params_Edit_Outlet_type_List
{
#region Properties
public List<Outlet_type> My_List_To_Edit { get; set; }
public List<Outlet_type> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Outlet_ui_List
public partial class Params_Edit_Outlet_ui_List
{
#region Properties
public List<Outlet_ui> My_List_To_Edit { get; set; }
public List<Outlet_ui> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Owner_List
public partial class Params_Edit_Owner_List
{
#region Properties
public List<Owner> My_List_To_Edit { get; set; }
public List<Owner> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Plc_List
public partial class Params_Edit_Plc_List
{
#region Properties
public List<Plc> My_List_To_Edit { get; set; }
public List<Plc> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Room_List
public partial class Params_Edit_Room_List
{
#region Properties
public List<Room> My_List_To_Edit { get; set; }
public List<Room> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Ui_List
public partial class Params_Edit_Ui_List
{
#region Properties
public List<Ui> My_List_To_Edit { get; set; }
public List<Ui> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Uploaded_file_List
public partial class Params_Edit_Uploaded_file_List
{
#region Properties
public List<Uploaded_file> My_List_To_Edit { get; set; }
public List<Uploaded_file> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_User_List
public partial class Params_Edit_User_List
{
#region Properties
public List<User> My_List_To_Edit { get; set; }
public List<User> My_List_To_Delete { get; set; }
#endregion
}
#endregion
}
