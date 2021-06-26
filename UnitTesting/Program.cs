using BLC;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Declaration And Initialization Section.
            string _ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
            BLC.BLCInitializer oBLCInitializer = new BLC.BLCInitializer();
            oBLCInitializer.ConnectionString = _ConnectionString;
            oBLCInitializer.OwnerID = 1;
            oBLCInitializer.UserID = 1;
            oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
            BLC.BLC oBLC = new BLC.BLC(oBLCInitializer);
            string str_Option = string.Empty;
            string str_BH_ID = string.Empty;
            string str_AC_ID = string.Empty;
            string str_Bucket_Name = string.Empty;
            string str_Main_Folder_Path = string.Empty;
            Tools.Tools oTools = new Tools.Tools();
            #endregion

            Console.WriteLine("Enter An Option:");
            Console.WriteLine("001 --> Generate Colors");
            Console.WriteLine("002 --> Create Outlet Type");
            Console.WriteLine("003 --> Create Outlet");

            Console.WriteLine("009 --> Init Test");

            Console.WriteLine("010 --> Test Digital");
            Console.WriteLine("011 --> Test Dimmer");
            Console.WriteLine("012 --> Test Curtain");

            Console.WriteLine("Exit --> To Exit");



            while (true)
            {
                str_Option = Console.ReadLine();
                if(str_Option=="Exit")
                { return; }
                Params_Edit_Ui_List ui_List = new();
                ui_List.My_List_To_Edit = new();
                Params_Edit_Outlet_type_List params_Edit_Outlet_Type_List = new();
                params_Edit_Outlet_Type_List.My_List_To_Edit = new();
                Params_Edit_Floor_List params_Edit_Floor_List = new();
                params_Edit_Floor_List.My_List_To_Edit = new();
                Params_Edit_Room_List params_Edit_Room_List = new();
                params_Edit_Room_List.My_List_To_Edit = new();
                Params_Edit_Outlet_List params_Edit_Outlet_List = new();
                params_Edit_Outlet_List.My_List_To_Edit = new();
                Params_Get_All_Data params_Get_All_Data = new();
                All_Data data = new();
                Outlet outlet = new();

                switch (str_Option)
                {
                    case "001":
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
                        ui_List.My_List_To_Edit = new();
                        foreach (String color in colors)
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
                        break;
                    case "002":
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
                        break;
                    case "003":
                        break;
                    case "009":
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
                        break;
                    case "010":
                        params_Get_All_Data.My_UserInfo = new();
                        params_Get_All_Data.My_UserInfo.UserName = "Admin";
                        params_Get_All_Data.My_UserInfo.Password = "Admin";
                        data= oBLC.Get_All_Data(params_Get_All_Data);
                        outlet = new();
                        outlet = data.Floors[1].MyRooms[0].MyOutlets[0];
                        outlet.CURRENT_VALUE = "1";
                        oBLC.Edit_Outlet(outlet);
                        System.Threading.Thread.Sleep(1000);
                        outlet.CURRENT_VALUE = "0";
                        oBLC.Edit_Outlet(outlet);
                        break;
                    case "011":
                        DigitalWrite();
                        break;
                    case "012":
                        params_Get_All_Data.My_UserInfo = new();
                        params_Get_All_Data.My_UserInfo.UserName = "Admin";
                        params_Get_All_Data.My_UserInfo.Password = "Admin";
                        data = oBLC.Get_All_Data(params_Get_All_Data);
                        outlet = new();
                        outlet = data.Floors[1].MyRooms[0].MyOutlets[2];
                        outlet.CURRENT_VALUE = "1";
                        oBLC.Edit_Outlet(outlet);
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
                    for (int i = 0; i <= 255; i++)
                    {
                        outlet.CURRENT_VALUE = i + "";
                        oBLC.Edit_Outlet(outlet);
                        System.Threading.Thread.Sleep(200);
                    }
                }
                );
            await t;
        }
    }
}
