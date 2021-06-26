using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Dynamic;
namespace DALC
{
public partial class MSSQL_DALC : IDALC
{
public Floor Get_Floor_By_FLOOR_ID ( Int32? FLOOR_ID)
{
Floor o = new Floor();
dynamic p = new ExpandoObject();
p.FLOOR_ID = FLOOR_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_FLOOR_BY_FLOOR_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Hardware_link Get_Hardware_link_By_HARDWARE_LINK_ID ( long? HARDWARE_LINK_ID)
{
Hardware_link o = new Hardware_link();
dynamic p = new ExpandoObject();
p.HARDWARE_LINK_ID = HARDWARE_LINK_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_HARDWARE_LINK_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Outlet Get_Outlet_By_OUTLET_ID ( long? OUTLET_ID)
{
Outlet o = new Outlet();
dynamic p = new ExpandoObject();
p.OUTLET_ID = OUTLET_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_OUTLET_BY_OUTLET_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Outlet_type Get_Outlet_type_By_OUTLET_TYPE_ID ( Int32? OUTLET_TYPE_ID)
{
Outlet_type o = new Outlet_type();
dynamic p = new ExpandoObject();
p.OUTLET_TYPE_ID = OUTLET_TYPE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_OUTLET_TYPE_BY_OUTLET_TYPE_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Outlet_ui Get_Outlet_ui_By_OUTLET_UI_ID ( long? OUTLET_UI_ID)
{
Outlet_ui o = new Outlet_ui();
dynamic p = new ExpandoObject();
p.OUTLET_UI_ID = OUTLET_UI_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_OUTLET_UI_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID)
{
Owner o = new Owner();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Plc Get_Plc_By_PLC_ID ( Int32? PLC_ID)
{
Plc o = new Plc();
dynamic p = new ExpandoObject();
p.PLC_ID = PLC_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PLC_BY_PLC_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Room Get_Room_By_ROOM_ID ( Int32? ROOM_ID)
{
Room o = new Room();
dynamic p = new ExpandoObject();
p.ROOM_ID = ROOM_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ROOM_BY_ROOM_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Ui Get_Ui_By_UI_ID ( long? UI_ID)
{
Ui o = new Ui();
dynamic p = new ExpandoObject();
p.UI_ID = UI_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_UI_BY_UI_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Uploaded_file Get_Uploaded_file_By_UPLOADED_FILE_ID ( long? UPLOADED_FILE_ID)
{
Uploaded_file o = new Uploaded_file();
dynamic p = new ExpandoObject();
p.UPLOADED_FILE_ID = UPLOADED_FILE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_UPLOADED_FILE_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public User Get_User_By_USER_ID ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Floor Get_Floor_By_FLOOR_ID_Adv ( Int32? FLOOR_ID)
{
Floor o = new Floor();
dynamic p = new ExpandoObject();
p.FLOOR_ID = FLOOR_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_FLOOR_BY_FLOOR_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Hardware_link Get_Hardware_link_By_HARDWARE_LINK_ID_Adv ( long? HARDWARE_LINK_ID)
{
Hardware_link o = new Hardware_link();
dynamic p = new ExpandoObject();
p.HARDWARE_LINK_ID = HARDWARE_LINK_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_HARDWARE_LINK_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Plc = new Plc();
o.My_Plc.PLC_ID = GV<Int32>(R["T_PLC_PLC_ID"]);o.My_Plc.LOCATION = GV<String>(R["T_PLC_LOCATION"]);o.My_Plc.PORT = GV<String>(R["T_PLC_PORT"]);o.My_Plc.TYPE = GV<String>(R["T_PLC_TYPE"]);o.My_Plc.CURRENT_INPUTS = GV<Int32>(R["T_PLC_CURRENT_INPUTS"]);o.My_Plc.MAX_INPUTS = GV<Int32>(R["T_PLC_MAX_INPUTS"]);o.My_Plc.CURRENT_OUTPUTS = GV<Int32>(R["T_PLC_CURRENT_OUTPUTS"]);o.My_Plc.MAX_OUTPUTS = GV<Int32>(R["T_PLC_MAX_OUTPUTS"]);o.My_Plc.ENTRY_USER_ID = GV<Int64>(R["T_PLC_ENTRY_USER_ID"]);o.My_Plc.ENTRY_DATE = GV<String>(R["T_PLC_ENTRY_DATE"]);o.My_Plc.OWNER_ID = GV<Int32>(R["T_PLC_OWNER_ID"]);
}
return o;
}
public Outlet Get_Outlet_By_OUTLET_ID_Adv ( long? OUTLET_ID)
{
Outlet o = new Outlet();
dynamic p = new ExpandoObject();
p.OUTLET_ID = OUTLET_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_OUTLET_BY_OUTLET_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Outlet_type = new Outlet_type();
o.My_Outlet_type.OUTLET_TYPE_ID = GV<Int32>(R["T_OUTLET_TYPE_OUTLET_TYPE_ID"]);o.My_Outlet_type.NAME = GV<String>(R["T_OUTLET_TYPE_NAME"]);o.My_Outlet_type.MIN_VALUE = GV<Int32>(R["T_OUTLET_TYPE_MIN_VALUE"]);o.My_Outlet_type.MAX_VALUE = GV<Int32>(R["T_OUTLET_TYPE_MAX_VALUE"]);o.My_Outlet_type.IS_DIGITAL = GV<Boolean>(R["T_OUTLET_TYPE_IS_DIGITAL"]);o.My_Outlet_type.ENTRY_USER_ID = GV<Int64>(R["T_OUTLET_TYPE_ENTRY_USER_ID"]);o.My_Outlet_type.ENTRY_DATE = GV<String>(R["T_OUTLET_TYPE_ENTRY_DATE"]);o.My_Outlet_type.OWNER_ID = GV<Int32>(R["T_OUTLET_TYPE_OWNER_ID"]);
o.My_Hardware_link = new Hardware_link();
o.My_Hardware_link.HARDWARE_LINK_ID = GV<Int64>(R["T_HARDWARE_LINK_HARDWARE_LINK_ID"]);o.My_Hardware_link.PLC_ID = GV<Int32>(R["T_HARDWARE_LINK_PLC_ID"]);o.My_Hardware_link.PLC_ADDRESS = GV<String>(R["T_HARDWARE_LINK_PLC_ADDRESS"]);o.My_Hardware_link.ENTRY_USER_ID = GV<Int64>(R["T_HARDWARE_LINK_ENTRY_USER_ID"]);o.My_Hardware_link.ENTRY_DATE = GV<String>(R["T_HARDWARE_LINK_ENTRY_DATE"]);o.My_Hardware_link.OWNER_ID = GV<Int32>(R["T_HARDWARE_LINK_OWNER_ID"]);
o.My_Room = new Room();
o.My_Room.ROOM_ID = GV<Int32>(R["T_ROOM_ROOM_ID"]);o.My_Room.FLOOR_ID = GV<Int32>(R["T_ROOM_FLOOR_ID"]);o.My_Room.NAME = GV<String>(R["T_ROOM_NAME"]);o.My_Room.ENTRY_USER_ID = GV<Int64>(R["T_ROOM_ENTRY_USER_ID"]);o.My_Room.ENTRY_DATE = GV<String>(R["T_ROOM_ENTRY_DATE"]);o.My_Room.OWNER_ID = GV<Int32>(R["T_ROOM_OWNER_ID"]);
}
return o;
}
public Outlet_type Get_Outlet_type_By_OUTLET_TYPE_ID_Adv ( Int32? OUTLET_TYPE_ID)
{
Outlet_type o = new Outlet_type();
dynamic p = new ExpandoObject();
p.OUTLET_TYPE_ID = OUTLET_TYPE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_OUTLET_TYPE_BY_OUTLET_TYPE_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Outlet_ui Get_Outlet_ui_By_OUTLET_UI_ID_Adv ( long? OUTLET_UI_ID)
{
Outlet_ui o = new Outlet_ui();
dynamic p = new ExpandoObject();
p.OUTLET_UI_ID = OUTLET_UI_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_OUTLET_UI_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Outlet = new Outlet();
o.My_Outlet.OUTLET_ID = GV<Int64>(R["T_OUTLET_OUTLET_ID"]);o.My_Outlet.OUTLET_TYPE_ID = GV<Int32>(R["T_OUTLET_OUTLET_TYPE_ID"]);o.My_Outlet.HARDWARE_LINK_ID = GV<Int64>(R["T_OUTLET_HARDWARE_LINK_ID"]);o.My_Outlet.ROOM_ID = GV<Int32>(R["T_OUTLET_ROOM_ID"]);o.My_Outlet.NAME = GV<String>(R["T_OUTLET_NAME"]);o.My_Outlet.CURRENT_VALUE = GV<String>(R["T_OUTLET_CURRENT_VALUE"]);o.My_Outlet.ENTRY_USER_ID = GV<Int64>(R["T_OUTLET_ENTRY_USER_ID"]);o.My_Outlet.ENTRY_DATE = GV<String>(R["T_OUTLET_ENTRY_DATE"]);o.My_Outlet.OWNER_ID = GV<Int32>(R["T_OUTLET_OWNER_ID"]);
o.My_Ui = new Ui();
o.My_Ui.UI_ID = GV<Int64>(R["T_UI_UI_ID"]);o.My_Ui.COLOR = GV<String>(R["T_UI_COLOR"]);o.My_Ui.OTHER = GV<String>(R["T_UI_OTHER"]);o.My_Ui.ENTRY_USER_ID = GV<Int64>(R["T_UI_ENTRY_USER_ID"]);o.My_Ui.ENTRY_DATE = GV<String>(R["T_UI_ENTRY_DATE"]);o.My_Ui.OWNER_ID = GV<Int32>(R["T_UI_OWNER_ID"]);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(R["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(R["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(R["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(R["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(R["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(R["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(R["T_USER_ENTRY_DATE"]);
}
return o;
}
public Plc Get_Plc_By_PLC_ID_Adv ( Int32? PLC_ID)
{
Plc o = new Plc();
dynamic p = new ExpandoObject();
p.PLC_ID = PLC_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PLC_BY_PLC_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Room Get_Room_By_ROOM_ID_Adv ( Int32? ROOM_ID)
{
Room o = new Room();
dynamic p = new ExpandoObject();
p.ROOM_ID = ROOM_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ROOM_BY_ROOM_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Floor = new Floor();
o.My_Floor.FLOOR_ID = GV<Int32>(R["T_FLOOR_FLOOR_ID"]);o.My_Floor.NAME = GV<String>(R["T_FLOOR_NAME"]);o.My_Floor.ENTRY_USER_ID = GV<Int64>(R["T_FLOOR_ENTRY_USER_ID"]);o.My_Floor.ENTRY_DATE = GV<String>(R["T_FLOOR_ENTRY_DATE"]);o.My_Floor.OWNER_ID = GV<Int32>(R["T_FLOOR_OWNER_ID"]);
}
return o;
}
public Ui Get_Ui_By_UI_ID_Adv ( long? UI_ID)
{
Ui o = new Ui();
dynamic p = new ExpandoObject();
p.UI_ID = UI_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_UI_BY_UI_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public User Get_User_By_USER_ID_Adv ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public List<Floor> Get_Floor_By_FLOOR_ID_List ( List<Int32?> FLOOR_ID_LIST)
{
List<Floor> oList = new List<Floor>();
dynamic p = new ExpandoObject();
p.FLOOR_ID_LIST = string.Join(",", FLOOR_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FLOOR_BY_FLOOR_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Floor o = new Floor();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_HARDWARE_LINK_ID_List ( List<long?> HARDWARE_LINK_ID_LIST)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.HARDWARE_LINK_ID_LIST = string.Join(",", HARDWARE_LINK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_HARDWARE_LINK_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_OUTLET_ID_List ( List<long?> OUTLET_ID_LIST)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.OUTLET_ID_LIST = string.Join(",", OUTLET_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_OUTLET_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_OUTLET_TYPE_ID_List ( List<Int32?> OUTLET_TYPE_ID_LIST)
{
List<Outlet_type> oList = new List<Outlet_type>();
dynamic p = new ExpandoObject();
p.OUTLET_TYPE_ID_LIST = string.Join(",", OUTLET_TYPE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_TYPE_BY_OUTLET_TYPE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Outlet_type o = new Outlet_type();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OUTLET_UI_ID_List ( List<long?> OUTLET_UI_ID_LIST)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.OUTLET_UI_ID_LIST = string.Join(",", OUTLET_UI_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_OUTLET_UI_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.OWNER_ID_LIST = string.Join(",", OWNER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Plc> Get_Plc_By_PLC_ID_List ( List<Int32?> PLC_ID_LIST)
{
List<Plc> oList = new List<Plc>();
dynamic p = new ExpandoObject();
p.PLC_ID_LIST = string.Join(",", PLC_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PLC_BY_PLC_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Plc o = new Plc();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Room> Get_Room_By_ROOM_ID_List ( List<Int32?> ROOM_ID_LIST)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.ROOM_ID_LIST = string.Join(",", ROOM_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_ROOM_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Ui> Get_Ui_By_UI_ID_List ( List<long?> UI_ID_LIST)
{
List<Ui> oList = new List<Ui>();
dynamic p = new ExpandoObject();
p.UI_ID_LIST = string.Join(",", UI_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UI_BY_UI_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Ui o = new Ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_UPLOADED_FILE_ID_List ( List<long?> UPLOADED_FILE_ID_LIST)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.UPLOADED_FILE_ID_LIST = string.Join(",", UPLOADED_FILE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_UPLOADED_FILE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Floor> Get_Floor_By_FLOOR_ID_List_Adv ( List<Int32?> FLOOR_ID_LIST)
{
List<Floor> oList = new List<Floor>();
dynamic p = new ExpandoObject();
p.FLOOR_ID_LIST = string.Join(",", FLOOR_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FLOOR_BY_FLOOR_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Floor o = new Floor();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_HARDWARE_LINK_ID_List_Adv ( List<long?> HARDWARE_LINK_ID_LIST)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.HARDWARE_LINK_ID_LIST = string.Join(",", HARDWARE_LINK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_HARDWARE_LINK_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Plc = new Plc();
o.My_Plc.PLC_ID = GV<Int32>(X["T_PLC_PLC_ID"]);o.My_Plc.LOCATION = GV<String>(X["T_PLC_LOCATION"]);o.My_Plc.PORT = GV<String>(X["T_PLC_PORT"]);o.My_Plc.TYPE = GV<String>(X["T_PLC_TYPE"]);o.My_Plc.CURRENT_INPUTS = GV<Int32>(X["T_PLC_CURRENT_INPUTS"]);o.My_Plc.MAX_INPUTS = GV<Int32>(X["T_PLC_MAX_INPUTS"]);o.My_Plc.CURRENT_OUTPUTS = GV<Int32>(X["T_PLC_CURRENT_OUTPUTS"]);o.My_Plc.MAX_OUTPUTS = GV<Int32>(X["T_PLC_MAX_OUTPUTS"]);o.My_Plc.ENTRY_USER_ID = GV<Int64>(X["T_PLC_ENTRY_USER_ID"]);o.My_Plc.ENTRY_DATE = GV<String>(X["T_PLC_ENTRY_DATE"]);o.My_Plc.OWNER_ID = GV<Int32>(X["T_PLC_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_OUTLET_ID_List_Adv ( List<long?> OUTLET_ID_LIST)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.OUTLET_ID_LIST = string.Join(",", OUTLET_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_OUTLET_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet_type = new Outlet_type();
o.My_Outlet_type.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_TYPE_OUTLET_TYPE_ID"]);o.My_Outlet_type.NAME = GV<String>(X["T_OUTLET_TYPE_NAME"]);o.My_Outlet_type.MIN_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MIN_VALUE"]);o.My_Outlet_type.MAX_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MAX_VALUE"]);o.My_Outlet_type.IS_DIGITAL = GV<Boolean>(X["T_OUTLET_TYPE_IS_DIGITAL"]);o.My_Outlet_type.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_TYPE_ENTRY_USER_ID"]);o.My_Outlet_type.ENTRY_DATE = GV<String>(X["T_OUTLET_TYPE_ENTRY_DATE"]);o.My_Outlet_type.OWNER_ID = GV<Int32>(X["T_OUTLET_TYPE_OWNER_ID"]);
o.My_Hardware_link = new Hardware_link();
o.My_Hardware_link.HARDWARE_LINK_ID = GV<Int64>(X["T_HARDWARE_LINK_HARDWARE_LINK_ID"]);o.My_Hardware_link.PLC_ID = GV<Int32>(X["T_HARDWARE_LINK_PLC_ID"]);o.My_Hardware_link.PLC_ADDRESS = GV<String>(X["T_HARDWARE_LINK_PLC_ADDRESS"]);o.My_Hardware_link.ENTRY_USER_ID = GV<Int64>(X["T_HARDWARE_LINK_ENTRY_USER_ID"]);o.My_Hardware_link.ENTRY_DATE = GV<String>(X["T_HARDWARE_LINK_ENTRY_DATE"]);o.My_Hardware_link.OWNER_ID = GV<Int32>(X["T_HARDWARE_LINK_OWNER_ID"]);
o.My_Room = new Room();
o.My_Room.ROOM_ID = GV<Int32>(X["T_ROOM_ROOM_ID"]);o.My_Room.FLOOR_ID = GV<Int32>(X["T_ROOM_FLOOR_ID"]);o.My_Room.NAME = GV<String>(X["T_ROOM_NAME"]);o.My_Room.ENTRY_USER_ID = GV<Int64>(X["T_ROOM_ENTRY_USER_ID"]);o.My_Room.ENTRY_DATE = GV<String>(X["T_ROOM_ENTRY_DATE"]);o.My_Room.OWNER_ID = GV<Int32>(X["T_ROOM_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_OUTLET_TYPE_ID_List_Adv ( List<Int32?> OUTLET_TYPE_ID_LIST)
{
List<Outlet_type> oList = new List<Outlet_type>();
dynamic p = new ExpandoObject();
p.OUTLET_TYPE_ID_LIST = string.Join(",", OUTLET_TYPE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_TYPE_BY_OUTLET_TYPE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_type o = new Outlet_type();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OUTLET_UI_ID_List_Adv ( List<long?> OUTLET_UI_ID_LIST)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.OUTLET_UI_ID_LIST = string.Join(",", OUTLET_UI_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_OUTLET_UI_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet = new Outlet();
o.My_Outlet.OUTLET_ID = GV<Int64>(X["T_OUTLET_OUTLET_ID"]);o.My_Outlet.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_OUTLET_TYPE_ID"]);o.My_Outlet.HARDWARE_LINK_ID = GV<Int64>(X["T_OUTLET_HARDWARE_LINK_ID"]);o.My_Outlet.ROOM_ID = GV<Int32>(X["T_OUTLET_ROOM_ID"]);o.My_Outlet.NAME = GV<String>(X["T_OUTLET_NAME"]);o.My_Outlet.CURRENT_VALUE = GV<String>(X["T_OUTLET_CURRENT_VALUE"]);o.My_Outlet.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_ENTRY_USER_ID"]);o.My_Outlet.ENTRY_DATE = GV<String>(X["T_OUTLET_ENTRY_DATE"]);o.My_Outlet.OWNER_ID = GV<Int32>(X["T_OUTLET_OWNER_ID"]);
o.My_Ui = new Ui();
o.My_Ui.UI_ID = GV<Int64>(X["T_UI_UI_ID"]);o.My_Ui.COLOR = GV<String>(X["T_UI_COLOR"]);o.My_Ui.OTHER = GV<String>(X["T_UI_OTHER"]);o.My_Ui.ENTRY_USER_ID = GV<Int64>(X["T_UI_ENTRY_USER_ID"]);o.My_Ui.ENTRY_DATE = GV<String>(X["T_UI_ENTRY_DATE"]);o.My_Ui.OWNER_ID = GV<Int32>(X["T_UI_OWNER_ID"]);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Plc> Get_Plc_By_PLC_ID_List_Adv ( List<Int32?> PLC_ID_LIST)
{
List<Plc> oList = new List<Plc>();
dynamic p = new ExpandoObject();
p.PLC_ID_LIST = string.Join(",", PLC_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PLC_BY_PLC_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Plc o = new Plc();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Room> Get_Room_By_ROOM_ID_List_Adv ( List<Int32?> ROOM_ID_LIST)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.ROOM_ID_LIST = string.Join(",", ROOM_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_ROOM_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Floor = new Floor();
o.My_Floor.FLOOR_ID = GV<Int32>(X["T_FLOOR_FLOOR_ID"]);o.My_Floor.NAME = GV<String>(X["T_FLOOR_NAME"]);o.My_Floor.ENTRY_USER_ID = GV<Int64>(X["T_FLOOR_ENTRY_USER_ID"]);o.My_Floor.ENTRY_DATE = GV<String>(X["T_FLOOR_ENTRY_DATE"]);o.My_Floor.OWNER_ID = GV<Int32>(X["T_FLOOR_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Ui> Get_Ui_By_UI_ID_List_Adv ( List<long?> UI_ID_LIST)
{
List<Ui> oList = new List<Ui>();
dynamic p = new ExpandoObject();
p.UI_ID_LIST = string.Join(",", UI_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UI_BY_UI_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Ui o = new Ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Floor> Get_Floor_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Floor> oList = new List<Floor>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FLOOR_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Floor o = new Floor();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_PLC_ID ( Int32? PLC_ID)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.PLC_ID = PLC_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_PLC_ID", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_ROOM_ID ( Int32? ROOM_ID)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.ROOM_ID = ROOM_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_ROOM_ID", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_OUTLET_TYPE_ID ( Int32? OUTLET_TYPE_ID)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.OUTLET_TYPE_ID = OUTLET_TYPE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_OUTLET_TYPE_ID", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_HARDWARE_LINK_ID ( long? HARDWARE_LINK_ID)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.HARDWARE_LINK_ID = HARDWARE_LINK_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_HARDWARE_LINK_ID", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Outlet_type> oList = new List<Outlet_type>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_TYPE_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Outlet_type o = new Outlet_type();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OUTLET_ID ( long? OUTLET_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.OUTLET_ID = OUTLET_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_OUTLET_ID", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_UI_ID ( long? UI_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.UI_ID = UI_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_UI_ID", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_USER_ID ( long? USER_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_USER_ID", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Plc> Get_Plc_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Plc> oList = new List<Plc>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PLC_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Plc o = new Plc();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Room> Get_Room_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Room> Get_Room_By_FLOOR_ID ( Int32? FLOOR_ID)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.FLOOR_ID = FLOOR_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_FLOOR_ID", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Ui> Get_Ui_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Ui> oList = new List<Ui>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UI_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Ui o = new Ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY ( string REL_ENTITY)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.REL_ENTITY = REL_ENTITY;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_REL_ENTITY", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY ( string REL_ENTITY, long? REL_KEY)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.REL_ENTITY = REL_ENTITY; p.REL_KEY = REL_KEY;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_REL_ENTITY_REL_KEY", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD ( string REL_ENTITY, long? REL_KEY, string REL_FIELD)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.REL_ENTITY = REL_ENTITY; p.REL_KEY = REL_KEY; p.REL_FIELD = REL_FIELD;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_REL_ENTITY_REL_KEY_REL_FIELD", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Floor> Get_Floor_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Floor> oList = new List<Floor>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FLOOR_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Floor o = new Floor();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Plc = new Plc();
o.My_Plc.PLC_ID = GV<Int32>(X["T_PLC_PLC_ID"]);o.My_Plc.LOCATION = GV<String>(X["T_PLC_LOCATION"]);o.My_Plc.PORT = GV<String>(X["T_PLC_PORT"]);o.My_Plc.TYPE = GV<String>(X["T_PLC_TYPE"]);o.My_Plc.CURRENT_INPUTS = GV<Int32>(X["T_PLC_CURRENT_INPUTS"]);o.My_Plc.MAX_INPUTS = GV<Int32>(X["T_PLC_MAX_INPUTS"]);o.My_Plc.CURRENT_OUTPUTS = GV<Int32>(X["T_PLC_CURRENT_OUTPUTS"]);o.My_Plc.MAX_OUTPUTS = GV<Int32>(X["T_PLC_MAX_OUTPUTS"]);o.My_Plc.ENTRY_USER_ID = GV<Int64>(X["T_PLC_ENTRY_USER_ID"]);o.My_Plc.ENTRY_DATE = GV<String>(X["T_PLC_ENTRY_DATE"]);o.My_Plc.OWNER_ID = GV<Int32>(X["T_PLC_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_PLC_ID_Adv ( Int32? PLC_ID)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.PLC_ID = PLC_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_PLC_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Plc = new Plc();
o.My_Plc.PLC_ID = GV<Int32>(X["T_PLC_PLC_ID"]);o.My_Plc.LOCATION = GV<String>(X["T_PLC_LOCATION"]);o.My_Plc.PORT = GV<String>(X["T_PLC_PORT"]);o.My_Plc.TYPE = GV<String>(X["T_PLC_TYPE"]);o.My_Plc.CURRENT_INPUTS = GV<Int32>(X["T_PLC_CURRENT_INPUTS"]);o.My_Plc.MAX_INPUTS = GV<Int32>(X["T_PLC_MAX_INPUTS"]);o.My_Plc.CURRENT_OUTPUTS = GV<Int32>(X["T_PLC_CURRENT_OUTPUTS"]);o.My_Plc.MAX_OUTPUTS = GV<Int32>(X["T_PLC_MAX_OUTPUTS"]);o.My_Plc.ENTRY_USER_ID = GV<Int64>(X["T_PLC_ENTRY_USER_ID"]);o.My_Plc.ENTRY_DATE = GV<String>(X["T_PLC_ENTRY_DATE"]);o.My_Plc.OWNER_ID = GV<Int32>(X["T_PLC_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet_type = new Outlet_type();
o.My_Outlet_type.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_TYPE_OUTLET_TYPE_ID"]);o.My_Outlet_type.NAME = GV<String>(X["T_OUTLET_TYPE_NAME"]);o.My_Outlet_type.MIN_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MIN_VALUE"]);o.My_Outlet_type.MAX_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MAX_VALUE"]);o.My_Outlet_type.IS_DIGITAL = GV<Boolean>(X["T_OUTLET_TYPE_IS_DIGITAL"]);o.My_Outlet_type.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_TYPE_ENTRY_USER_ID"]);o.My_Outlet_type.ENTRY_DATE = GV<String>(X["T_OUTLET_TYPE_ENTRY_DATE"]);o.My_Outlet_type.OWNER_ID = GV<Int32>(X["T_OUTLET_TYPE_OWNER_ID"]);
o.My_Hardware_link = new Hardware_link();
o.My_Hardware_link.HARDWARE_LINK_ID = GV<Int64>(X["T_HARDWARE_LINK_HARDWARE_LINK_ID"]);o.My_Hardware_link.PLC_ID = GV<Int32>(X["T_HARDWARE_LINK_PLC_ID"]);o.My_Hardware_link.PLC_ADDRESS = GV<String>(X["T_HARDWARE_LINK_PLC_ADDRESS"]);o.My_Hardware_link.ENTRY_USER_ID = GV<Int64>(X["T_HARDWARE_LINK_ENTRY_USER_ID"]);o.My_Hardware_link.ENTRY_DATE = GV<String>(X["T_HARDWARE_LINK_ENTRY_DATE"]);o.My_Hardware_link.OWNER_ID = GV<Int32>(X["T_HARDWARE_LINK_OWNER_ID"]);
o.My_Room = new Room();
o.My_Room.ROOM_ID = GV<Int32>(X["T_ROOM_ROOM_ID"]);o.My_Room.FLOOR_ID = GV<Int32>(X["T_ROOM_FLOOR_ID"]);o.My_Room.NAME = GV<String>(X["T_ROOM_NAME"]);o.My_Room.ENTRY_USER_ID = GV<Int64>(X["T_ROOM_ENTRY_USER_ID"]);o.My_Room.ENTRY_DATE = GV<String>(X["T_ROOM_ENTRY_DATE"]);o.My_Room.OWNER_ID = GV<Int32>(X["T_ROOM_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_ROOM_ID_Adv ( Int32? ROOM_ID)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.ROOM_ID = ROOM_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_ROOM_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet_type = new Outlet_type();
o.My_Outlet_type.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_TYPE_OUTLET_TYPE_ID"]);o.My_Outlet_type.NAME = GV<String>(X["T_OUTLET_TYPE_NAME"]);o.My_Outlet_type.MIN_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MIN_VALUE"]);o.My_Outlet_type.MAX_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MAX_VALUE"]);o.My_Outlet_type.IS_DIGITAL = GV<Boolean>(X["T_OUTLET_TYPE_IS_DIGITAL"]);o.My_Outlet_type.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_TYPE_ENTRY_USER_ID"]);o.My_Outlet_type.ENTRY_DATE = GV<String>(X["T_OUTLET_TYPE_ENTRY_DATE"]);o.My_Outlet_type.OWNER_ID = GV<Int32>(X["T_OUTLET_TYPE_OWNER_ID"]);
o.My_Hardware_link = new Hardware_link();
o.My_Hardware_link.HARDWARE_LINK_ID = GV<Int64>(X["T_HARDWARE_LINK_HARDWARE_LINK_ID"]);o.My_Hardware_link.PLC_ID = GV<Int32>(X["T_HARDWARE_LINK_PLC_ID"]);o.My_Hardware_link.PLC_ADDRESS = GV<String>(X["T_HARDWARE_LINK_PLC_ADDRESS"]);o.My_Hardware_link.ENTRY_USER_ID = GV<Int64>(X["T_HARDWARE_LINK_ENTRY_USER_ID"]);o.My_Hardware_link.ENTRY_DATE = GV<String>(X["T_HARDWARE_LINK_ENTRY_DATE"]);o.My_Hardware_link.OWNER_ID = GV<Int32>(X["T_HARDWARE_LINK_OWNER_ID"]);
o.My_Room = new Room();
o.My_Room.ROOM_ID = GV<Int32>(X["T_ROOM_ROOM_ID"]);o.My_Room.FLOOR_ID = GV<Int32>(X["T_ROOM_FLOOR_ID"]);o.My_Room.NAME = GV<String>(X["T_ROOM_NAME"]);o.My_Room.ENTRY_USER_ID = GV<Int64>(X["T_ROOM_ENTRY_USER_ID"]);o.My_Room.ENTRY_DATE = GV<String>(X["T_ROOM_ENTRY_DATE"]);o.My_Room.OWNER_ID = GV<Int32>(X["T_ROOM_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_OUTLET_TYPE_ID_Adv ( Int32? OUTLET_TYPE_ID)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.OUTLET_TYPE_ID = OUTLET_TYPE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_OUTLET_TYPE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet_type = new Outlet_type();
o.My_Outlet_type.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_TYPE_OUTLET_TYPE_ID"]);o.My_Outlet_type.NAME = GV<String>(X["T_OUTLET_TYPE_NAME"]);o.My_Outlet_type.MIN_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MIN_VALUE"]);o.My_Outlet_type.MAX_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MAX_VALUE"]);o.My_Outlet_type.IS_DIGITAL = GV<Boolean>(X["T_OUTLET_TYPE_IS_DIGITAL"]);o.My_Outlet_type.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_TYPE_ENTRY_USER_ID"]);o.My_Outlet_type.ENTRY_DATE = GV<String>(X["T_OUTLET_TYPE_ENTRY_DATE"]);o.My_Outlet_type.OWNER_ID = GV<Int32>(X["T_OUTLET_TYPE_OWNER_ID"]);
o.My_Hardware_link = new Hardware_link();
o.My_Hardware_link.HARDWARE_LINK_ID = GV<Int64>(X["T_HARDWARE_LINK_HARDWARE_LINK_ID"]);o.My_Hardware_link.PLC_ID = GV<Int32>(X["T_HARDWARE_LINK_PLC_ID"]);o.My_Hardware_link.PLC_ADDRESS = GV<String>(X["T_HARDWARE_LINK_PLC_ADDRESS"]);o.My_Hardware_link.ENTRY_USER_ID = GV<Int64>(X["T_HARDWARE_LINK_ENTRY_USER_ID"]);o.My_Hardware_link.ENTRY_DATE = GV<String>(X["T_HARDWARE_LINK_ENTRY_DATE"]);o.My_Hardware_link.OWNER_ID = GV<Int32>(X["T_HARDWARE_LINK_OWNER_ID"]);
o.My_Room = new Room();
o.My_Room.ROOM_ID = GV<Int32>(X["T_ROOM_ROOM_ID"]);o.My_Room.FLOOR_ID = GV<Int32>(X["T_ROOM_FLOOR_ID"]);o.My_Room.NAME = GV<String>(X["T_ROOM_NAME"]);o.My_Room.ENTRY_USER_ID = GV<Int64>(X["T_ROOM_ENTRY_USER_ID"]);o.My_Room.ENTRY_DATE = GV<String>(X["T_ROOM_ENTRY_DATE"]);o.My_Room.OWNER_ID = GV<Int32>(X["T_ROOM_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_HARDWARE_LINK_ID_Adv ( long? HARDWARE_LINK_ID)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.HARDWARE_LINK_ID = HARDWARE_LINK_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_HARDWARE_LINK_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet_type = new Outlet_type();
o.My_Outlet_type.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_TYPE_OUTLET_TYPE_ID"]);o.My_Outlet_type.NAME = GV<String>(X["T_OUTLET_TYPE_NAME"]);o.My_Outlet_type.MIN_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MIN_VALUE"]);o.My_Outlet_type.MAX_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MAX_VALUE"]);o.My_Outlet_type.IS_DIGITAL = GV<Boolean>(X["T_OUTLET_TYPE_IS_DIGITAL"]);o.My_Outlet_type.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_TYPE_ENTRY_USER_ID"]);o.My_Outlet_type.ENTRY_DATE = GV<String>(X["T_OUTLET_TYPE_ENTRY_DATE"]);o.My_Outlet_type.OWNER_ID = GV<Int32>(X["T_OUTLET_TYPE_OWNER_ID"]);
o.My_Hardware_link = new Hardware_link();
o.My_Hardware_link.HARDWARE_LINK_ID = GV<Int64>(X["T_HARDWARE_LINK_HARDWARE_LINK_ID"]);o.My_Hardware_link.PLC_ID = GV<Int32>(X["T_HARDWARE_LINK_PLC_ID"]);o.My_Hardware_link.PLC_ADDRESS = GV<String>(X["T_HARDWARE_LINK_PLC_ADDRESS"]);o.My_Hardware_link.ENTRY_USER_ID = GV<Int64>(X["T_HARDWARE_LINK_ENTRY_USER_ID"]);o.My_Hardware_link.ENTRY_DATE = GV<String>(X["T_HARDWARE_LINK_ENTRY_DATE"]);o.My_Hardware_link.OWNER_ID = GV<Int32>(X["T_HARDWARE_LINK_OWNER_ID"]);
o.My_Room = new Room();
o.My_Room.ROOM_ID = GV<Int32>(X["T_ROOM_ROOM_ID"]);o.My_Room.FLOOR_ID = GV<Int32>(X["T_ROOM_FLOOR_ID"]);o.My_Room.NAME = GV<String>(X["T_ROOM_NAME"]);o.My_Room.ENTRY_USER_ID = GV<Int64>(X["T_ROOM_ENTRY_USER_ID"]);o.My_Room.ENTRY_DATE = GV<String>(X["T_ROOM_ENTRY_DATE"]);o.My_Room.OWNER_ID = GV<Int32>(X["T_ROOM_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Outlet_type> oList = new List<Outlet_type>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_TYPE_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_type o = new Outlet_type();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet = new Outlet();
o.My_Outlet.OUTLET_ID = GV<Int64>(X["T_OUTLET_OUTLET_ID"]);o.My_Outlet.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_OUTLET_TYPE_ID"]);o.My_Outlet.HARDWARE_LINK_ID = GV<Int64>(X["T_OUTLET_HARDWARE_LINK_ID"]);o.My_Outlet.ROOM_ID = GV<Int32>(X["T_OUTLET_ROOM_ID"]);o.My_Outlet.NAME = GV<String>(X["T_OUTLET_NAME"]);o.My_Outlet.CURRENT_VALUE = GV<String>(X["T_OUTLET_CURRENT_VALUE"]);o.My_Outlet.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_ENTRY_USER_ID"]);o.My_Outlet.ENTRY_DATE = GV<String>(X["T_OUTLET_ENTRY_DATE"]);o.My_Outlet.OWNER_ID = GV<Int32>(X["T_OUTLET_OWNER_ID"]);
o.My_Ui = new Ui();
o.My_Ui.UI_ID = GV<Int64>(X["T_UI_UI_ID"]);o.My_Ui.COLOR = GV<String>(X["T_UI_COLOR"]);o.My_Ui.OTHER = GV<String>(X["T_UI_OTHER"]);o.My_Ui.ENTRY_USER_ID = GV<Int64>(X["T_UI_ENTRY_USER_ID"]);o.My_Ui.ENTRY_DATE = GV<String>(X["T_UI_ENTRY_DATE"]);o.My_Ui.OWNER_ID = GV<Int32>(X["T_UI_OWNER_ID"]);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OUTLET_ID_Adv ( long? OUTLET_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.OUTLET_ID = OUTLET_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_OUTLET_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet = new Outlet();
o.My_Outlet.OUTLET_ID = GV<Int64>(X["T_OUTLET_OUTLET_ID"]);o.My_Outlet.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_OUTLET_TYPE_ID"]);o.My_Outlet.HARDWARE_LINK_ID = GV<Int64>(X["T_OUTLET_HARDWARE_LINK_ID"]);o.My_Outlet.ROOM_ID = GV<Int32>(X["T_OUTLET_ROOM_ID"]);o.My_Outlet.NAME = GV<String>(X["T_OUTLET_NAME"]);o.My_Outlet.CURRENT_VALUE = GV<String>(X["T_OUTLET_CURRENT_VALUE"]);o.My_Outlet.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_ENTRY_USER_ID"]);o.My_Outlet.ENTRY_DATE = GV<String>(X["T_OUTLET_ENTRY_DATE"]);o.My_Outlet.OWNER_ID = GV<Int32>(X["T_OUTLET_OWNER_ID"]);
o.My_Ui = new Ui();
o.My_Ui.UI_ID = GV<Int64>(X["T_UI_UI_ID"]);o.My_Ui.COLOR = GV<String>(X["T_UI_COLOR"]);o.My_Ui.OTHER = GV<String>(X["T_UI_OTHER"]);o.My_Ui.ENTRY_USER_ID = GV<Int64>(X["T_UI_ENTRY_USER_ID"]);o.My_Ui.ENTRY_DATE = GV<String>(X["T_UI_ENTRY_DATE"]);o.My_Ui.OWNER_ID = GV<Int32>(X["T_UI_OWNER_ID"]);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_UI_ID_Adv ( long? UI_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.UI_ID = UI_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_UI_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet = new Outlet();
o.My_Outlet.OUTLET_ID = GV<Int64>(X["T_OUTLET_OUTLET_ID"]);o.My_Outlet.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_OUTLET_TYPE_ID"]);o.My_Outlet.HARDWARE_LINK_ID = GV<Int64>(X["T_OUTLET_HARDWARE_LINK_ID"]);o.My_Outlet.ROOM_ID = GV<Int32>(X["T_OUTLET_ROOM_ID"]);o.My_Outlet.NAME = GV<String>(X["T_OUTLET_NAME"]);o.My_Outlet.CURRENT_VALUE = GV<String>(X["T_OUTLET_CURRENT_VALUE"]);o.My_Outlet.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_ENTRY_USER_ID"]);o.My_Outlet.ENTRY_DATE = GV<String>(X["T_OUTLET_ENTRY_DATE"]);o.My_Outlet.OWNER_ID = GV<Int32>(X["T_OUTLET_OWNER_ID"]);
o.My_Ui = new Ui();
o.My_Ui.UI_ID = GV<Int64>(X["T_UI_UI_ID"]);o.My_Ui.COLOR = GV<String>(X["T_UI_COLOR"]);o.My_Ui.OTHER = GV<String>(X["T_UI_OTHER"]);o.My_Ui.ENTRY_USER_ID = GV<Int64>(X["T_UI_ENTRY_USER_ID"]);o.My_Ui.ENTRY_DATE = GV<String>(X["T_UI_ENTRY_DATE"]);o.My_Ui.OWNER_ID = GV<Int32>(X["T_UI_OWNER_ID"]);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_USER_ID_Adv ( long? USER_ID)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_USER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet = new Outlet();
o.My_Outlet.OUTLET_ID = GV<Int64>(X["T_OUTLET_OUTLET_ID"]);o.My_Outlet.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_OUTLET_TYPE_ID"]);o.My_Outlet.HARDWARE_LINK_ID = GV<Int64>(X["T_OUTLET_HARDWARE_LINK_ID"]);o.My_Outlet.ROOM_ID = GV<Int32>(X["T_OUTLET_ROOM_ID"]);o.My_Outlet.NAME = GV<String>(X["T_OUTLET_NAME"]);o.My_Outlet.CURRENT_VALUE = GV<String>(X["T_OUTLET_CURRENT_VALUE"]);o.My_Outlet.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_ENTRY_USER_ID"]);o.My_Outlet.ENTRY_DATE = GV<String>(X["T_OUTLET_ENTRY_DATE"]);o.My_Outlet.OWNER_ID = GV<Int32>(X["T_OUTLET_OWNER_ID"]);
o.My_Ui = new Ui();
o.My_Ui.UI_ID = GV<Int64>(X["T_UI_UI_ID"]);o.My_Ui.COLOR = GV<String>(X["T_UI_COLOR"]);o.My_Ui.OTHER = GV<String>(X["T_UI_OTHER"]);o.My_Ui.ENTRY_USER_ID = GV<Int64>(X["T_UI_ENTRY_USER_ID"]);o.My_Ui.ENTRY_DATE = GV<String>(X["T_UI_ENTRY_DATE"]);o.My_Ui.OWNER_ID = GV<Int32>(X["T_UI_OWNER_ID"]);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Plc> Get_Plc_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Plc> oList = new List<Plc>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PLC_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Plc o = new Plc();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Room> Get_Room_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Floor = new Floor();
o.My_Floor.FLOOR_ID = GV<Int32>(X["T_FLOOR_FLOOR_ID"]);o.My_Floor.NAME = GV<String>(X["T_FLOOR_NAME"]);o.My_Floor.ENTRY_USER_ID = GV<Int64>(X["T_FLOOR_ENTRY_USER_ID"]);o.My_Floor.ENTRY_DATE = GV<String>(X["T_FLOOR_ENTRY_DATE"]);o.My_Floor.OWNER_ID = GV<Int32>(X["T_FLOOR_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Room> Get_Room_By_FLOOR_ID_Adv ( Int32? FLOOR_ID)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.FLOOR_ID = FLOOR_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_FLOOR_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Floor = new Floor();
o.My_Floor.FLOOR_ID = GV<Int32>(X["T_FLOOR_FLOOR_ID"]);o.My_Floor.NAME = GV<String>(X["T_FLOOR_NAME"]);o.My_Floor.ENTRY_USER_ID = GV<Int64>(X["T_FLOOR_ENTRY_USER_ID"]);o.My_Floor.ENTRY_DATE = GV<String>(X["T_FLOOR_ENTRY_DATE"]);o.My_Floor.OWNER_ID = GV<Int32>(X["T_FLOOR_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Ui> Get_Ui_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Ui> oList = new List<Ui>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UI_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Ui o = new Ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_PLC_ID_List ( List<Int32?> PLC_ID_LIST)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.PLC_ID_LIST = string.Join(",", PLC_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_PLC_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_ROOM_ID_List ( List<Int32?> ROOM_ID_LIST)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.ROOM_ID_LIST = string.Join(",", ROOM_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_ROOM_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_OUTLET_TYPE_ID_List ( List<Int32?> OUTLET_TYPE_ID_LIST)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.OUTLET_TYPE_ID_LIST = string.Join(",", OUTLET_TYPE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_OUTLET_TYPE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_HARDWARE_LINK_ID_List ( List<long?> HARDWARE_LINK_ID_LIST)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.HARDWARE_LINK_ID_LIST = string.Join(",", HARDWARE_LINK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_HARDWARE_LINK_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OUTLET_ID_List ( List<long?> OUTLET_ID_LIST)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.OUTLET_ID_LIST = string.Join(",", OUTLET_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_OUTLET_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_UI_ID_List ( List<long?> UI_ID_LIST)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.UI_ID_LIST = string.Join(",", UI_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_UI_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_USER_ID_List ( List<long?> USER_ID_LIST)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_USER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Room> Get_Room_By_FLOOR_ID_List ( List<Int32?> FLOOR_ID_LIST)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.FLOOR_ID_LIST = string.Join(",", FLOOR_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_FLOOR_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_PLC_ID_List_Adv ( List<Int32?> PLC_ID_LIST)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.PLC_ID_LIST = string.Join(",", PLC_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_PLC_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Plc = new Plc();
o.My_Plc.PLC_ID = GV<Int32>(X["T_PLC_PLC_ID"]);o.My_Plc.LOCATION = GV<String>(X["T_PLC_LOCATION"]);o.My_Plc.PORT = GV<String>(X["T_PLC_PORT"]);o.My_Plc.TYPE = GV<String>(X["T_PLC_TYPE"]);o.My_Plc.CURRENT_INPUTS = GV<Int32>(X["T_PLC_CURRENT_INPUTS"]);o.My_Plc.MAX_INPUTS = GV<Int32>(X["T_PLC_MAX_INPUTS"]);o.My_Plc.CURRENT_OUTPUTS = GV<Int32>(X["T_PLC_CURRENT_OUTPUTS"]);o.My_Plc.MAX_OUTPUTS = GV<Int32>(X["T_PLC_MAX_OUTPUTS"]);o.My_Plc.ENTRY_USER_ID = GV<Int64>(X["T_PLC_ENTRY_USER_ID"]);o.My_Plc.ENTRY_DATE = GV<String>(X["T_PLC_ENTRY_DATE"]);o.My_Plc.OWNER_ID = GV<Int32>(X["T_PLC_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_ROOM_ID_List_Adv ( List<Int32?> ROOM_ID_LIST)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.ROOM_ID_LIST = string.Join(",", ROOM_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_ROOM_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet_type = new Outlet_type();
o.My_Outlet_type.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_TYPE_OUTLET_TYPE_ID"]);o.My_Outlet_type.NAME = GV<String>(X["T_OUTLET_TYPE_NAME"]);o.My_Outlet_type.MIN_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MIN_VALUE"]);o.My_Outlet_type.MAX_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MAX_VALUE"]);o.My_Outlet_type.IS_DIGITAL = GV<Boolean>(X["T_OUTLET_TYPE_IS_DIGITAL"]);o.My_Outlet_type.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_TYPE_ENTRY_USER_ID"]);o.My_Outlet_type.ENTRY_DATE = GV<String>(X["T_OUTLET_TYPE_ENTRY_DATE"]);o.My_Outlet_type.OWNER_ID = GV<Int32>(X["T_OUTLET_TYPE_OWNER_ID"]);
o.My_Hardware_link = new Hardware_link();
o.My_Hardware_link.HARDWARE_LINK_ID = GV<Int64>(X["T_HARDWARE_LINK_HARDWARE_LINK_ID"]);o.My_Hardware_link.PLC_ID = GV<Int32>(X["T_HARDWARE_LINK_PLC_ID"]);o.My_Hardware_link.PLC_ADDRESS = GV<String>(X["T_HARDWARE_LINK_PLC_ADDRESS"]);o.My_Hardware_link.ENTRY_USER_ID = GV<Int64>(X["T_HARDWARE_LINK_ENTRY_USER_ID"]);o.My_Hardware_link.ENTRY_DATE = GV<String>(X["T_HARDWARE_LINK_ENTRY_DATE"]);o.My_Hardware_link.OWNER_ID = GV<Int32>(X["T_HARDWARE_LINK_OWNER_ID"]);
o.My_Room = new Room();
o.My_Room.ROOM_ID = GV<Int32>(X["T_ROOM_ROOM_ID"]);o.My_Room.FLOOR_ID = GV<Int32>(X["T_ROOM_FLOOR_ID"]);o.My_Room.NAME = GV<String>(X["T_ROOM_NAME"]);o.My_Room.ENTRY_USER_ID = GV<Int64>(X["T_ROOM_ENTRY_USER_ID"]);o.My_Room.ENTRY_DATE = GV<String>(X["T_ROOM_ENTRY_DATE"]);o.My_Room.OWNER_ID = GV<Int32>(X["T_ROOM_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_OUTLET_TYPE_ID_List_Adv ( List<Int32?> OUTLET_TYPE_ID_LIST)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.OUTLET_TYPE_ID_LIST = string.Join(",", OUTLET_TYPE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_OUTLET_TYPE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet_type = new Outlet_type();
o.My_Outlet_type.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_TYPE_OUTLET_TYPE_ID"]);o.My_Outlet_type.NAME = GV<String>(X["T_OUTLET_TYPE_NAME"]);o.My_Outlet_type.MIN_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MIN_VALUE"]);o.My_Outlet_type.MAX_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MAX_VALUE"]);o.My_Outlet_type.IS_DIGITAL = GV<Boolean>(X["T_OUTLET_TYPE_IS_DIGITAL"]);o.My_Outlet_type.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_TYPE_ENTRY_USER_ID"]);o.My_Outlet_type.ENTRY_DATE = GV<String>(X["T_OUTLET_TYPE_ENTRY_DATE"]);o.My_Outlet_type.OWNER_ID = GV<Int32>(X["T_OUTLET_TYPE_OWNER_ID"]);
o.My_Hardware_link = new Hardware_link();
o.My_Hardware_link.HARDWARE_LINK_ID = GV<Int64>(X["T_HARDWARE_LINK_HARDWARE_LINK_ID"]);o.My_Hardware_link.PLC_ID = GV<Int32>(X["T_HARDWARE_LINK_PLC_ID"]);o.My_Hardware_link.PLC_ADDRESS = GV<String>(X["T_HARDWARE_LINK_PLC_ADDRESS"]);o.My_Hardware_link.ENTRY_USER_ID = GV<Int64>(X["T_HARDWARE_LINK_ENTRY_USER_ID"]);o.My_Hardware_link.ENTRY_DATE = GV<String>(X["T_HARDWARE_LINK_ENTRY_DATE"]);o.My_Hardware_link.OWNER_ID = GV<Int32>(X["T_HARDWARE_LINK_OWNER_ID"]);
o.My_Room = new Room();
o.My_Room.ROOM_ID = GV<Int32>(X["T_ROOM_ROOM_ID"]);o.My_Room.FLOOR_ID = GV<Int32>(X["T_ROOM_FLOOR_ID"]);o.My_Room.NAME = GV<String>(X["T_ROOM_NAME"]);o.My_Room.ENTRY_USER_ID = GV<Int64>(X["T_ROOM_ENTRY_USER_ID"]);o.My_Room.ENTRY_DATE = GV<String>(X["T_ROOM_ENTRY_DATE"]);o.My_Room.OWNER_ID = GV<Int32>(X["T_ROOM_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet> Get_Outlet_By_HARDWARE_LINK_ID_List_Adv ( List<long?> HARDWARE_LINK_ID_LIST)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.HARDWARE_LINK_ID_LIST = string.Join(",", HARDWARE_LINK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_HARDWARE_LINK_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet_type = new Outlet_type();
o.My_Outlet_type.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_TYPE_OUTLET_TYPE_ID"]);o.My_Outlet_type.NAME = GV<String>(X["T_OUTLET_TYPE_NAME"]);o.My_Outlet_type.MIN_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MIN_VALUE"]);o.My_Outlet_type.MAX_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MAX_VALUE"]);o.My_Outlet_type.IS_DIGITAL = GV<Boolean>(X["T_OUTLET_TYPE_IS_DIGITAL"]);o.My_Outlet_type.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_TYPE_ENTRY_USER_ID"]);o.My_Outlet_type.ENTRY_DATE = GV<String>(X["T_OUTLET_TYPE_ENTRY_DATE"]);o.My_Outlet_type.OWNER_ID = GV<Int32>(X["T_OUTLET_TYPE_OWNER_ID"]);
o.My_Hardware_link = new Hardware_link();
o.My_Hardware_link.HARDWARE_LINK_ID = GV<Int64>(X["T_HARDWARE_LINK_HARDWARE_LINK_ID"]);o.My_Hardware_link.PLC_ID = GV<Int32>(X["T_HARDWARE_LINK_PLC_ID"]);o.My_Hardware_link.PLC_ADDRESS = GV<String>(X["T_HARDWARE_LINK_PLC_ADDRESS"]);o.My_Hardware_link.ENTRY_USER_ID = GV<Int64>(X["T_HARDWARE_LINK_ENTRY_USER_ID"]);o.My_Hardware_link.ENTRY_DATE = GV<String>(X["T_HARDWARE_LINK_ENTRY_DATE"]);o.My_Hardware_link.OWNER_ID = GV<Int32>(X["T_HARDWARE_LINK_OWNER_ID"]);
o.My_Room = new Room();
o.My_Room.ROOM_ID = GV<Int32>(X["T_ROOM_ROOM_ID"]);o.My_Room.FLOOR_ID = GV<Int32>(X["T_ROOM_FLOOR_ID"]);o.My_Room.NAME = GV<String>(X["T_ROOM_NAME"]);o.My_Room.ENTRY_USER_ID = GV<Int64>(X["T_ROOM_ENTRY_USER_ID"]);o.My_Room.ENTRY_DATE = GV<String>(X["T_ROOM_ENTRY_DATE"]);o.My_Room.OWNER_ID = GV<Int32>(X["T_ROOM_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_OUTLET_ID_List_Adv ( List<long?> OUTLET_ID_LIST)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.OUTLET_ID_LIST = string.Join(",", OUTLET_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_OUTLET_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet = new Outlet();
o.My_Outlet.OUTLET_ID = GV<Int64>(X["T_OUTLET_OUTLET_ID"]);o.My_Outlet.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_OUTLET_TYPE_ID"]);o.My_Outlet.HARDWARE_LINK_ID = GV<Int64>(X["T_OUTLET_HARDWARE_LINK_ID"]);o.My_Outlet.ROOM_ID = GV<Int32>(X["T_OUTLET_ROOM_ID"]);o.My_Outlet.NAME = GV<String>(X["T_OUTLET_NAME"]);o.My_Outlet.CURRENT_VALUE = GV<String>(X["T_OUTLET_CURRENT_VALUE"]);o.My_Outlet.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_ENTRY_USER_ID"]);o.My_Outlet.ENTRY_DATE = GV<String>(X["T_OUTLET_ENTRY_DATE"]);o.My_Outlet.OWNER_ID = GV<Int32>(X["T_OUTLET_OWNER_ID"]);
o.My_Ui = new Ui();
o.My_Ui.UI_ID = GV<Int64>(X["T_UI_UI_ID"]);o.My_Ui.COLOR = GV<String>(X["T_UI_COLOR"]);o.My_Ui.OTHER = GV<String>(X["T_UI_OTHER"]);o.My_Ui.ENTRY_USER_ID = GV<Int64>(X["T_UI_ENTRY_USER_ID"]);o.My_Ui.ENTRY_DATE = GV<String>(X["T_UI_ENTRY_DATE"]);o.My_Ui.OWNER_ID = GV<Int32>(X["T_UI_OWNER_ID"]);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_UI_ID_List_Adv ( List<long?> UI_ID_LIST)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.UI_ID_LIST = string.Join(",", UI_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_UI_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet = new Outlet();
o.My_Outlet.OUTLET_ID = GV<Int64>(X["T_OUTLET_OUTLET_ID"]);o.My_Outlet.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_OUTLET_TYPE_ID"]);o.My_Outlet.HARDWARE_LINK_ID = GV<Int64>(X["T_OUTLET_HARDWARE_LINK_ID"]);o.My_Outlet.ROOM_ID = GV<Int32>(X["T_OUTLET_ROOM_ID"]);o.My_Outlet.NAME = GV<String>(X["T_OUTLET_NAME"]);o.My_Outlet.CURRENT_VALUE = GV<String>(X["T_OUTLET_CURRENT_VALUE"]);o.My_Outlet.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_ENTRY_USER_ID"]);o.My_Outlet.ENTRY_DATE = GV<String>(X["T_OUTLET_ENTRY_DATE"]);o.My_Outlet.OWNER_ID = GV<Int32>(X["T_OUTLET_OWNER_ID"]);
o.My_Ui = new Ui();
o.My_Ui.UI_ID = GV<Int64>(X["T_UI_UI_ID"]);o.My_Ui.COLOR = GV<String>(X["T_UI_COLOR"]);o.My_Ui.OTHER = GV<String>(X["T_UI_OTHER"]);o.My_Ui.ENTRY_USER_ID = GV<Int64>(X["T_UI_ENTRY_USER_ID"]);o.My_Ui.ENTRY_DATE = GV<String>(X["T_UI_ENTRY_DATE"]);o.My_Ui.OWNER_ID = GV<Int32>(X["T_UI_OWNER_ID"]);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_USER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet = new Outlet();
o.My_Outlet.OUTLET_ID = GV<Int64>(X["T_OUTLET_OUTLET_ID"]);o.My_Outlet.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_OUTLET_TYPE_ID"]);o.My_Outlet.HARDWARE_LINK_ID = GV<Int64>(X["T_OUTLET_HARDWARE_LINK_ID"]);o.My_Outlet.ROOM_ID = GV<Int32>(X["T_OUTLET_ROOM_ID"]);o.My_Outlet.NAME = GV<String>(X["T_OUTLET_NAME"]);o.My_Outlet.CURRENT_VALUE = GV<String>(X["T_OUTLET_CURRENT_VALUE"]);o.My_Outlet.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_ENTRY_USER_ID"]);o.My_Outlet.ENTRY_DATE = GV<String>(X["T_OUTLET_ENTRY_DATE"]);o.My_Outlet.OWNER_ID = GV<Int32>(X["T_OUTLET_OWNER_ID"]);
o.My_Ui = new Ui();
o.My_Ui.UI_ID = GV<Int64>(X["T_UI_UI_ID"]);o.My_Ui.COLOR = GV<String>(X["T_UI_COLOR"]);o.My_Ui.OTHER = GV<String>(X["T_UI_OTHER"]);o.My_Ui.ENTRY_USER_ID = GV<Int64>(X["T_UI_ENTRY_USER_ID"]);o.My_Ui.ENTRY_DATE = GV<String>(X["T_UI_ENTRY_DATE"]);o.My_Ui.OWNER_ID = GV<Int32>(X["T_UI_OWNER_ID"]);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Room> Get_Room_By_FLOOR_ID_List_Adv ( List<Int32?> FLOOR_ID_LIST)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.FLOOR_ID_LIST = string.Join(",", FLOOR_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_FLOOR_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Floor = new Floor();
o.My_Floor.FLOOR_ID = GV<Int32>(X["T_FLOOR_FLOOR_ID"]);o.My_Floor.NAME = GV<String>(X["T_FLOOR_NAME"]);o.My_Floor.ENTRY_USER_ID = GV<Int64>(X["T_FLOOR_ENTRY_USER_ID"]);o.My_Floor.ENTRY_DATE = GV<String>(X["T_FLOOR_ENTRY_DATE"]);o.My_Floor.OWNER_ID = GV<Int32>(X["T_FLOOR_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Floor> Get_Floor_By_Criteria ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Floor> oList = new List<Floor>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FLOOR_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Floor o = new Floor();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Floor> Get_Floor_By_Where ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Floor> oList = new List<Floor>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FLOOR_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Floor o = new Floor();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Criteria ( string PLC_ADDRESS, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.PLC_ADDRESS = PLC_ADDRESS; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Where ( string PLC_ADDRESS, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.PLC_ADDRESS = PLC_ADDRESS; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet> Get_Outlet_By_Criteria ( string NAME, string CURRENT_VALUE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.CURRENT_VALUE = CURRENT_VALUE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet> Get_Outlet_By_Where ( string NAME, string CURRENT_VALUE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.CURRENT_VALUE = CURRENT_VALUE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_Criteria ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet_type> oList = new List<Outlet_type>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_TYPE_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Outlet_type o = new Outlet_type();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_Where ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet_type> oList = new List<Outlet_type>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_TYPE_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Outlet_type o = new Outlet_type();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Plc> Get_Plc_By_Criteria ( string LOCATION, string PORT, string TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Plc> oList = new List<Plc>();
dynamic p = new ExpandoObject();
p.LOCATION = LOCATION; p.PORT = PORT; p.TYPE = TYPE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PLC_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Plc o = new Plc();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Plc> Get_Plc_By_Where ( string LOCATION, string PORT, string TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Plc> oList = new List<Plc>();
dynamic p = new ExpandoObject();
p.LOCATION = LOCATION; p.PORT = PORT; p.TYPE = TYPE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PLC_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Plc o = new Plc();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Room> Get_Room_By_Criteria ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Room> Get_Room_By_Where ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Ui> Get_Ui_By_Criteria ( string COLOR, string OTHER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Ui> oList = new List<Ui>();
dynamic p = new ExpandoObject();
p.COLOR = COLOR; p.OTHER = OTHER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UI_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Ui o = new Ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Ui> Get_Ui_By_Where ( string COLOR, string OTHER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Ui> oList = new List<Ui>();
dynamic p = new ExpandoObject();
p.COLOR = COLOR; p.OTHER = OTHER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UI_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Ui o = new Ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_Criteria ( string REL_ENTITY, string REL_FIELD, string EXTENSION, string URL, string STAMP, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.REL_ENTITY = REL_ENTITY; p.REL_FIELD = REL_FIELD; p.EXTENSION = EXTENSION; p.URL = URL; p.STAMP = STAMP; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Uploaded_file> Get_Uploaded_file_By_Where ( string REL_ENTITY, string REL_FIELD, string EXTENSION, string URL, string STAMP, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Uploaded_file> oList = new List<Uploaded_file>();
dynamic p = new ExpandoObject();
p.REL_ENTITY = REL_ENTITY; p.REL_FIELD = REL_FIELD; p.EXTENSION = EXTENSION; p.URL = URL; p.STAMP = STAMP; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UPLOADED_FILE_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Uploaded_file o = new Uploaded_file();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Floor> Get_Floor_By_Criteria_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Floor> oList = new List<Floor>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FLOOR_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Floor o = new Floor();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Floor> Get_Floor_By_Where_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Floor> oList = new List<Floor>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FLOOR_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Floor o = new Floor();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Criteria_Adv ( string PLC_ADDRESS, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.PLC_ADDRESS = PLC_ADDRESS; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Plc = new Plc();
o.My_Plc.PLC_ID = GV<Int32>(X["T_PLC_PLC_ID"]);o.My_Plc.LOCATION = GV<String>(X["T_PLC_LOCATION"]);o.My_Plc.PORT = GV<String>(X["T_PLC_PORT"]);o.My_Plc.TYPE = GV<String>(X["T_PLC_TYPE"]);o.My_Plc.CURRENT_INPUTS = GV<Int32>(X["T_PLC_CURRENT_INPUTS"]);o.My_Plc.MAX_INPUTS = GV<Int32>(X["T_PLC_MAX_INPUTS"]);o.My_Plc.CURRENT_OUTPUTS = GV<Int32>(X["T_PLC_CURRENT_OUTPUTS"]);o.My_Plc.MAX_OUTPUTS = GV<Int32>(X["T_PLC_MAX_OUTPUTS"]);o.My_Plc.ENTRY_USER_ID = GV<Int64>(X["T_PLC_ENTRY_USER_ID"]);o.My_Plc.ENTRY_DATE = GV<String>(X["T_PLC_ENTRY_DATE"]);o.My_Plc.OWNER_ID = GV<Int32>(X["T_PLC_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Where_Adv ( string PLC_ADDRESS, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.PLC_ADDRESS = PLC_ADDRESS; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Plc = new Plc();
o.My_Plc.PLC_ID = GV<Int32>(X["T_PLC_PLC_ID"]);o.My_Plc.LOCATION = GV<String>(X["T_PLC_LOCATION"]);o.My_Plc.PORT = GV<String>(X["T_PLC_PORT"]);o.My_Plc.TYPE = GV<String>(X["T_PLC_TYPE"]);o.My_Plc.CURRENT_INPUTS = GV<Int32>(X["T_PLC_CURRENT_INPUTS"]);o.My_Plc.MAX_INPUTS = GV<Int32>(X["T_PLC_MAX_INPUTS"]);o.My_Plc.CURRENT_OUTPUTS = GV<Int32>(X["T_PLC_CURRENT_OUTPUTS"]);o.My_Plc.MAX_OUTPUTS = GV<Int32>(X["T_PLC_MAX_OUTPUTS"]);o.My_Plc.ENTRY_USER_ID = GV<Int64>(X["T_PLC_ENTRY_USER_ID"]);o.My_Plc.ENTRY_DATE = GV<String>(X["T_PLC_ENTRY_DATE"]);o.My_Plc.OWNER_ID = GV<Int32>(X["T_PLC_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet> Get_Outlet_By_Criteria_Adv ( string NAME, string CURRENT_VALUE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.CURRENT_VALUE = CURRENT_VALUE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet_type = new Outlet_type();
o.My_Outlet_type.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_TYPE_OUTLET_TYPE_ID"]);o.My_Outlet_type.NAME = GV<String>(X["T_OUTLET_TYPE_NAME"]);o.My_Outlet_type.MIN_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MIN_VALUE"]);o.My_Outlet_type.MAX_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MAX_VALUE"]);o.My_Outlet_type.IS_DIGITAL = GV<Boolean>(X["T_OUTLET_TYPE_IS_DIGITAL"]);o.My_Outlet_type.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_TYPE_ENTRY_USER_ID"]);o.My_Outlet_type.ENTRY_DATE = GV<String>(X["T_OUTLET_TYPE_ENTRY_DATE"]);o.My_Outlet_type.OWNER_ID = GV<Int32>(X["T_OUTLET_TYPE_OWNER_ID"]);
o.My_Hardware_link = new Hardware_link();
o.My_Hardware_link.HARDWARE_LINK_ID = GV<Int64>(X["T_HARDWARE_LINK_HARDWARE_LINK_ID"]);o.My_Hardware_link.PLC_ID = GV<Int32>(X["T_HARDWARE_LINK_PLC_ID"]);o.My_Hardware_link.PLC_ADDRESS = GV<String>(X["T_HARDWARE_LINK_PLC_ADDRESS"]);o.My_Hardware_link.ENTRY_USER_ID = GV<Int64>(X["T_HARDWARE_LINK_ENTRY_USER_ID"]);o.My_Hardware_link.ENTRY_DATE = GV<String>(X["T_HARDWARE_LINK_ENTRY_DATE"]);o.My_Hardware_link.OWNER_ID = GV<Int32>(X["T_HARDWARE_LINK_OWNER_ID"]);
o.My_Room = new Room();
o.My_Room.ROOM_ID = GV<Int32>(X["T_ROOM_ROOM_ID"]);o.My_Room.FLOOR_ID = GV<Int32>(X["T_ROOM_FLOOR_ID"]);o.My_Room.NAME = GV<String>(X["T_ROOM_NAME"]);o.My_Room.ENTRY_USER_ID = GV<Int64>(X["T_ROOM_ENTRY_USER_ID"]);o.My_Room.ENTRY_DATE = GV<String>(X["T_ROOM_ENTRY_DATE"]);o.My_Room.OWNER_ID = GV<Int32>(X["T_ROOM_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet> Get_Outlet_By_Where_Adv ( string NAME, string CURRENT_VALUE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.CURRENT_VALUE = CURRENT_VALUE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet_type = new Outlet_type();
o.My_Outlet_type.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_TYPE_OUTLET_TYPE_ID"]);o.My_Outlet_type.NAME = GV<String>(X["T_OUTLET_TYPE_NAME"]);o.My_Outlet_type.MIN_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MIN_VALUE"]);o.My_Outlet_type.MAX_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MAX_VALUE"]);o.My_Outlet_type.IS_DIGITAL = GV<Boolean>(X["T_OUTLET_TYPE_IS_DIGITAL"]);o.My_Outlet_type.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_TYPE_ENTRY_USER_ID"]);o.My_Outlet_type.ENTRY_DATE = GV<String>(X["T_OUTLET_TYPE_ENTRY_DATE"]);o.My_Outlet_type.OWNER_ID = GV<Int32>(X["T_OUTLET_TYPE_OWNER_ID"]);
o.My_Hardware_link = new Hardware_link();
o.My_Hardware_link.HARDWARE_LINK_ID = GV<Int64>(X["T_HARDWARE_LINK_HARDWARE_LINK_ID"]);o.My_Hardware_link.PLC_ID = GV<Int32>(X["T_HARDWARE_LINK_PLC_ID"]);o.My_Hardware_link.PLC_ADDRESS = GV<String>(X["T_HARDWARE_LINK_PLC_ADDRESS"]);o.My_Hardware_link.ENTRY_USER_ID = GV<Int64>(X["T_HARDWARE_LINK_ENTRY_USER_ID"]);o.My_Hardware_link.ENTRY_DATE = GV<String>(X["T_HARDWARE_LINK_ENTRY_DATE"]);o.My_Hardware_link.OWNER_ID = GV<Int32>(X["T_HARDWARE_LINK_OWNER_ID"]);
o.My_Room = new Room();
o.My_Room.ROOM_ID = GV<Int32>(X["T_ROOM_ROOM_ID"]);o.My_Room.FLOOR_ID = GV<Int32>(X["T_ROOM_FLOOR_ID"]);o.My_Room.NAME = GV<String>(X["T_ROOM_NAME"]);o.My_Room.ENTRY_USER_ID = GV<Int64>(X["T_ROOM_ENTRY_USER_ID"]);o.My_Room.ENTRY_DATE = GV<String>(X["T_ROOM_ENTRY_DATE"]);o.My_Room.OWNER_ID = GV<Int32>(X["T_ROOM_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_Criteria_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet_type> oList = new List<Outlet_type>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_TYPE_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_type o = new Outlet_type();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet_type> Get_Outlet_type_By_Where_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet_type> oList = new List<Outlet_type>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_TYPE_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_type o = new Outlet_type();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet = new Outlet();
o.My_Outlet.OUTLET_ID = GV<Int64>(X["T_OUTLET_OUTLET_ID"]);o.My_Outlet.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_OUTLET_TYPE_ID"]);o.My_Outlet.HARDWARE_LINK_ID = GV<Int64>(X["T_OUTLET_HARDWARE_LINK_ID"]);o.My_Outlet.ROOM_ID = GV<Int32>(X["T_OUTLET_ROOM_ID"]);o.My_Outlet.NAME = GV<String>(X["T_OUTLET_NAME"]);o.My_Outlet.CURRENT_VALUE = GV<String>(X["T_OUTLET_CURRENT_VALUE"]);o.My_Outlet.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_ENTRY_USER_ID"]);o.My_Outlet.ENTRY_DATE = GV<String>(X["T_OUTLET_ENTRY_DATE"]);o.My_Outlet.OWNER_ID = GV<Int32>(X["T_OUTLET_OWNER_ID"]);
o.My_Ui = new Ui();
o.My_Ui.UI_ID = GV<Int64>(X["T_UI_UI_ID"]);o.My_Ui.COLOR = GV<String>(X["T_UI_COLOR"]);o.My_Ui.OTHER = GV<String>(X["T_UI_OTHER"]);o.My_Ui.ENTRY_USER_ID = GV<Int64>(X["T_UI_ENTRY_USER_ID"]);o.My_Ui.ENTRY_DATE = GV<String>(X["T_UI_ENTRY_DATE"]);o.My_Ui.OWNER_ID = GV<Int32>(X["T_UI_OWNER_ID"]);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet = new Outlet();
o.My_Outlet.OUTLET_ID = GV<Int64>(X["T_OUTLET_OUTLET_ID"]);o.My_Outlet.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_OUTLET_TYPE_ID"]);o.My_Outlet.HARDWARE_LINK_ID = GV<Int64>(X["T_OUTLET_HARDWARE_LINK_ID"]);o.My_Outlet.ROOM_ID = GV<Int32>(X["T_OUTLET_ROOM_ID"]);o.My_Outlet.NAME = GV<String>(X["T_OUTLET_NAME"]);o.My_Outlet.CURRENT_VALUE = GV<String>(X["T_OUTLET_CURRENT_VALUE"]);o.My_Outlet.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_ENTRY_USER_ID"]);o.My_Outlet.ENTRY_DATE = GV<String>(X["T_OUTLET_ENTRY_DATE"]);o.My_Outlet.OWNER_ID = GV<Int32>(X["T_OUTLET_OWNER_ID"]);
o.My_Ui = new Ui();
o.My_Ui.UI_ID = GV<Int64>(X["T_UI_UI_ID"]);o.My_Ui.COLOR = GV<String>(X["T_UI_COLOR"]);o.My_Ui.OTHER = GV<String>(X["T_UI_OTHER"]);o.My_Ui.ENTRY_USER_ID = GV<Int64>(X["T_UI_ENTRY_USER_ID"]);o.My_Ui.ENTRY_DATE = GV<String>(X["T_UI_ENTRY_DATE"]);o.My_Ui.OWNER_ID = GV<Int32>(X["T_UI_OWNER_ID"]);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Plc> Get_Plc_By_Criteria_Adv ( string LOCATION, string PORT, string TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Plc> oList = new List<Plc>();
dynamic p = new ExpandoObject();
p.LOCATION = LOCATION; p.PORT = PORT; p.TYPE = TYPE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PLC_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Plc o = new Plc();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Plc> Get_Plc_By_Where_Adv ( string LOCATION, string PORT, string TYPE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Plc> oList = new List<Plc>();
dynamic p = new ExpandoObject();
p.LOCATION = LOCATION; p.PORT = PORT; p.TYPE = TYPE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PLC_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Plc o = new Plc();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Room> Get_Room_By_Criteria_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Floor = new Floor();
o.My_Floor.FLOOR_ID = GV<Int32>(X["T_FLOOR_FLOOR_ID"]);o.My_Floor.NAME = GV<String>(X["T_FLOOR_NAME"]);o.My_Floor.ENTRY_USER_ID = GV<Int64>(X["T_FLOOR_ENTRY_USER_ID"]);o.My_Floor.ENTRY_DATE = GV<String>(X["T_FLOOR_ENTRY_DATE"]);o.My_Floor.OWNER_ID = GV<Int32>(X["T_FLOOR_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Room> Get_Room_By_Where_Adv ( string NAME, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Floor = new Floor();
o.My_Floor.FLOOR_ID = GV<Int32>(X["T_FLOOR_FLOOR_ID"]);o.My_Floor.NAME = GV<String>(X["T_FLOOR_NAME"]);o.My_Floor.ENTRY_USER_ID = GV<Int64>(X["T_FLOOR_ENTRY_USER_ID"]);o.My_Floor.ENTRY_DATE = GV<String>(X["T_FLOOR_ENTRY_DATE"]);o.My_Floor.OWNER_ID = GV<Int32>(X["T_FLOOR_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Ui> Get_Ui_By_Criteria_Adv ( string COLOR, string OTHER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Ui> oList = new List<Ui>();
dynamic p = new ExpandoObject();
p.COLOR = COLOR; p.OTHER = OTHER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UI_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Ui o = new Ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Ui> Get_Ui_By_Where_Adv ( string COLOR, string OTHER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Ui> oList = new List<Ui>();
dynamic p = new ExpandoObject();
p.COLOR = COLOR; p.OTHER = OTHER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_UI_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Ui o = new Ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Criteria_InList ( string PLC_ADDRESS, List<Int32?> PLC_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.PLC_ADDRESS = PLC_ADDRESS; p.PLC_ID_LIST = string.Join(",", PLC_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Where_InList ( string PLC_ADDRESS, List<Int32?> PLC_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.PLC_ADDRESS = PLC_ADDRESS; p.PLC_ID_LIST = string.Join(",", PLC_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet> Get_Outlet_By_Criteria_InList ( string NAME, string CURRENT_VALUE, List<Int32?> OUTLET_TYPE_ID_LIST, List<long?> HARDWARE_LINK_ID_LIST, List<Int32?> ROOM_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.CURRENT_VALUE = CURRENT_VALUE; p.OUTLET_TYPE_ID_LIST = string.Join(",", OUTLET_TYPE_ID_LIST.ToArray()); p.HARDWARE_LINK_ID_LIST = string.Join(",", HARDWARE_LINK_ID_LIST.ToArray()); p.ROOM_ID_LIST = string.Join(",", ROOM_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet> Get_Outlet_By_Where_InList ( string NAME, string CURRENT_VALUE, List<Int32?> OUTLET_TYPE_ID_LIST, List<long?> HARDWARE_LINK_ID_LIST, List<Int32?> ROOM_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.CURRENT_VALUE = CURRENT_VALUE; p.OUTLET_TYPE_ID_LIST = string.Join(",", OUTLET_TYPE_ID_LIST.ToArray()); p.HARDWARE_LINK_ID_LIST = string.Join(",", HARDWARE_LINK_ID_LIST.ToArray()); p.ROOM_ID_LIST = string.Join(",", ROOM_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Criteria_InList ( string DESCRIPTION, List<long?> OUTLET_ID_LIST, List<long?> UI_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OUTLET_ID_LIST = string.Join(",", OUTLET_ID_LIST.ToArray()); p.UI_ID_LIST = string.Join(",", UI_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Where_InList ( string DESCRIPTION, List<long?> OUTLET_ID_LIST, List<long?> UI_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OUTLET_ID_LIST = string.Join(",", OUTLET_ID_LIST.ToArray()); p.UI_ID_LIST = string.Join(",", UI_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Room> Get_Room_By_Criteria_InList ( string NAME, List<Int32?> FLOOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.FLOOR_ID_LIST = string.Join(",", FLOOR_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Room> Get_Room_By_Where_InList ( string NAME, List<Int32?> FLOOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.FLOOR_ID_LIST = string.Join(",", FLOOR_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Criteria_InList_Adv ( string PLC_ADDRESS, List<Int32?> PLC_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.PLC_ADDRESS = PLC_ADDRESS; p.PLC_ID_LIST = string.Join(",", PLC_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Plc = new Plc();
o.My_Plc.PLC_ID = GV<Int32>(X["T_PLC_PLC_ID"]);o.My_Plc.LOCATION = GV<String>(X["T_PLC_LOCATION"]);o.My_Plc.PORT = GV<String>(X["T_PLC_PORT"]);o.My_Plc.TYPE = GV<String>(X["T_PLC_TYPE"]);o.My_Plc.CURRENT_INPUTS = GV<Int32>(X["T_PLC_CURRENT_INPUTS"]);o.My_Plc.MAX_INPUTS = GV<Int32>(X["T_PLC_MAX_INPUTS"]);o.My_Plc.CURRENT_OUTPUTS = GV<Int32>(X["T_PLC_CURRENT_OUTPUTS"]);o.My_Plc.MAX_OUTPUTS = GV<Int32>(X["T_PLC_MAX_OUTPUTS"]);o.My_Plc.ENTRY_USER_ID = GV<Int64>(X["T_PLC_ENTRY_USER_ID"]);o.My_Plc.ENTRY_DATE = GV<String>(X["T_PLC_ENTRY_DATE"]);o.My_Plc.OWNER_ID = GV<Int32>(X["T_PLC_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Hardware_link> Get_Hardware_link_By_Where_InList_Adv ( string PLC_ADDRESS, List<Int32?> PLC_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Hardware_link> oList = new List<Hardware_link>();
dynamic p = new ExpandoObject();
p.PLC_ADDRESS = PLC_ADDRESS; p.PLC_ID_LIST = string.Join(",", PLC_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_HARDWARE_LINK_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Hardware_link o = new Hardware_link();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Plc = new Plc();
o.My_Plc.PLC_ID = GV<Int32>(X["T_PLC_PLC_ID"]);o.My_Plc.LOCATION = GV<String>(X["T_PLC_LOCATION"]);o.My_Plc.PORT = GV<String>(X["T_PLC_PORT"]);o.My_Plc.TYPE = GV<String>(X["T_PLC_TYPE"]);o.My_Plc.CURRENT_INPUTS = GV<Int32>(X["T_PLC_CURRENT_INPUTS"]);o.My_Plc.MAX_INPUTS = GV<Int32>(X["T_PLC_MAX_INPUTS"]);o.My_Plc.CURRENT_OUTPUTS = GV<Int32>(X["T_PLC_CURRENT_OUTPUTS"]);o.My_Plc.MAX_OUTPUTS = GV<Int32>(X["T_PLC_MAX_OUTPUTS"]);o.My_Plc.ENTRY_USER_ID = GV<Int64>(X["T_PLC_ENTRY_USER_ID"]);o.My_Plc.ENTRY_DATE = GV<String>(X["T_PLC_ENTRY_DATE"]);o.My_Plc.OWNER_ID = GV<Int32>(X["T_PLC_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet> Get_Outlet_By_Criteria_InList_Adv ( string NAME, string CURRENT_VALUE, List<Int32?> OUTLET_TYPE_ID_LIST, List<long?> HARDWARE_LINK_ID_LIST, List<Int32?> ROOM_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.CURRENT_VALUE = CURRENT_VALUE; p.OUTLET_TYPE_ID_LIST = string.Join(",", OUTLET_TYPE_ID_LIST.ToArray()); p.HARDWARE_LINK_ID_LIST = string.Join(",", HARDWARE_LINK_ID_LIST.ToArray()); p.ROOM_ID_LIST = string.Join(",", ROOM_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet_type = new Outlet_type();
o.My_Outlet_type.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_TYPE_OUTLET_TYPE_ID"]);o.My_Outlet_type.NAME = GV<String>(X["T_OUTLET_TYPE_NAME"]);o.My_Outlet_type.MIN_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MIN_VALUE"]);o.My_Outlet_type.MAX_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MAX_VALUE"]);o.My_Outlet_type.IS_DIGITAL = GV<Boolean>(X["T_OUTLET_TYPE_IS_DIGITAL"]);o.My_Outlet_type.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_TYPE_ENTRY_USER_ID"]);o.My_Outlet_type.ENTRY_DATE = GV<String>(X["T_OUTLET_TYPE_ENTRY_DATE"]);o.My_Outlet_type.OWNER_ID = GV<Int32>(X["T_OUTLET_TYPE_OWNER_ID"]);
o.My_Hardware_link = new Hardware_link();
o.My_Hardware_link.HARDWARE_LINK_ID = GV<Int64>(X["T_HARDWARE_LINK_HARDWARE_LINK_ID"]);o.My_Hardware_link.PLC_ID = GV<Int32>(X["T_HARDWARE_LINK_PLC_ID"]);o.My_Hardware_link.PLC_ADDRESS = GV<String>(X["T_HARDWARE_LINK_PLC_ADDRESS"]);o.My_Hardware_link.ENTRY_USER_ID = GV<Int64>(X["T_HARDWARE_LINK_ENTRY_USER_ID"]);o.My_Hardware_link.ENTRY_DATE = GV<String>(X["T_HARDWARE_LINK_ENTRY_DATE"]);o.My_Hardware_link.OWNER_ID = GV<Int32>(X["T_HARDWARE_LINK_OWNER_ID"]);
o.My_Room = new Room();
o.My_Room.ROOM_ID = GV<Int32>(X["T_ROOM_ROOM_ID"]);o.My_Room.FLOOR_ID = GV<Int32>(X["T_ROOM_FLOOR_ID"]);o.My_Room.NAME = GV<String>(X["T_ROOM_NAME"]);o.My_Room.ENTRY_USER_ID = GV<Int64>(X["T_ROOM_ENTRY_USER_ID"]);o.My_Room.ENTRY_DATE = GV<String>(X["T_ROOM_ENTRY_DATE"]);o.My_Room.OWNER_ID = GV<Int32>(X["T_ROOM_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet> Get_Outlet_By_Where_InList_Adv ( string NAME, string CURRENT_VALUE, List<Int32?> OUTLET_TYPE_ID_LIST, List<long?> HARDWARE_LINK_ID_LIST, List<Int32?> ROOM_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet> oList = new List<Outlet>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.CURRENT_VALUE = CURRENT_VALUE; p.OUTLET_TYPE_ID_LIST = string.Join(",", OUTLET_TYPE_ID_LIST.ToArray()); p.HARDWARE_LINK_ID_LIST = string.Join(",", HARDWARE_LINK_ID_LIST.ToArray()); p.ROOM_ID_LIST = string.Join(",", ROOM_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet o = new Outlet();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet_type = new Outlet_type();
o.My_Outlet_type.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_TYPE_OUTLET_TYPE_ID"]);o.My_Outlet_type.NAME = GV<String>(X["T_OUTLET_TYPE_NAME"]);o.My_Outlet_type.MIN_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MIN_VALUE"]);o.My_Outlet_type.MAX_VALUE = GV<Int32>(X["T_OUTLET_TYPE_MAX_VALUE"]);o.My_Outlet_type.IS_DIGITAL = GV<Boolean>(X["T_OUTLET_TYPE_IS_DIGITAL"]);o.My_Outlet_type.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_TYPE_ENTRY_USER_ID"]);o.My_Outlet_type.ENTRY_DATE = GV<String>(X["T_OUTLET_TYPE_ENTRY_DATE"]);o.My_Outlet_type.OWNER_ID = GV<Int32>(X["T_OUTLET_TYPE_OWNER_ID"]);
o.My_Hardware_link = new Hardware_link();
o.My_Hardware_link.HARDWARE_LINK_ID = GV<Int64>(X["T_HARDWARE_LINK_HARDWARE_LINK_ID"]);o.My_Hardware_link.PLC_ID = GV<Int32>(X["T_HARDWARE_LINK_PLC_ID"]);o.My_Hardware_link.PLC_ADDRESS = GV<String>(X["T_HARDWARE_LINK_PLC_ADDRESS"]);o.My_Hardware_link.ENTRY_USER_ID = GV<Int64>(X["T_HARDWARE_LINK_ENTRY_USER_ID"]);o.My_Hardware_link.ENTRY_DATE = GV<String>(X["T_HARDWARE_LINK_ENTRY_DATE"]);o.My_Hardware_link.OWNER_ID = GV<Int32>(X["T_HARDWARE_LINK_OWNER_ID"]);
o.My_Room = new Room();
o.My_Room.ROOM_ID = GV<Int32>(X["T_ROOM_ROOM_ID"]);o.My_Room.FLOOR_ID = GV<Int32>(X["T_ROOM_FLOOR_ID"]);o.My_Room.NAME = GV<String>(X["T_ROOM_NAME"]);o.My_Room.ENTRY_USER_ID = GV<Int64>(X["T_ROOM_ENTRY_USER_ID"]);o.My_Room.ENTRY_DATE = GV<String>(X["T_ROOM_ENTRY_DATE"]);o.My_Room.OWNER_ID = GV<Int32>(X["T_ROOM_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Criteria_InList_Adv ( string DESCRIPTION, List<long?> OUTLET_ID_LIST, List<long?> UI_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OUTLET_ID_LIST = string.Join(",", OUTLET_ID_LIST.ToArray()); p.UI_ID_LIST = string.Join(",", UI_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet = new Outlet();
o.My_Outlet.OUTLET_ID = GV<Int64>(X["T_OUTLET_OUTLET_ID"]);o.My_Outlet.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_OUTLET_TYPE_ID"]);o.My_Outlet.HARDWARE_LINK_ID = GV<Int64>(X["T_OUTLET_HARDWARE_LINK_ID"]);o.My_Outlet.ROOM_ID = GV<Int32>(X["T_OUTLET_ROOM_ID"]);o.My_Outlet.NAME = GV<String>(X["T_OUTLET_NAME"]);o.My_Outlet.CURRENT_VALUE = GV<String>(X["T_OUTLET_CURRENT_VALUE"]);o.My_Outlet.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_ENTRY_USER_ID"]);o.My_Outlet.ENTRY_DATE = GV<String>(X["T_OUTLET_ENTRY_DATE"]);o.My_Outlet.OWNER_ID = GV<Int32>(X["T_OUTLET_OWNER_ID"]);
o.My_Ui = new Ui();
o.My_Ui.UI_ID = GV<Int64>(X["T_UI_UI_ID"]);o.My_Ui.COLOR = GV<String>(X["T_UI_COLOR"]);o.My_Ui.OTHER = GV<String>(X["T_UI_OTHER"]);o.My_Ui.ENTRY_USER_ID = GV<Int64>(X["T_UI_ENTRY_USER_ID"]);o.My_Ui.ENTRY_DATE = GV<String>(X["T_UI_ENTRY_DATE"]);o.My_Ui.OWNER_ID = GV<Int32>(X["T_UI_OWNER_ID"]);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Outlet_ui> Get_Outlet_ui_By_Where_InList_Adv ( string DESCRIPTION, List<long?> OUTLET_ID_LIST, List<long?> UI_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Outlet_ui> oList = new List<Outlet_ui>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OUTLET_ID_LIST = string.Join(",", OUTLET_ID_LIST.ToArray()); p.UI_ID_LIST = string.Join(",", UI_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OUTLET_UI_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Outlet_ui o = new Outlet_ui();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Outlet = new Outlet();
o.My_Outlet.OUTLET_ID = GV<Int64>(X["T_OUTLET_OUTLET_ID"]);o.My_Outlet.OUTLET_TYPE_ID = GV<Int32>(X["T_OUTLET_OUTLET_TYPE_ID"]);o.My_Outlet.HARDWARE_LINK_ID = GV<Int64>(X["T_OUTLET_HARDWARE_LINK_ID"]);o.My_Outlet.ROOM_ID = GV<Int32>(X["T_OUTLET_ROOM_ID"]);o.My_Outlet.NAME = GV<String>(X["T_OUTLET_NAME"]);o.My_Outlet.CURRENT_VALUE = GV<String>(X["T_OUTLET_CURRENT_VALUE"]);o.My_Outlet.ENTRY_USER_ID = GV<Int64>(X["T_OUTLET_ENTRY_USER_ID"]);o.My_Outlet.ENTRY_DATE = GV<String>(X["T_OUTLET_ENTRY_DATE"]);o.My_Outlet.OWNER_ID = GV<Int32>(X["T_OUTLET_OWNER_ID"]);
o.My_Ui = new Ui();
o.My_Ui.UI_ID = GV<Int64>(X["T_UI_UI_ID"]);o.My_Ui.COLOR = GV<String>(X["T_UI_COLOR"]);o.My_Ui.OTHER = GV<String>(X["T_UI_OTHER"]);o.My_Ui.ENTRY_USER_ID = GV<Int64>(X["T_UI_ENTRY_USER_ID"]);o.My_Ui.ENTRY_DATE = GV<String>(X["T_UI_ENTRY_DATE"]);o.My_Ui.OWNER_ID = GV<Int32>(X["T_UI_OWNER_ID"]);
o.My_User = new User();
o.My_User.USER_ID = GV<Int64>(X["T_USER_USER_ID"]);o.My_User.OWNER_ID = GV<Int32>(X["T_USER_OWNER_ID"]);o.My_User.USERNAME = GV<String>(X["T_USER_USERNAME"]);o.My_User.PASSWORD = GV<String>(X["T_USER_PASSWORD"]);o.My_User.USER_TYPE_CODE = GV<String>(X["T_USER_USER_TYPE_CODE"]);o.My_User.IS_ACTIVE = GV<Boolean>(X["T_USER_IS_ACTIVE"]);o.My_User.ENTRY_DATE = GV<String>(X["T_USER_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Room> Get_Room_By_Criteria_InList_Adv ( string NAME, List<Int32?> FLOOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.FLOOR_ID_LIST = string.Join(",", FLOOR_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Floor = new Floor();
o.My_Floor.FLOOR_ID = GV<Int32>(X["T_FLOOR_FLOOR_ID"]);o.My_Floor.NAME = GV<String>(X["T_FLOOR_NAME"]);o.My_Floor.ENTRY_USER_ID = GV<Int64>(X["T_FLOOR_ENTRY_USER_ID"]);o.My_Floor.ENTRY_DATE = GV<String>(X["T_FLOOR_ENTRY_DATE"]);o.My_Floor.OWNER_ID = GV<Int32>(X["T_FLOOR_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Room> Get_Room_By_Where_InList_Adv ( string NAME, List<Int32?> FLOOR_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Room> oList = new List<Room>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.FLOOR_ID_LIST = string.Join(",", FLOOR_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ROOM_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Room o = new Room();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Floor = new Floor();
o.My_Floor.FLOOR_ID = GV<Int32>(X["T_FLOOR_FLOOR_ID"]);o.My_Floor.NAME = GV<String>(X["T_FLOOR_NAME"]);o.My_Floor.ENTRY_USER_ID = GV<Int64>(X["T_FLOOR_ENTRY_USER_ID"]);o.My_Floor.ENTRY_DATE = GV<String>(X["T_FLOOR_ENTRY_DATE"]);o.My_Floor.OWNER_ID = GV<Int32>(X["T_FLOOR_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public void Delete_Floor ( Int32? FLOOR_ID)
{
var p = new { FLOOR_ID = FLOOR_ID };
ExecuteDelete("UPG_DELETE_FLOOR", p);
}
public void Delete_Hardware_link ( long? HARDWARE_LINK_ID)
{
var p = new { HARDWARE_LINK_ID = HARDWARE_LINK_ID };
ExecuteDelete("UPG_DELETE_HARDWARE_LINK", p);
}
public void Delete_Outlet ( long? OUTLET_ID)
{
var p = new { OUTLET_ID = OUTLET_ID };
ExecuteDelete("UPG_DELETE_OUTLET", p);
}
public void Delete_Outlet_type ( Int32? OUTLET_TYPE_ID)
{
var p = new { OUTLET_TYPE_ID = OUTLET_TYPE_ID };
ExecuteDelete("UPG_DELETE_OUTLET_TYPE", p);
}
public void Delete_Outlet_ui ( long? OUTLET_UI_ID)
{
var p = new { OUTLET_UI_ID = OUTLET_UI_ID };
ExecuteDelete("UPG_DELETE_OUTLET_UI", p);
}
public void Delete_Owner ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_OWNER", p);
}
public void Delete_Plc ( Int32? PLC_ID)
{
var p = new { PLC_ID = PLC_ID };
ExecuteDelete("UPG_DELETE_PLC", p);
}
public void Delete_Room ( Int32? ROOM_ID)
{
var p = new { ROOM_ID = ROOM_ID };
ExecuteDelete("UPG_DELETE_ROOM", p);
}
public void Delete_Ui ( long? UI_ID)
{
var p = new { UI_ID = UI_ID };
ExecuteDelete("UPG_DELETE_UI", p);
}
public void Delete_Uploaded_file ( long? UPLOADED_FILE_ID)
{
var p = new { UPLOADED_FILE_ID = UPLOADED_FILE_ID };
ExecuteDelete("UPG_DELETE_UPLOADED_FILE", p);
}
public void Delete_User ( long? USER_ID)
{
var p = new { USER_ID = USER_ID };
ExecuteDelete("UPG_DELETE_USER", p);
}
public void Delete_Floor_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_FLOOR_BY_OWNER_ID", p);
}
public void Delete_Hardware_link_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_HARDWARE_LINK_BY_OWNER_ID", p);
}
public void Delete_Hardware_link_By_PLC_ID ( Int32? PLC_ID)
{
var p = new { PLC_ID = PLC_ID };
ExecuteDelete("UPG_DELETE_HARDWARE_LINK_BY_PLC_ID", p);
}
public void Delete_Outlet_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_OUTLET_BY_OWNER_ID", p);
}
public void Delete_Outlet_By_ROOM_ID ( Int32? ROOM_ID)
{
var p = new { ROOM_ID = ROOM_ID };
ExecuteDelete("UPG_DELETE_OUTLET_BY_ROOM_ID", p);
}
public void Delete_Outlet_By_OUTLET_TYPE_ID ( Int32? OUTLET_TYPE_ID)
{
var p = new { OUTLET_TYPE_ID = OUTLET_TYPE_ID };
ExecuteDelete("UPG_DELETE_OUTLET_BY_OUTLET_TYPE_ID", p);
}
public void Delete_Outlet_By_HARDWARE_LINK_ID ( long? HARDWARE_LINK_ID)
{
var p = new { HARDWARE_LINK_ID = HARDWARE_LINK_ID };
ExecuteDelete("UPG_DELETE_OUTLET_BY_HARDWARE_LINK_ID", p);
}
public void Delete_Outlet_type_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_OUTLET_TYPE_BY_OWNER_ID", p);
}
public void Delete_Outlet_ui_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_OUTLET_UI_BY_OWNER_ID", p);
}
public void Delete_Outlet_ui_By_OUTLET_ID ( long? OUTLET_ID)
{
var p = new { OUTLET_ID = OUTLET_ID };
ExecuteDelete("UPG_DELETE_OUTLET_UI_BY_OUTLET_ID", p);
}
public void Delete_Outlet_ui_By_UI_ID ( long? UI_ID)
{
var p = new { UI_ID = UI_ID };
ExecuteDelete("UPG_DELETE_OUTLET_UI_BY_UI_ID", p);
}
public void Delete_Outlet_ui_By_USER_ID ( long? USER_ID)
{
var p = new { USER_ID = USER_ID };
ExecuteDelete("UPG_DELETE_OUTLET_UI_BY_USER_ID", p);
}
public void Delete_Plc_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_PLC_BY_OWNER_ID", p);
}
public void Delete_Room_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_ROOM_BY_OWNER_ID", p);
}
public void Delete_Room_By_FLOOR_ID ( Int32? FLOOR_ID)
{
var p = new { FLOOR_ID = FLOOR_ID };
ExecuteDelete("UPG_DELETE_ROOM_BY_FLOOR_ID", p);
}
public void Delete_Ui_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_UI_BY_OWNER_ID", p);
}
public void Delete_Uploaded_file_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_UPLOADED_FILE_BY_OWNER_ID", p);
}
public void Delete_Uploaded_file_By_REL_ENTITY ( string REL_ENTITY)
{
var p = new { REL_ENTITY = REL_ENTITY };
ExecuteDelete("UPG_DELETE_UPLOADED_FILE_BY_REL_ENTITY", p);
}
public void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY ( string REL_ENTITY, long? REL_KEY)
{
var p = new { REL_ENTITY = REL_ENTITY,REL_KEY = REL_KEY };
ExecuteDelete("UPG_DELETE_UPLOADED_FILE_BY_REL_ENTITY_REL_KEY", p);
}
public void Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD ( string REL_ENTITY, long? REL_KEY, string REL_FIELD)
{
var p = new { REL_ENTITY = REL_ENTITY,REL_KEY = REL_KEY,REL_FIELD = REL_FIELD };
ExecuteDelete("UPG_DELETE_UPLOADED_FILE_BY_REL_ENTITY_REL_KEY_REL_FIELD", p);
}
public void Delete_User_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_USER_BY_OWNER_ID", p);
}
public void Delete_User_By_USERNAME ( string USERNAME)
{
var p = new { USERNAME = USERNAME };
ExecuteDelete("UPG_DELETE_USER_BY_USERNAME", p);
}
public Int32? Edit_Floor ( Int32? FLOOR_ID, string NAME, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Floor oFloor = new Floor();
oFloor.FLOOR_ID = FLOOR_ID;oFloor.NAME = NAME;oFloor.ENTRY_USER_ID = ENTRY_USER_ID;oFloor.ENTRY_DATE = ENTRY_DATE;oFloor.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_FLOOR", oFloor, "FLOOR_ID");
return oFloor.FLOOR_ID;
}
public long? Edit_Hardware_link ( long? HARDWARE_LINK_ID, Int32? PLC_ID, string PLC_ADDRESS, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Hardware_link oHardware_link = new Hardware_link();
oHardware_link.HARDWARE_LINK_ID = HARDWARE_LINK_ID;oHardware_link.PLC_ID = PLC_ID;oHardware_link.PLC_ADDRESS = PLC_ADDRESS;oHardware_link.ENTRY_USER_ID = ENTRY_USER_ID;oHardware_link.ENTRY_DATE = ENTRY_DATE;oHardware_link.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_HARDWARE_LINK", oHardware_link, "HARDWARE_LINK_ID");
return oHardware_link.HARDWARE_LINK_ID;
}
public long? Edit_Outlet ( long? OUTLET_ID, Int32? OUTLET_TYPE_ID, long? HARDWARE_LINK_ID, Int32? ROOM_ID, string NAME, string CURRENT_VALUE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Outlet oOutlet = new Outlet();
oOutlet.OUTLET_ID = OUTLET_ID;oOutlet.OUTLET_TYPE_ID = OUTLET_TYPE_ID;oOutlet.HARDWARE_LINK_ID = HARDWARE_LINK_ID;oOutlet.ROOM_ID = ROOM_ID;oOutlet.NAME = NAME;oOutlet.CURRENT_VALUE = CURRENT_VALUE;oOutlet.ENTRY_USER_ID = ENTRY_USER_ID;oOutlet.ENTRY_DATE = ENTRY_DATE;oOutlet.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_OUTLET", oOutlet, "OUTLET_ID");
return oOutlet.OUTLET_ID;
}
public Int32? Edit_Outlet_type ( Int32? OUTLET_TYPE_ID, string NAME, Int32? MIN_VALUE, Int32? MAX_VALUE, bool? IS_DIGITAL, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Outlet_type oOutlet_type = new Outlet_type();
oOutlet_type.OUTLET_TYPE_ID = OUTLET_TYPE_ID;oOutlet_type.NAME = NAME;oOutlet_type.MIN_VALUE = MIN_VALUE;oOutlet_type.MAX_VALUE = MAX_VALUE;oOutlet_type.IS_DIGITAL = IS_DIGITAL;oOutlet_type.ENTRY_USER_ID = ENTRY_USER_ID;oOutlet_type.ENTRY_DATE = ENTRY_DATE;oOutlet_type.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_OUTLET_TYPE", oOutlet_type, "OUTLET_TYPE_ID");
return oOutlet_type.OUTLET_TYPE_ID;
}
public long? Edit_Outlet_ui ( long? OUTLET_UI_ID, long? OUTLET_ID, long? UI_ID, long? USER_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION)
{
Outlet_ui oOutlet_ui = new Outlet_ui();
oOutlet_ui.OUTLET_UI_ID = OUTLET_UI_ID;oOutlet_ui.OUTLET_ID = OUTLET_ID;oOutlet_ui.UI_ID = UI_ID;oOutlet_ui.USER_ID = USER_ID;oOutlet_ui.ENTRY_USER_ID = ENTRY_USER_ID;oOutlet_ui.ENTRY_DATE = ENTRY_DATE;oOutlet_ui.OWNER_ID = OWNER_ID;oOutlet_ui.DESCRIPTION = DESCRIPTION;
ExecuteEdit("UPG_EDIT_OUTLET_UI", oOutlet_ui, "OUTLET_UI_ID");
return oOutlet_ui.OUTLET_UI_ID;
}
public Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE)
{
Owner oOwner = new Owner();
oOwner.OWNER_ID = OWNER_ID;oOwner.CODE = CODE;oOwner.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE;oOwner.DESCRIPTION = DESCRIPTION;oOwner.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_OWNER", oOwner, "OWNER_ID");
return oOwner.OWNER_ID;
}
public Int32? Edit_Plc ( Int32? PLC_ID, string LOCATION, string PORT, string TYPE, Int32? CURRENT_INPUTS, Int32? MAX_INPUTS, Int32? CURRENT_OUTPUTS, Int32? MAX_OUTPUTS, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Plc oPlc = new Plc();
oPlc.PLC_ID = PLC_ID;oPlc.LOCATION = LOCATION;oPlc.PORT = PORT;oPlc.TYPE = TYPE;oPlc.CURRENT_INPUTS = CURRENT_INPUTS;oPlc.MAX_INPUTS = MAX_INPUTS;oPlc.CURRENT_OUTPUTS = CURRENT_OUTPUTS;oPlc.MAX_OUTPUTS = MAX_OUTPUTS;oPlc.ENTRY_USER_ID = ENTRY_USER_ID;oPlc.ENTRY_DATE = ENTRY_DATE;oPlc.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_PLC", oPlc, "PLC_ID");
return oPlc.PLC_ID;
}
public Int32? Edit_Room ( Int32? ROOM_ID, Int32? FLOOR_ID, string NAME, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Room oRoom = new Room();
oRoom.ROOM_ID = ROOM_ID;oRoom.FLOOR_ID = FLOOR_ID;oRoom.NAME = NAME;oRoom.ENTRY_USER_ID = ENTRY_USER_ID;oRoom.ENTRY_DATE = ENTRY_DATE;oRoom.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_ROOM", oRoom, "ROOM_ID");
return oRoom.ROOM_ID;
}
public long? Edit_Ui ( long? UI_ID, string COLOR, string OTHER, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Ui oUi = new Ui();
oUi.UI_ID = UI_ID;oUi.COLOR = COLOR;oUi.OTHER = OTHER;oUi.ENTRY_USER_ID = ENTRY_USER_ID;oUi.ENTRY_DATE = ENTRY_DATE;oUi.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_UI", oUi, "UI_ID");
return oUi.UI_ID;
}
public long? Edit_Uploaded_file ( long? UPLOADED_FILE_ID, string REL_ENTITY, long? REL_KEY, string REL_FIELD, Int32? SIZE, string EXTENSION, string URL, string STAMP, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Uploaded_file oUploaded_file = new Uploaded_file();
oUploaded_file.UPLOADED_FILE_ID = UPLOADED_FILE_ID;oUploaded_file.REL_ENTITY = REL_ENTITY;oUploaded_file.REL_KEY = REL_KEY;oUploaded_file.REL_FIELD = REL_FIELD;oUploaded_file.SIZE = SIZE;oUploaded_file.EXTENSION = EXTENSION;oUploaded_file.URL = URL;oUploaded_file.STAMP = STAMP;oUploaded_file.ENTRY_USER_ID = ENTRY_USER_ID;oUploaded_file.ENTRY_DATE = ENTRY_DATE;oUploaded_file.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_UPLOADED_FILE", oUploaded_file, "UPLOADED_FILE_ID");
return oUploaded_file.UPLOADED_FILE_ID;
}
public long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE)
{
User oUser = new User();
oUser.USER_ID = USER_ID;oUser.OWNER_ID = OWNER_ID;oUser.USERNAME = USERNAME;oUser.PASSWORD = PASSWORD;oUser.USER_TYPE_CODE = USER_TYPE_CODE;oUser.IS_ACTIVE = IS_ACTIVE;oUser.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_USER", oUser, "USER_ID");
return oUser.USER_ID;
}
public List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_DISTINCT_SETUP_TBL", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.TBL_NAME = GV<String>(X["TBL_NAME"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LAST_VALUE = GV<Int64>(X["LAST_VALUE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_TBL_SETUP ()
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_TBL_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_FLOOR ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_FLOOR", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.FLOOR_ID = GV<Int32>(X["FLOOR_ID"]);o.NAME = GV<String>(X["NAME"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_HARDWARE_LINK ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_HARDWARE_LINK", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.HARDWARE_LINK_ID = GV<Int64>(X["HARDWARE_LINK_ID"]);o.PLC_ID = GV<Int32>(X["PLC_ID"]);o.PLC_ADDRESS = GV<String>(X["PLC_ADDRESS"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_OUTLET ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_OUTLET", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OUTLET_ID = GV<Int64>(X["OUTLET_ID"]);o.OUTLET_TYPE_ID = GV<Int32>(X["OUTLET_TYPE_ID"]);o.HARDWARE_LINK_ID = GV<Int64>(X["HARDWARE_LINK_ID"]);o.ROOM_ID = GV<Int32>(X["ROOM_ID"]);o.NAME = GV<String>(X["NAME"]);o.CURRENT_VALUE = GV<String>(X["CURRENT_VALUE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_OUTLET_TYPE ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_OUTLET_TYPE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OUTLET_TYPE_ID = GV<Int32>(X["OUTLET_TYPE_ID"]);o.NAME = GV<String>(X["NAME"]);o.MIN_VALUE = GV<Int32>(X["MIN_VALUE"]);o.MAX_VALUE = GV<Int32>(X["MAX_VALUE"]);o.IS_DIGITAL = GV<Boolean>(X["IS_DIGITAL"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_OUTLET_UI ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_OUTLET_UI", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OUTLET_UI_ID = GV<Int64>(X["OUTLET_UI_ID"]);o.OUTLET_ID = GV<Int64>(X["OUTLET_ID"]);o.UI_ID = GV<Int64>(X["UI_ID"]);o.USER_ID = GV<Int64>(X["USER_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_OWNER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.CODE = GV<String>(X["CODE"]);o.MAINTENANCE_DUE_DATE = GV<String>(X["MAINTENANCE_DUE_DATE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_PLC ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_PLC", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.PLC_ID = GV<Int32>(X["PLC_ID"]);o.LOCATION = GV<String>(X["LOCATION"]);o.PORT = GV<String>(X["PORT"]);o.TYPE = GV<String>(X["TYPE"]);o.CURRENT_INPUTS = GV<Int32>(X["CURRENT_INPUTS"]);o.MAX_INPUTS = GV<Int32>(X["MAX_INPUTS"]);o.CURRENT_OUTPUTS = GV<Int32>(X["CURRENT_OUTPUTS"]);o.MAX_OUTPUTS = GV<Int32>(X["MAX_OUTPUTS"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_ROOM ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_ROOM", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROOM_ID = GV<Int32>(X["ROOM_ID"]);o.FLOOR_ID = GV<Int32>(X["FLOOR_ID"]);o.NAME = GV<String>(X["NAME"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_UI ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_UI", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.UI_ID = GV<Int64>(X["UI_ID"]);o.COLOR = GV<String>(X["COLOR"]);o.OTHER = GV<String>(X["OTHER"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_UPLOADED_FILE ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_UPLOADED_FILE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.UPLOADED_FILE_ID = GV<Int64>(X["UPLOADED_FILE_ID"]);o.REL_ENTITY = GV<String>(X["REL_ENTITY"]);o.REL_KEY = GV<Int64>(X["REL_KEY"]);o.REL_FIELD = GV<String>(X["REL_FIELD"]);o.SIZE = GV<Int32>(X["SIZE"]);o.EXTENSION = GV<String>(X["EXTENSION"]);o.URL = GV<String>(X["URL"]);o.STAMP = GV<String>(X["STAMP"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_USER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.USER_TYPE_CODE = GV<String>(X["USER_TYPE_CODE"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.EXISTS = EXISTS;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_CHECK_USER_EXISTENCE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
EXISTS = p.EXISTS;
return oList;
}
public List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME; p.ISSYSTEM = ISSYSTEM; p.ISDELETEABLE = ISDELETEABLE; p.ISUPDATEABLE = ISUPDATEABLE; p.ISVISIBLE = ISVISIBLE; p.ISDELETED = ISDELETED; p.DISPLAY_ORDER = DISPLAY_ORDER; p.CODE_VALUE_EN = CODE_VALUE_EN; p.CODE_VALUE_FR = CODE_VALUE_FR; p.CODE_VALUE_AR = CODE_VALUE_AR; p.ENTRY_DATE = ENTRY_DATE; p.ENTRY_USER_ID = ENTRY_USER_ID; p.NOTES = NOTES;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EDIT_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_PARAMETERS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.PARAM_NAME = GV<String>(X["PARAM_NAME"]);o.PARAM_TYPE = GV<String>(X["PARAM_TYPE"]);o.IS_OUTPUT = GV<Boolean>(X["IS_OUTPUT"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_RESULT_SCHEMA", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.COLUMN_NAME = GV<String>(X["COLUMN_NAME"]);o.COLUMN_TYPE = GV<String>(X["COLUMN_TYPE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.@tableName = @tableName;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GENERATE_INSERT_STATEMENTS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_ALL_DATA ( string USERNAME, string PASSWORD)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_ALL_DATA", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.USER_TYPE_CODE = GV<String>(X["USER_TYPE_CODE"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE; p.VALUE = VALUE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
VALUE = p.VALUE;
return oList;
}
public List<dynamic> UP_GET_OUTLET_UI_BY_OUTLET_USER ( long? OUTLET_ID, long? USER_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OUTLET_ID = OUTLET_ID; p.USER_ID = USER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_OUTLET_UI_BY_OUTLET_USER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OUTLET_UI_ID = GV<Int64>(X["OUTLET_UI_ID"]);o.OUTLET_ID = GV<Int64>(X["OUTLET_ID"]);o.UI_ID = GV<Int64>(X["UI_ID"]);o.USER_ID = GV<Int64>(X["USER_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.ISDELETED = ISDELETED; p.ISVISIBLE = ISVISIBLE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRIES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_USER_BY_CREDENTIALS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_UPDATE_OUTLET_UI_BY_OUTLET_USER ( long? UI_ID, long? OUTLET_ID, long? USER_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.UI_ID = UI_ID; p.OUTLET_ID = OUTLET_ID; p.USER_ID = USER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_UPDATE_OUTLET_UI_BY_OUTLET_USER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
}
}
