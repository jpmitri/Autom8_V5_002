using BLC;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declaration And Initialization Section.
            string _ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
            BLCInitializer oBLCInitializer = new();
            oBLCInitializer.ConnectionString = _ConnectionString;
            oBLCInitializer.OwnerID = 1;
            oBLCInitializer.UserID = 1;
            oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
            BLC.BLC oBLC = new(oBLCInitializer);
            string str_Option = string.Empty;
            string str_BH_ID = string.Empty;
            string str_AC_ID = string.Empty;
            string str_Bucket_Name = string.Empty;
            string str_Main_Folder_Path = string.Empty;
            Tools.Tools oTools = new Tools.Tools();
            #endregion

            while(true)
            {
                Console.WriteLine("Enter An Option:");
                Console.WriteLine("001 --> Generate Colors");
                Console.WriteLine("002 --> Create Outlet Type");
                Console.WriteLine("003 --> Create Outlet");
                Console.WriteLine("004 --> Create New User");
                Console.WriteLine("005 --> Import From Old With Auto Init");
                Console.WriteLine("006 --> Import From Old With Default Floor And Room");
                Console.WriteLine("007 --> Import From Old With Default Floor And Room With Out User Generation");
                Console.WriteLine("009 --> Init Test");
                Console.WriteLine("010 --> Test Digital");
                Console.WriteLine("011 --> Test Dimmer");
                Console.WriteLine("012 --> Test Curtain");
                Console.WriteLine("Exit --> To Exit");
                str_Option = Console.ReadLine();
                if(str_Option == "Exit")
                { return; }

                switch(str_Option)
                {
                    case "001":
                        {
                            string[] colors = ConfigurationManager.AppSettings["COLORS"].Split(",");
                            Params_Edit_Ui_List ui_List = new();
                            ui_List.My_List_To_Edit = new();
                            foreach(String color in colors)
                            {
                                BLC.Ui ui = new();
                                ui.UI_ID = -1;
                                ui.COLOR = color;
                                ui.OTHER = "";
                                ui.OWNER_ID = 1;
                                ui.ENTRY_USER_ID = 1;
                                ui.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
                                ui_List.My_List_To_Edit.Add(ui);
                            }
                            oBLC.Edit_Ui_List(ui_List);
                        }
                        break;
                    case "002":
                        {
                            Params_Edit_Outlet_type_List params_Edit_Outlet_Type_List = new();
                            params_Edit_Outlet_Type_List.My_List_To_Edit = new();
                            Outlet_type outlet_Type0 = new();
                            outlet_Type0.OUTLET_TYPE_ID = -1;
                            outlet_Type0.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
                            outlet_Type0.ENTRY_USER_ID = 1;
                            outlet_Type0.OWNER_ID = 1;
                            outlet_Type0.IS_DIGITAL = true;
                            outlet_Type0.MIN_VALUE = 0;
                            outlet_Type0.MAX_VALUE = 1;
                            outlet_Type0.NAME = "Digital Outlet TwinCat 2";
                            params_Edit_Outlet_Type_List.My_List_To_Edit.Add(outlet_Type0);
                            Outlet_type outlet_Type1 = new();
                            outlet_Type1.OUTLET_TYPE_ID = -1;
                            outlet_Type1.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
                            outlet_Type1.ENTRY_USER_ID = 1;
                            outlet_Type1.OWNER_ID = 1;
                            outlet_Type1.IS_DIGITAL = false;
                            outlet_Type1.MIN_VALUE = 0;
                            outlet_Type1.MAX_VALUE = 255;
                            outlet_Type1.NAME = "Analogue Outlet TwinCat 2";
                            params_Edit_Outlet_Type_List.My_List_To_Edit.Add(outlet_Type1);
                            Outlet_type outlet_Type2 = new();
                            outlet_Type2.OUTLET_TYPE_ID = -1;
                            outlet_Type2.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
                            outlet_Type2.ENTRY_USER_ID = 1;
                            outlet_Type2.OWNER_ID = 1;
                            outlet_Type2.IS_DIGITAL = true;
                            outlet_Type2.MIN_VALUE = 0;
                            outlet_Type2.MAX_VALUE = 1;
                            outlet_Type2.NAME = "Curtain Outlet TwinCat 2";
                            params_Edit_Outlet_Type_List.My_List_To_Edit.Add(outlet_Type2);
                            Outlet_type outlet_Type3 = new();
                            outlet_Type3.OUTLET_TYPE_ID = -1;
                            outlet_Type3.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
                            outlet_Type3.ENTRY_USER_ID = 1;
                            outlet_Type3.OWNER_ID = 1;
                            outlet_Type3.IS_DIGITAL = true;
                            outlet_Type3.MIN_VALUE = 0;
                            outlet_Type3.MAX_VALUE = 1;
                            outlet_Type3.NAME = "Door Outlet TwinCat 2";
                            params_Edit_Outlet_Type_List.My_List_To_Edit.Add(outlet_Type3);
                            oBLC.Edit_Outlet_type_List(params_Edit_Outlet_Type_List);
                        }
                        break;
                    case "003":
                        {
                            try
                            {
                                Outlet outlet = new();
                                outlet.OUTLET_ID = -1;
                                Console.WriteLine("Enter Room ID");
                                outlet.ROOM_ID = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter The Outlet Type");
                                Console.WriteLine("1 For Digital");
                                Console.WriteLine("2 For Analogue");
                                Console.WriteLine("3 For Curtain");
                                Console.WriteLine("4 For Door");
                                outlet.OUTLET_TYPE_ID = int.Parse(Console.ReadLine());
                                while(outlet.OUTLET_TYPE_ID is not (>= 0 and <= 4))
                                {
                                    Console.WriteLine("Incorrect Outlet Type Entered");
                                    Console.WriteLine("Enter The Outlet Type");
                                    Console.WriteLine("1 For Digital");
                                    Console.WriteLine("2 For Analogue");
                                    Console.WriteLine("3 For Curtain");
                                    Console.WriteLine("4 For Door");
                                    outlet.OUTLET_TYPE_ID = int.Parse(Console.ReadLine());
                                }
                                Console.WriteLine("Enter The Hardware Link ID");
                                outlet.HARDWARE_LINK_ID = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter The Outlet Name");
                                outlet.NAME = Console.ReadLine();
                                Console.WriteLine("Enter The Current Value");
                                Console.WriteLine("Must Be 0(Off) or 1(On) If Digital / Curtain / Door");
                                Console.WriteLine("Must Be Between 0 and 255 If Analogue");
                                string value = Console.ReadLine();
                                while(true)
                                {
                                    if(outlet.OUTLET_TYPE_ID is not 2)
                                    {
                                        if(int.Parse(value) is 0 or 1)
                                        {
                                            break;
                                        }
                                        Console.WriteLine("Value Must Be 0 or 1");
                                        Console.WriteLine("Please Enter The Value Again");
                                        value = Console.ReadLine();
                                    }
                                    else
                                    {
                                        if(int.Parse(value) is >= 0 and <= 255)
                                        {
                                            break;
                                        }
                                        Console.WriteLine("Value Must Be Between 0 and 255");
                                        Console.WriteLine("Please Enter The Value Again");
                                        value = Console.ReadLine();
                                    }
                                }
                                outlet.CURRENT_VALUE = value;
                                oBLC.Edit_Outlet(outlet);
                            }
                            catch(Exception e)
                            {

                                Console.WriteLine(e.Message);
                            }
                        }
                        break;
                    case "004":
                        {
                            User user = new();
                            user.USER_ID = -1;
                            user.OWNER_ID = 1;
                            Console.WriteLine("Enter Username");
                            user.USERNAME = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            user.PASSWORD = Console.ReadLine();
                            user.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
                            user.IS_ACTIVE = true;
                            user.USER_TYPE_CODE = "002";
                            oBLC.Edit_User(user);
                        }
                        break;
                    case "005":
                        {
                            #region Colors
                            string[] colors = {
                                        "#809bceff",
                                        "#55b493ff",
                                        "#ffaa89ff",
                                        "#95b8d1ff",
                                        "#55bcbbff",
                                        "#ff92d5ff",
                                        "#dd5e5eff",
                                        "#6e7582ff",
                                        "#e6913bff",
                                        "#6886c5ff",
                                        "#6e5773ff",
                                        "#745c97ff",
                                        "#e2afffff",
                                        "#a2d2ffff",
                                        "#ffafccff",
                                        "#0096c7ff",
                                        "#446583ff",
                                        "#9f6af8ff",
                                        "#86e8d2ff",
                                        "#6e5bd8ff"
                                        };
                            Params_Edit_Ui_List ui_List = new();
                            ui_List.My_List_To_Edit = new();
                            foreach(String color in colors)
                            {
                                BLC.Ui ui = new();
                                ui.UI_ID = -1;
                                ui.COLOR = color;
                                ui.OTHER = "";
                                ui.OWNER_ID = 1;
                                ui.ENTRY_USER_ID = 1;
                                ui.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
                                ui_List.My_List_To_Edit.Add(ui);
                            }
                            oBLC.Edit_Ui_List(ui_List);
                            #endregion
                            #region Outlet Type
                            Params_Edit_Outlet_type_List params_Edit_Outlet_Type_List = new();
                            params_Edit_Outlet_Type_List.My_List_To_Edit = new();
                            Outlet_type outlet_Type0 = new();
                            outlet_Type0.OUTLET_TYPE_ID = -1;
                            outlet_Type0.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
                            outlet_Type0.ENTRY_USER_ID = 1;
                            outlet_Type0.OWNER_ID = 1;
                            outlet_Type0.IS_DIGITAL = true;
                            outlet_Type0.MIN_VALUE = 0;
                            outlet_Type0.MAX_VALUE = 1;
                            outlet_Type0.NAME = "Digital Outlet TwinCat 2";
                            params_Edit_Outlet_Type_List.My_List_To_Edit.Add(outlet_Type0);
                            Outlet_type outlet_Type1 = new();
                            outlet_Type1.OUTLET_TYPE_ID = -1;
                            outlet_Type1.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
                            outlet_Type1.ENTRY_USER_ID = 1;
                            outlet_Type1.OWNER_ID = 1;
                            outlet_Type1.IS_DIGITAL = false;
                            outlet_Type1.MIN_VALUE = 0;
                            outlet_Type1.MAX_VALUE = 255;
                            outlet_Type1.NAME = "Analogue Outlet TwinCat 2";
                            params_Edit_Outlet_Type_List.My_List_To_Edit.Add(outlet_Type1);
                            Outlet_type outlet_Type2 = new();
                            outlet_Type2.OUTLET_TYPE_ID = -1;
                            outlet_Type2.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
                            outlet_Type2.ENTRY_USER_ID = 1;
                            outlet_Type2.OWNER_ID = 1;
                            outlet_Type2.IS_DIGITAL = true;
                            outlet_Type2.MIN_VALUE = 0;
                            outlet_Type2.MAX_VALUE = 1;
                            outlet_Type2.NAME = "Curtain Outlet TwinCat 2";
                            params_Edit_Outlet_Type_List.My_List_To_Edit.Add(outlet_Type2);
                            Outlet_type outlet_Type3 = new();
                            outlet_Type3.OUTLET_TYPE_ID = -1;
                            outlet_Type3.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
                            outlet_Type3.ENTRY_USER_ID = 1;
                            outlet_Type3.OWNER_ID = 1;
                            outlet_Type3.IS_DIGITAL = true;
                            outlet_Type3.MIN_VALUE = 0;
                            outlet_Type3.MAX_VALUE = 1;
                            outlet_Type3.NAME = "Door Outlet TwinCat 2";
                            params_Edit_Outlet_Type_List.My_List_To_Edit.Add(outlet_Type3);
                            oBLC.Edit_Outlet_type_List(params_Edit_Outlet_Type_List);
                            #endregion
                            #region Add Default Floor And Room
                            Floor floor = new();
                            floor.FLOOR_ID = -1;
                            floor.NAME = "Default Floor";
                            oBLC.Edit_Floor(floor);
                            Room room = new();
                            room.ROOM_ID = -1;
                            room.FLOOR_ID = floor.FLOOR_ID;
                            room.NAME = "Default Room";
                            oBLC.Edit_Room(room);
                            #endregion
                            #region Import
                            string OldDB = @"" + ConfigurationManager.AppSettings["CONN_STR_OLD"];
                            using(SqlConnection connection = new(OldDB))
                            {
                                Plc plc = new();
                                using(SqlCommand command = new())
                                {
                                    command.CommandText = "SELECT AMSID, PORT FROM TBL_BOARD";
                                    command.Connection = connection;
                                    connection.Open();
                                    SqlDataReader reader = command.ExecuteReader();
                                    if(reader.HasRows)
                                    {
                                        while(reader.Read())
                                        {
                                            plc.PLC_ID = -1;
                                            plc.PORT = reader["PORT"].ToString();
                                            plc.LOCATION = reader["AMSID"].ToString();
                                            plc.CURRENT_INPUTS = -1;
                                            plc.MAX_INPUTS = -1;
                                            plc.CURRENT_OUTPUTS = -1;
                                            plc.MAX_OUTPUTS = -1;
                                            plc.TYPE = "Twincat2";
                                        }
                                        oBLC.Edit_Plc(plc);
                                    }
                                    reader.Close();
                                    connection.Close();
                                }
                                using(SqlCommand command = new())
                                {
                                    command.CommandText = "SELECT TBL_ZONE.NAME, TBL_OUTLET.OUTLET_TYPE_CODE, TBL_OUTLET_DIGITAL.PLC_VARIABLE, TBL_OUTLET_DIGITAL.DIGITAL_TYPE_CODE FROM ((TBL_OUTLET INNER JOIN TBL_ZONE ON TBL_OUTLET.OUTLET_ID = TBL_ZONE.OUTLET_ID) INNER JOIN TBL_OUTLET_DIGITAL ON TBL_OUTLET.OUTLET_ID = TBL_OUTLET_DIGITAL.OUTLET_ID) WHERE ((TBL_OUTLET.OUTLET_TYPE_CODE = '001' AND (TBL_OUTLET_DIGITAL.DIGITAL_TYPE_CODE = '001' OR TBL_OUTLET_DIGITAL.DIGITAL_TYPE_CODE = '002' OR TBL_OUTLET_DIGITAL.DIGITAL_TYPE_CODE = '003')))";
                                    command.Connection = connection;
                                    connection.Open();
                                    SqlDataReader reader = command.ExecuteReader();
                                    if(reader.HasRows)
                                    {
                                        List<oldDB> oldDBs = new();
                                        while(reader.Read())
                                        {
                                            oldDB old = new();
                                            old.PLC_VARIABLE = "." + reader["PLC_VARIABLE"].ToString();
                                            old.NAME = reader["NAME"].ToString();
                                            old.DIGITAL_TYPE_CODE = reader["DIGITAL_TYPE_CODE"].ToString() switch
                                            {
                                                "001" => 1,
                                                "002" => 3,
                                                "003" => 4,
                                                _ => throw new Exception(reader["DIGITAL_TYPE_CODE"].ToString())
                                            };
                                            oldDBs.Add(old);
                                        }
                                        for(int i = 0; i < oldDBs.Count; i++)
                                        {
                                            if(i != 0)
                                            {
                                                if(oldDBs[i].PLC_VARIABLE != oldDBs[i - 1].PLC_VARIABLE)
                                                {
                                                    bool isCurtain = false;
                                                    Hardware_link hl = new();
                                                    hl.HARDWARE_LINK_ID = -1;
                                                    hl.PLC_ID = plc.PLC_ID;
                                                    hl.PLC_ADDRESS = oldDBs[i].PLC_VARIABLE;
                                                    if(oldDBs[i].DIGITAL_TYPE_CODE == 3 && oldDBs[i + 1].DIGITAL_TYPE_CODE == 3)
                                                    {
                                                        hl.PLC_ADDRESS += "," + oldDBs[i + 1].PLC_VARIABLE;
                                                        isCurtain = true;
                                                    }
                                                    oBLC.Edit_Hardware_link(hl);
                                                    Outlet outlet = new();
                                                    outlet.OUTLET_ID = -1;
                                                    outlet.CURRENT_VALUE = "0";
                                                    outlet.ROOM_ID = room.ROOM_ID;
                                                    outlet.NAME = oldDBs[i].NAME;
                                                    outlet.OUTLET_TYPE_ID = oldDBs[i].DIGITAL_TYPE_CODE;
                                                    outlet.HARDWARE_LINK_ID = hl.HARDWARE_LINK_ID;
                                                    oBLC.Edit_Outlet(outlet);
                                                    if(isCurtain == true)
                                                    { i++; }
                                                    isCurtain = false;

                                                }
                                            }
                                        }
                                    }
                                    reader.Close();
                                    connection.Close();
                                }
                                using(SqlCommand command = new())
                                {
                                    command.CommandText = "SELECT TBL_ZONE.NAME, TBL_OUTLET.OUTLET_TYPE_CODE, TBL_OUTLET_DIMMER.DIM_VARIABLE FROM ((TBL_OUTLET INNER JOIN TBL_ZONE ON TBL_OUTLET.OUTLET_ID = TBL_ZONE.OUTLET_ID) INNER JOIN TBL_OUTLET_DIMMER ON TBL_OUTLET.OUTLET_ID = TBL_OUTLET_DIMMER.OUTLET_ID) WHERE TBL_OUTLET.OUTLET_TYPE_CODE = '002'";
                                    command.Connection = connection;
                                    connection.Open();
                                    SqlDataReader reader = command.ExecuteReader();
                                    if(reader.HasRows)
                                    {
                                        while(reader.Read())
                                        {
                                            Hardware_link hl = new();
                                            hl.HARDWARE_LINK_ID = -1;
                                            hl.PLC_ID = plc.PLC_ID;
                                            hl.PLC_ADDRESS = "." + reader["PLC_VARIABLE"].ToString();
                                            oBLC.Edit_Hardware_link(hl);
                                            Outlet outlet = new();
                                            outlet.OUTLET_ID = -1;
                                            outlet.CURRENT_VALUE = "0";
                                            outlet.ROOM_ID = room.ROOM_ID;
                                            outlet.NAME = reader["NAME"].ToString();
                                            outlet.OUTLET_TYPE_ID = 2;
                                            outlet.HARDWARE_LINK_ID = hl.HARDWARE_LINK_ID;
                                            oBLC.Edit_Outlet(outlet);
                                        }
                                    }
                                    reader.Close();
                                    connection.Close();
                                }
                            }
                            #endregion
                            #region Create First User
                            User user = new();
                            user.USER_ID = -1;
                            user.OWNER_ID = 1;
                            Console.WriteLine("Enter Username");
                            user.USERNAME = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            user.PASSWORD = Console.ReadLine();
                            user.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
                            user.IS_ACTIVE = true;
                            user.USER_TYPE_CODE = "002";
                            oBLC.Edit_User(user);
                            #endregion
                        }
                        break;
                    case "006":
                        {
                            #region Add Default Floor And Room
                            Floor floor = new();
                            floor.FLOOR_ID = -1;
                            floor.NAME = "Default Floor";
                            oBLC.Edit_Floor(floor);
                            Room room = new();
                            room.ROOM_ID = -1;
                            room.FLOOR_ID = floor.FLOOR_ID;
                            room.NAME = "Default Room";
                            oBLC.Edit_Room(room);
                            #endregion
                            #region Import
                            string OldDB = @"" + ConfigurationManager.AppSettings["CONN_STR_OLD"];
                            using(SqlConnection connection = new(OldDB))
                            {
                                Plc plc = new();
                                using(SqlCommand command = new())
                                {
                                    command.CommandText = "SELECT AMSID, PORT FROM TBL_BOARD";
                                    command.Connection = connection;
                                    connection.Open();
                                    SqlDataReader reader = command.ExecuteReader();
                                    if(reader.HasRows)
                                    {
                                        while(reader.Read())
                                        {
                                            plc.PLC_ID = -1;
                                            plc.PORT = reader["PORT"].ToString();
                                            plc.LOCATION = reader["AMSID"].ToString();
                                            plc.CURRENT_INPUTS = -1;
                                            plc.MAX_INPUTS = -1;
                                            plc.CURRENT_OUTPUTS = -1;
                                            plc.MAX_OUTPUTS = -1;
                                            plc.TYPE = "Twincat2";
                                        }
                                        oBLC.Edit_Plc(plc);
                                    }
                                    reader.Close();
                                    connection.Close();
                                }
                                using(SqlCommand command = new())
                                {
                                    command.CommandText = "SELECT TBL_ZONE.NAME, TBL_OUTLET.OUTLET_TYPE_CODE, TBL_OUTLET_DIGITAL.PLC_VARIABLE, TBL_OUTLET_DIGITAL.DIGITAL_TYPE_CODE FROM ((TBL_OUTLET INNER JOIN TBL_ZONE ON TBL_OUTLET.OUTLET_ID = TBL_ZONE.OUTLET_ID) INNER JOIN TBL_OUTLET_DIGITAL ON TBL_OUTLET.OUTLET_ID = TBL_OUTLET_DIGITAL.OUTLET_ID) WHERE ((TBL_OUTLET.OUTLET_TYPE_CODE = '001' AND (TBL_OUTLET_DIGITAL.DIGITAL_TYPE_CODE = '001' OR TBL_OUTLET_DIGITAL.DIGITAL_TYPE_CODE = '002' OR TBL_OUTLET_DIGITAL.DIGITAL_TYPE_CODE = '003')))";
                                    command.Connection = connection;
                                    connection.Open();
                                    SqlDataReader reader = command.ExecuteReader();
                                    if(reader.HasRows)
                                    {
                                        List<oldDB> oldDBs = new();
                                        while(reader.Read())
                                        {
                                            oldDB old = new();
                                            old.PLC_VARIABLE = "." + reader["PLC_VARIABLE"].ToString();
                                            old.NAME = reader["NAME"].ToString();
                                            old.DIGITAL_TYPE_CODE = reader["DIGITAL_TYPE_CODE"].ToString() switch
                                            {
                                                "001" => 1,
                                                "002" => 3,
                                                "003" => 4,
                                                _ => throw new Exception(reader["DIGITAL_TYPE_CODE"].ToString())
                                            };
                                            oldDBs.Add(old);
                                        }
                                        for(int i = 0; i < oldDBs.Count; i++)
                                        {
                                            if(i != 0)
                                            {
                                                if(oldDBs[i].PLC_VARIABLE != oldDBs[i - 1].PLC_VARIABLE)
                                                {
                                                    bool isCurtain = false;
                                                    Hardware_link hl = new();
                                                    hl.HARDWARE_LINK_ID = -1;
                                                    hl.PLC_ID = plc.PLC_ID;
                                                    hl.PLC_ADDRESS = oldDBs[i].PLC_VARIABLE;
                                                    if(oldDBs[i].DIGITAL_TYPE_CODE == 3 && oldDBs[i + 1].DIGITAL_TYPE_CODE == 3)
                                                    {
                                                        hl.PLC_ADDRESS += "," + oldDBs[i + 1].PLC_VARIABLE;
                                                        isCurtain = true;
                                                    }
                                                    oBLC.Edit_Hardware_link(hl);
                                                    Outlet outlet = new();
                                                    outlet.OUTLET_ID = -1;
                                                    outlet.CURRENT_VALUE = "0";
                                                    outlet.ROOM_ID = room.ROOM_ID;
                                                    outlet.NAME = oldDBs[i].NAME;
                                                    outlet.OUTLET_TYPE_ID = oldDBs[i].DIGITAL_TYPE_CODE;
                                                    outlet.HARDWARE_LINK_ID = hl.HARDWARE_LINK_ID;
                                                    oBLC.Edit_Outlet(outlet);
                                                    if(isCurtain == true)
                                                    { i++; }
                                                    isCurtain = false;

                                                }
                                            }
                                        }
                                    }
                                    reader.Close();
                                    connection.Close();
                                }
                                using(SqlCommand command = new())
                                {
                                    command.CommandText = "SELECT TBL_ZONE.NAME, TBL_OUTLET.OUTLET_TYPE_CODE, TBL_OUTLET_DIMMER.DIM_VARIABLE FROM ((TBL_OUTLET INNER JOIN TBL_ZONE ON TBL_OUTLET.OUTLET_ID = TBL_ZONE.OUTLET_ID) INNER JOIN TBL_OUTLET_DIMMER ON TBL_OUTLET.OUTLET_ID = TBL_OUTLET_DIMMER.OUTLET_ID) WHERE TBL_OUTLET.OUTLET_TYPE_CODE = '002'";
                                    command.Connection = connection;
                                    connection.Open();
                                    SqlDataReader reader = command.ExecuteReader();
                                    if(reader.HasRows)
                                    {
                                        while(reader.Read())
                                        {
                                            Hardware_link hl = new();
                                            hl.HARDWARE_LINK_ID = -1;
                                            hl.PLC_ID = plc.PLC_ID;
                                            hl.PLC_ADDRESS = "." + reader["PLC_VARIABLE"].ToString();
                                            oBLC.Edit_Hardware_link(hl);
                                            Outlet outlet = new();
                                            outlet.OUTLET_ID = -1;
                                            outlet.CURRENT_VALUE = "0";
                                            outlet.ROOM_ID = room.ROOM_ID;
                                            outlet.NAME = reader["NAME"].ToString();
                                            outlet.OUTLET_TYPE_ID = 2;
                                            outlet.HARDWARE_LINK_ID = hl.HARDWARE_LINK_ID;
                                            oBLC.Edit_Outlet(outlet);
                                        }
                                    }
                                    reader.Close();
                                    connection.Close();
                                }
                            }
                            #endregion
                            #region Create First User
                            User user = new();
                            user.USER_ID = -1;
                            user.OWNER_ID = 1;
                            Console.WriteLine("Enter Username");
                            user.USERNAME = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            user.PASSWORD = Console.ReadLine();
                            user.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
                            user.IS_ACTIVE = true;
                            user.USER_TYPE_CODE = "002";
                            oBLC.Edit_User(user);
                            #endregion
                        }
                        break;
                    case "007":
                        {
                            #region Add Default Floor And Room
                            Floor floor = new();
                            floor.FLOOR_ID = -1;
                            floor.NAME = "Default Floor";
                            oBLC.Edit_Floor(floor);
                            Room room = new();
                            room.ROOM_ID = -1;
                            room.FLOOR_ID = floor.FLOOR_ID;
                            room.NAME = "Default Room";
                            oBLC.Edit_Room(room);
                            #endregion
                            #region Import
                            string OldDB = @"" + ConfigurationManager.AppSettings["CONN_STR_OLD"];
                            using(SqlConnection connection = new(OldDB))
                            {
                                Plc plc = new();
                                using(SqlCommand command = new())
                                {
                                    command.CommandText = "SELECT AMSID, PORT FROM TBL_BOARD";
                                    command.Connection = connection;
                                    connection.Open();
                                    SqlDataReader reader = command.ExecuteReader();
                                    if(reader.HasRows)
                                    {
                                        while(reader.Read())
                                        {
                                            plc.PLC_ID = -1;
                                            plc.PORT = reader["PORT"].ToString();
                                            plc.LOCATION = reader["AMSID"].ToString();
                                            plc.CURRENT_INPUTS = -1;
                                            plc.MAX_INPUTS = -1;
                                            plc.CURRENT_OUTPUTS = -1;
                                            plc.MAX_OUTPUTS = -1;
                                            plc.TYPE = "Twincat2";
                                        }
                                        oBLC.Edit_Plc(plc);
                                    }
                                    reader.Close();
                                    connection.Close();
                                }
                                using(SqlCommand command = new())
                                {
                                    command.CommandText = "SELECT TBL_ZONE.NAME, TBL_OUTLET.OUTLET_TYPE_CODE, TBL_OUTLET_DIGITAL.PLC_VARIABLE, TBL_OUTLET_DIGITAL.DIGITAL_TYPE_CODE FROM ((TBL_OUTLET INNER JOIN TBL_ZONE ON TBL_OUTLET.OUTLET_ID = TBL_ZONE.OUTLET_ID) INNER JOIN TBL_OUTLET_DIGITAL ON TBL_OUTLET.OUTLET_ID = TBL_OUTLET_DIGITAL.OUTLET_ID) WHERE ((TBL_OUTLET.OUTLET_TYPE_CODE = '001' AND (TBL_OUTLET_DIGITAL.DIGITAL_TYPE_CODE = '001' OR TBL_OUTLET_DIGITAL.DIGITAL_TYPE_CODE = '002' OR TBL_OUTLET_DIGITAL.DIGITAL_TYPE_CODE = '003')))";
                                    command.Connection = connection;
                                    connection.Open();
                                    SqlDataReader reader = command.ExecuteReader();
                                    if(reader.HasRows)
                                    {
                                        List<oldDB> oldDBs = new();
                                        while(reader.Read())
                                        {
                                            oldDB old = new();
                                            old.PLC_VARIABLE = "." + reader["PLC_VARIABLE"].ToString();
                                            old.NAME = reader["NAME"].ToString();
                                            old.DIGITAL_TYPE_CODE = reader["DIGITAL_TYPE_CODE"].ToString() switch
                                            {
                                                "001" => 1,
                                                "002" => 3,
                                                "003" => 4,
                                                _ => throw new Exception(reader["DIGITAL_TYPE_CODE"].ToString())
                                            };
                                            oldDBs.Add(old);
                                        }
                                        for(int i = 0; i < oldDBs.Count; i++)
                                        {
                                            if(i != 0)
                                            {
                                                if(oldDBs[i].PLC_VARIABLE != oldDBs[i - 1].PLC_VARIABLE)
                                                {
                                                    bool isCurtain = false;
                                                    Hardware_link hl = new();
                                                    hl.HARDWARE_LINK_ID = -1;
                                                    hl.PLC_ID = plc.PLC_ID;
                                                    hl.PLC_ADDRESS = oldDBs[i].PLC_VARIABLE;
                                                    if(oldDBs[i].DIGITAL_TYPE_CODE == 3 && oldDBs[i + 1].DIGITAL_TYPE_CODE == 3)
                                                    {
                                                        hl.PLC_ADDRESS += "," + oldDBs[i + 1].PLC_VARIABLE;
                                                        isCurtain = true;
                                                    }
                                                    oBLC.Edit_Hardware_link(hl);
                                                    Outlet outlet = new();
                                                    outlet.OUTLET_ID = -1;
                                                    outlet.CURRENT_VALUE = "0";
                                                    outlet.ROOM_ID = room.ROOM_ID;
                                                    outlet.NAME = oldDBs[i].NAME;
                                                    outlet.OUTLET_TYPE_ID = oldDBs[i].DIGITAL_TYPE_CODE;
                                                    outlet.HARDWARE_LINK_ID = hl.HARDWARE_LINK_ID;
                                                    oBLC.Edit_Outlet(outlet);
                                                    if(isCurtain == true)
                                                    { i++; }
                                                    isCurtain = false;

                                                }
                                            }
                                        }
                                    }
                                    reader.Close();
                                    connection.Close();
                                }
                                using(SqlCommand command = new())
                                {
                                    command.CommandText = "SELECT TBL_ZONE.NAME, TBL_OUTLET.OUTLET_TYPE_CODE, TBL_OUTLET_DIMMER.DIM_VARIABLE FROM ((TBL_OUTLET INNER JOIN TBL_ZONE ON TBL_OUTLET.OUTLET_ID = TBL_ZONE.OUTLET_ID) INNER JOIN TBL_OUTLET_DIMMER ON TBL_OUTLET.OUTLET_ID = TBL_OUTLET_DIMMER.OUTLET_ID) WHERE TBL_OUTLET.OUTLET_TYPE_CODE = '002'";
                                    command.Connection = connection;
                                    connection.Open();
                                    SqlDataReader reader = command.ExecuteReader();
                                    if(reader.HasRows)
                                    {
                                        while(reader.Read())
                                        {
                                            Hardware_link hl = new();
                                            hl.HARDWARE_LINK_ID = -1;
                                            hl.PLC_ID = plc.PLC_ID;
                                            hl.PLC_ADDRESS = "." + reader["PLC_VARIABLE"].ToString();
                                            oBLC.Edit_Hardware_link(hl);
                                            Outlet outlet = new();
                                            outlet.OUTLET_ID = -1;
                                            outlet.CURRENT_VALUE = "0";
                                            outlet.ROOM_ID = room.ROOM_ID;
                                            outlet.NAME = reader["NAME"].ToString();
                                            outlet.OUTLET_TYPE_ID = 2;
                                            outlet.HARDWARE_LINK_ID = hl.HARDWARE_LINK_ID;
                                            oBLC.Edit_Outlet(outlet);
                                        }
                                    }
                                    reader.Close();
                                    connection.Close();
                                }
                            }
                            #endregion
                        }
                        break;
                    case "009":
                        {
                            Params_Edit_Outlet_List params_Edit_Outlet_List = new();
                            params_Edit_Outlet_List.My_List_To_Edit = new();
                            Floor floor = new();
                            floor.FLOOR_ID = -1;
                            floor.NAME = "Test Floor 1";
                            oBLC.Edit_Floor(floor);
                            Room room = new();
                            room.ROOM_ID = -1;
                            room.FLOOR_ID = floor.FLOOR_ID;
                            room.NAME = "Test Room";
                            oBLC.Edit_Room(room);
                            Outlet outletDigital = new();
                            outletDigital.OUTLET_ID = -1;
                            outletDigital.ROOM_ID = room.ROOM_ID;
                            outletDigital.OUTLET_TYPE_ID = 1;
                            outletDigital.HARDWARE_LINK_ID = 1;
                            outletDigital.NAME = "Digital Test";
                            outletDigital.CURRENT_VALUE = "0";
                            params_Edit_Outlet_List.My_List_To_Edit.Add(outletDigital);
                            Outlet outletAnalog = new();
                            outletAnalog.OUTLET_ID = -1;
                            outletAnalog.ROOM_ID = room.ROOM_ID;
                            outletAnalog.OUTLET_TYPE_ID = 2;
                            outletAnalog.HARDWARE_LINK_ID = 2;
                            outletAnalog.NAME = "Analog Test";
                            outletAnalog.CURRENT_VALUE = "0";
                            params_Edit_Outlet_List.My_List_To_Edit.Add(outletAnalog);
                            Outlet outletCurtain = new();
                            outletCurtain.OUTLET_ID = -1;
                            outletCurtain.ROOM_ID = room.ROOM_ID;
                            outletCurtain.OUTLET_TYPE_ID = 3;
                            outletCurtain.HARDWARE_LINK_ID = 1;
                            outletCurtain.NAME = "Curtain Test";
                            outletCurtain.CURRENT_VALUE = "0";
                            params_Edit_Outlet_List.My_List_To_Edit.Add(outletCurtain);
                            oBLC.Edit_Outlet_List(params_Edit_Outlet_List);
                        }
                        break;
                    case "010":
                        {
                            Params_Get_All_Data params_Get_All_Data = new();
                            params_Get_All_Data.My_UserInfo = new();
                            params_Get_All_Data.My_UserInfo.UserName = "Admin";
                            params_Get_All_Data.My_UserInfo.Password = "Admin";
                            All_Data data = oBLC.Get_All_Data(params_Get_All_Data);
                            Outlet outlet = new();
                            outlet = data.Floors[1].MyRooms[0].MyOutlets[0];
                            outlet.CURRENT_VALUE = "1";
                            oBLC.Edit_Outlet(outlet);
                            System.Threading.Thread.Sleep(1000);
                            outlet.CURRENT_VALUE = "0";
                            oBLC.Edit_Outlet(outlet);
                        }
                        break;
                    case "011":
                        {
                            DigitalWrite();
                        }
                        break;
                    case "012":
                        {
                            Params_Get_All_Data params_Get_All_Data = new();
                            params_Get_All_Data.My_UserInfo = new();
                            params_Get_All_Data.My_UserInfo.UserName = "Admin";
                            params_Get_All_Data.My_UserInfo.Password = "Admin";
                            All_Data data = oBLC.Get_All_Data(params_Get_All_Data);
                            Outlet outlet = new();
                            outlet = data.Floors[1].MyRooms[0].MyOutlets[2];
                            outlet.CURRENT_VALUE = "1";
                            oBLC.Edit_Outlet(outlet);
                        }
                        break;
                }
            }
        }
        public static async void DigitalWrite()
        {
            string _ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
            BLCInitializer oBLCInitializer = new BLC.BLCInitializer();
            oBLCInitializer.ConnectionString = _ConnectionString;
            oBLCInitializer.OwnerID = 1;
            oBLCInitializer.UserID = 1;
            oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
            BLC.BLC oBLC = new BLC.BLC(oBLCInitializer);
            Params_Get_All_Data params_Get_All_Data = new();
            All_Data data = new();
            Outlet outlet = new();
            params_Get_All_Data.My_UserInfo = new();
            params_Get_All_Data.My_UserInfo.UserName = "Admin";
            params_Get_All_Data.My_UserInfo.Password = "Admin";
            data = oBLC.Get_All_Data(params_Get_All_Data);
            outlet = data.Floors[1].MyRooms[0].MyOutlets[1];
            Task t = Task.Factory.StartNew(
                () =>
                {
                    for(int i = 0; i <= 255; i++)
                    {
                        outlet.CURRENT_VALUE = i + "";
                        oBLC.Edit_Outlet(outlet);
                        System.Threading.Thread.Sleep(200);
                    }
                }
                );
            await t;
        }
        public partial class oldDB
        {
            public string PLC_VARIABLE { get; set; }
            public string NAME { get; set; }
            public int DIGITAL_TYPE_CODE { get; set; }
        }
    }
}
