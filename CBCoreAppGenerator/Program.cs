using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Net;

namespace CodeGenerator
{
    internal class Program
    {
        #region Members
        private static readonly String _ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
        private static readonly DataContext oDataContext = new(_ConnectionString);
        private static readonly CodeBoosterClientNS.CodeBoosterClient oCodeBoosterClient = new(oDataContext);
        private static readonly CodeBooster oCodeBooster = oCodeBoosterClient.My_CodeBooster;
        #endregion
        #region Main
        private static void Main()
        {

            #region Declaration And Initialization Section.
            Tools.Tools oTools = new();
            Hierarchy oHierarchy = new();
            OneToMany oOneToMany = new();
            List<String> oList_ChildTables = new();
            Hierarchy oApplicationHierarchy = new();
            // Initialization.
            // ---------------------------------------------------------------------   
            oCodeBooster.Tables_Excluded_From_Generatrion_Process = new();
            oCodeBooster.KeysMapper = new();
            oCodeBooster.APIMethodsGenerationMode = Enum_APIMethodsGenerationMode.Selection;
            oCodeBooster.APIMethodsSelection = new();
            oCodeBooster.Methods_With_Events = new();
            oCodeBooster.DefaultRecordsToCreate = new();
            oCodeBooster.Tables_Static_Data = new();
            oCodeBooster.NonSetup_Fields = new();
            oCodeBooster.Tables_To_Create_Get_By_Hierarchy = new();
            oCodeBooster.Tables_Exluded_From_12M_Hanlder = new();
            oCodeBooster.AssemblyPath = ConfigurationManager.AppSettings["BLC_PATH"];
            oCodeBooster.Is_Generate_API_Caller = true;
            oCodeBooster.Is_Generate_Kotlin_API_Caller = true;
            oCodeBooster.Is_Generate_Swift_API_Caller = true;
            oCodeBooster.Android_Package_Name = "com.example.roni.myapplication";
            oCodeBooster.Is_Apply_Minification = false;
            oCodeBooster.Is_Show_Notifications_In_Console = true;
            oCodeBooster.Is_Create_DB_Demo = false;
            oCodeBoosterClient.Is_Handle_Custom_Procedures = true;
            oCodeBoosterClient.Authenticate_User();

            Params_ConvertTypeSchemaToUIFields oParams_ConvertTypeSchemaToUIFields = new();
            Search_AdvancedProp oSearch_AdvancedProp = new();
            WebClient oWebClient = new();
            UIFields oUIFields = new();
            // ---------------------------------------------------------------------   


            #region Exluded Tables From Generation Process
            oCodeBooster.Tables_Excluded_From_Generatrion_Process = new();
            //oCodeBooster.Tables_Excluded_From_Generatrion_Process.Add("[TBL_MENU]");
            //oCodeGenerator.Tables_Excluded_From_Generatrion_Process.Add("[TBL_ACCOUNT]");
            #endregion
            #region Excluded Properties From Generation Process
            oCodeBooster.Properties_Excluded_From_Generation_Process = new();
            //oCodeBooster.Properties_Excluded_From_Generation_Process.Add("[TBL_LEG_PRODUCT]");
            //oCodeBooster.Properties_Excluded_From_Generation_Process.Add("[TBL_LEG_PRODUCT_EINFO]");
            #endregion
            #region Keys Mapper
            //oCodeBooster.KeysMapper.Add("[MAIN_ID]", "[PERSON_ID]");
            //oCodeBooster.KeysMapper.Add("[REL_ID]", "[PERSON_ID]");


            #endregion
            #region Excluding Tables From 12M Hanlder
            oCodeBooster.Tables_Exluded_From_12M_Hanlder = new()
            {
                "[TBL_OWNER]",
                "[TBL_USER]",
                "[TBL_INC]",
                "[TBL_SETUP]"
            };
            #endregion
            #region Handling Static Data            
            //oCodeBooster.Tables_Static_Data.Add("[TBL_LOC_L1]");
            //oCodeBooster.Tables_Static_Data.Add("[TBL_LOC_L2]");
            //oCodeBooster.Tables_Static_Data.Add("[TBL_LOC_L3]");
            //oCodeBooster.Tables_Static_Data.Add("[TBL_LOC_L4]");
            #endregion
            #region Uploaded_files
            //oCodeBooster.Is_Uploaded_File_Feature = true;
            //oCodeBooster.Uploaded_Files_BackEnd_Events = new List<Uploaded_File_BackEnd_Event>();
            //oCodeBooster.Uploaded_Files_BackEnd_Events.Add
            //    (
            //        new Uploaded_File_BackEnd_Event() 
            //        {
            //            TBL_NAME = "[TBL_USER]", 
            //            UI_METHOD_NAME = "Get_User_By_USER_ID", Mode = 1 
            //        }
            //    );
            //oCodeBooster.Uploaded_Files_BackEnd_Events.Add
            //   (
            //       new Uploaded_File_BackEnd_Event()
            //       {
            //           TBL_NAME = "[TBL_USER]",
            //           UI_METHOD_NAME = "Get_User_By_Where",
            //           Mode = 1
            //       }
            //   );            
            #endregion
            #region Defining Non Setup Fields [Fields That ends with CODE by they are not Setup Fields]
            //oCodeBooster.NonSetup_Fields.Add("[LOC_L1_CODE]");
            //oCodeBooster.NonSetup_Fields.Add("[LOC_L2_CODE]");
            //oCodeBooster.NonSetup_Fields.Add("[LOC_L3_CODE]");
            //oCodeBooster.NonSetup_Fields.Add("[LOC_L4_CODE]");
            #endregion
            #region Audit
            //oCodeBooster.List_Tables_To_Audit = new List<string>();
            //oCodeBooster.List_Tables_To_Audit.Add("[TBL_GENERAL_INTERFACE]");
            //oCodeBooster.List_Tables_To_Audit.Add("[TBL_PERMISSION_GROUP]");
            //oCodeBooster.List_Tables_To_Audit.Add("[TBL_PERMISSION]");
            //oCodeBooster.List_Tables_To_Audit.Add("[TBL_USER_PERMISSION]");
            #endregion
            #region Custom Procedures / Queries
            //oCodeBooster.List_Procedure_Info = new List<Procedure_Info>();
            //oCodeBooster.List_Procedure_Info.Add
            //        (
            //            new Procedure_Info()
            //            {
            //                Alias = "Get_Person_Test",
            //                Procedure_Name = "UP_GET_TEST",
            //                Result_CLR_Type = "Person",
            //                Result_Mode = Enum_Procedure_Result_Mode.List
            //            }
            //        );

            //oCodeBooster.List_Procedure_Info.Add
            //       (
            //           new Procedure_Info()
            //           {
            //               Alias = "Get_Stats",
            //               Procedure_Name = "GET_STATS",
            //               Result_CLR_Type = "dynamic",
            //               Result_Mode = Enum_Procedure_Result_Mode.List,
            //               Fields = "METHOD_NAME|AVG|NBR|TOTAL_EXECUTE_TIME"
            //           }
            //       );

            //oCodeBooster.List_Procedure_Info.Add
            //      (
            //          new Procedure_Info()
            //          {
            //              Alias = "Get_Stats_2",
            //              Procedure_Name = "GET_STATS_WITH_PARAM",
            //              Result_CLR_Type = "dynamic",
            //              Result_Mode = Enum_Procedure_Result_Mode.List,
            //              Fields = "METHOD_NAME|AVG|NBR|TOTAL_EXECUTE_TIME"
            //          }
            //      );
            #endregion
            #region ByPassing Notification
            oCodeBooster.ByPassed_PreCheck_Notifications = new()
            {
                new() { TABLE_NAME = "[TBL_USER_TYPE]",COLUMN_NAME = "[USER_TYPE_CODE]",My_PreCheck_To_ByPass = Enum_Precheck_Enum.INVALID_CODE_FIELD },
                new() { TABLE_NAME = "[TBL_PERSON]",COLUMN_NAME = "[CHILD_PERSON_ID]",My_PreCheck_To_ByPass = Enum_Precheck_Enum.MAPPED_KEY }
            };
            #endregion
            #region Caching
            //oCodeBooster.Is_Caching_Enabled = true;
            //oCodeBooster.Methods_With_Caching = new List<Caching_Topology>();
            //oCodeBooster.Methods_With_Caching.Add(new Caching_Topology() { Method_Name = "Get_Car_By_OWNER_ID", Caching_Level = Enum_Caching_Level.Application });

            //oCodeBooster.Cash_Dropper_Collection = new List<string>();
            //oCodeBooster.Cash_Dropper_Collection.Add("[TBL_CAR]");


            #region System
            //oCodeBooster.Methods_With_Caching.Add(new Caching_Topology() { Method_Name = "Get_City_By_COUNTRY_ID_Adv", Caching_Level = Enum_Caching_Level.Application });
            #endregion


            #endregion
            #region Cascade
            oCodeBooster.List_Cascade_Tables = new();
            //oCodeBooster.List_Cascade_Tables.Add(new Cascade() { ParentTable = "[TBL_AC_IMAGE]", ChildTables = new List<string>() { "[TBL_AC_IMAGE_RC]" } });

            #endregion

            #endregion
            #region Body Section
            Console.WriteLine("Enter An Option:");
            Console.WriteLine("001 --> Create SP's & BLC Layer");
            Console.WriteLine("002 --> Generate API / JSON Code");
            Console.WriteLine("003 --> Generate UI");
            Console.WriteLine("051 --> Generate Mobile Native UI");

            String str_Option = Console.ReadLine();


            #region API
            #region Front End
            #region Get
            oCodeBooster.APIMethodsSelection.Add("Get_All_Data");
            oCodeBooster.APIMethodsSelection.Add("Get_User_By_OWNER_ID");
            #endregion
            #region Edit
            oCodeBooster.APIMethodsSelection.Add("Edit_Outlet");//  Manualy Added For SignalR
            oCodeBooster.APIMethodsSelection.Add("Edit_Outlet_ui");
            oCodeBooster.APIMethodsSelection.Add("Edit_User");
            #endregion
            #region Delete
            oCodeBooster.APIMethodsSelection.Add("Delete_User");
            #endregion
            #endregion
            #region Programing App
            #region Get
            oCodeBooster.APIMethodsSelection.Add("Admin_log_in");
            oCodeBooster.APIMethodsSelection.Add("Get_Ui_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Plc_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Hardware_link_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Outlet_type_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Floor_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Room_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Outlet_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Outlet_ui_By_OWNER_ID");
            #endregion
            #region Edit
            oCodeBooster.APIMethodsSelection.Add("Edit_Ui");
            oCodeBooster.APIMethodsSelection.Add("Edit_Plc");
            oCodeBooster.APIMethodsSelection.Add("Edit_Hardware_link");
            oCodeBooster.APIMethodsSelection.Add("Edit_Outlet_type");
            oCodeBooster.APIMethodsSelection.Add("Edit_Floor");
            oCodeBooster.APIMethodsSelection.Add("Edit_Room");

            #endregion
            #region Delete
            oCodeBooster.APIMethodsSelection.Add("Delete_Outlet");
            oCodeBooster.APIMethodsSelection.Add("Delete_Ui");
            oCodeBooster.APIMethodsSelection.Add("Delete_Plc");
            oCodeBooster.APIMethodsSelection.Add("Delete_Hardware_link");
            oCodeBooster.APIMethodsSelection.Add("Delete_Outlet_type");
            oCodeBooster.APIMethodsSelection.Add("Delete_Floor");
            oCodeBooster.APIMethodsSelection.Add("Delete_Room");
            oCodeBooster.APIMethodsSelection.Add("Delete_Outlet_ui");
            #endregion
            #endregion
            #region Service
            oCodeBooster.APIMethodsSelection.Add("Get_Service_Data");
            oCodeBooster.APIMethodsSelection.Add("MonitorPLC");
            #endregion
            #endregion
            #region Advanced Options
            oCodeBooster.Is_By_Criteria_Shadowed = true;
            oCodeBooster.Is_Generate_By_RelatedID_List = true;
            oCodeBooster.By_Related_ID_List_GenerationMode = Enum_By_Related_ID_List_GenerationMode.All;
            oCodeBooster.Is_OnDemand_DALC = true;
            #endregion
            #region AZURE
            //oCodeBooster.Is_AZURE_Enabled = false;
            #endregion
            #region MemCached
            //oCodeBooster.Is_MemCached_Enabled = true;
            #endregion

            oCodeBoosterClient.Local_Patch_Folder = @"F:\Autom8\001-Autom8_V5\003-Patch";
            oCodeBoosterClient.Is_Apply_CB_Rules = true;
            oCodeBoosterClient.Show_Embedded_TSql_Exceptions = false;
            oCodeBooster.Is_Profiling_Enabled = false;
            oCodeBooster.Is_Multilingual_Enabled = false;
            oCodeBooster.Is_BackOffice_Enabled = false;
            oCodeBooster.Is_Offline_Enabled = false;
            oCodeBooster.Is_Summary_Enabled = false;
            oCodeBooster.Is_EnvCode_Enabled = false;
            oCodeBooster.Is_Generate_API_Caller = true;
            oCodeBooster.Is_Generate_Kotlin_API_Caller = true;
            oCodeBooster.Is_Generate_Swift_API_Caller = true;
            oCodeBooster.Is_Embed_USE_DB = true;
            oCodeBooster.UI_Root_Folder = @"C:\inetpub\wwwroot\ClinicPlusWeb\Content";
            oCodeBooster.Is_By_Criteria_Shadowed = true;
            #region Inheritance
            #endregion
            switch(str_Option)
            {
                #region case "001":
                case "001":
                    oCodeBooster.Is_Method_Monitoring_Enabled = false;
                    oCodeBooster.Is_Renamed_Routines_Generation_Stopped = true;
                    oCodeBooster.Is_Count_UDF_Generation_Stopped = true;
                    oCodeBooster.Is_Create_Default_Record_Generation_Stopped = true;
                    oCodeBooster.Is_Get_Rows_Generations_Stopped = true;
                    #region Upload Files
                    oCodeBooster.Is_Uploaded_File_Feature = true;

                    oCodeBooster.Uploaded_Files_BackEnd_Events = new List<Uploaded_File_BackEnd_Event>();


                    //oCodeBooster.Uploaded_Files_BackEnd_Events.Add(
                    //    new Uploaded_File_BackEnd_Event()
                    //    {
                    //        TBL_NAME = "[TBL_FLOOR_SECTION]",
                    //        UI_METHOD_NAME = "Get_Floor_section_By_OWNER_ID",
                    //        Mode = 0
                    //    }
                    //    );
                    //oCodeBooster.Uploaded_Files_BackEnd_Events.Add(
                    //    new Uploaded_File_BackEnd_Event()
                    //    {
                    //        TBL_NAME = "[TBL_ZONE]",
                    //        UI_METHOD_NAME = "Get_Zone_By_OWNER_ID",
                    //        Mode = 0
                    //    }
                    //    );
                    //oCodeBooster.Uploaded_Files_BackEnd_Events.Add(
                    //    new Uploaded_File_BackEnd_Event()
                    //    {
                    //        TBL_NAME = "[TBL_SHAPE]",
                    //        UI_METHOD_NAME = "Get_Shape_By_OWNER_ID",
                    //        Mode = 0
                    //    }
                    //    );

                    #endregion

                    oCodeBooster.Methods_With_Events_By_Ref = new();
                    #region Events.
                    #region Normal Events.
                    oCodeBooster.Methods_With_Events.Add("Edit_Uploaded_file");
                    oCodeBooster.Methods_With_Events.Add("Delete_Uploaded_file");
                    oCodeBooster.Methods_With_Events.Add("Delete_Uploaded_file_By_REL_ENTITY_REL_KEY_REL_FIELD");
                    oCodeBooster.Methods_With_Events.Add("Edit_Outlet");
                    oCodeBooster.Methods_With_Events.Add("Edit_User");
                    #endregion
                    #region Events With Ref.
                    oCodeBooster.Methods_With_Events_By_Ref.Add("Get_Floor_By_OWNER_ID");
                    oCodeBooster.Methods_With_Events_By_Ref.Add("Get_Room_By_FLOOR_ID");
                    oCodeBooster.Methods_With_Events_By_Ref.Add("Get_Outlet_By_ROOM_ID");
                    oCodeBooster.Methods_With_Events_By_Ref.Add("Get_Hardware_link_By_HARDWARE_LINK_ID");

                    #endregion
                    #endregion
                    oCodeBooster.List_Reset_Topology = new();
                    //oCodeBooster.List_Reset_Topology.Add(new Reset_Topology() { ParentTable = "[TBL_PERSONS]", ChildTables = new List<string>() { "[TBL_ADDRES]", "[TBL_CONTACT]" } });
                    #region Eager Loading
                    oCodeBooster.List_Eager_Loading = new()
                    {
                        new()
                        {
                            Method_Name = "Get_Plc_By_OWNER_ID",
                            ParentTable = "[TBL_PLC]",
                            ChildTables = new()
                            {
                                "[TBL_HARDWARE_LINK]"
                            }
                        },
                        new()
                        {
                            Method_Name = "Get_Hardware_link_By_OWNER_ID_Adv",
                            ParentTable = "[TBL_HARDWARE_LINK]",
                            ChildTables = new()
                            {
                                "[TBL_OUTLET]"
                            }
                        }
                    };

                    #endregion

                    #region Offline
                    oCodeBooster.List_Offline_Tables = new();

                    #endregion
                    #region One2Many
                    oCodeBooster.List_Inheritance = new();
                    //oCodeBooster.List_Inheritance.Add(new Inheritance() { ParentTable = "[TBL_PERSON]", ChildTable = "[TBL_ADDRESS]", RelationField = "[PERSON_ID]", RelationType = "12M" });                    
                    #endregion
                    #region Generate SP's & BLC Layer
                    oCodeBoosterClient.GenerateAllSPAndBLCLayer();
                    #endregion
                    break;
                #endregion
                #region case "002":
                case "002":

                    oCodeBooster.My_Enum_API_Target = Enum_API_Target.WebAPI;
                    oCodeBooster.My_Enum_API_Accessibility = Enum_API_Accessibility.Same_Domain;
                    #region Api Bypass Ticketing
                    oCodeBooster.List_ByPass_Ticketing = new();
                    oCodeBooster.List_ByPass_Ticketing.Add("Get_All_Data");
                    oCodeBooster.List_ByPass_Ticketing.Add("Admin_log_in");
                    oCodeBooster.List_ByPass_Ticketing.Add("Get_Service_Data");
                    #endregion

                    // --------------                                        
                    oCodeBoosterClient.GenerateAPILayer();
                    // --------------

                    break;
                #endregion
                #region case "003":
                case "003":

                    // --------------
                    UIFields oUIFields_EditUI = new();
                    UIFields oUIFields_Criteria = new();
                    UIFields oUIFields_Result = new();
                    // --------------

                    // --------------
                    oCodeBooster.My_Enum_UI_Target = Enum_UI_Target.HTML5;
                    oCodeBooster.My_Enum_HTML5_Target = Enum_HTML5_Target.NG;
                    // --------------


                    // Gather Required Data.
                    // --------------
                    oCodeBoosterClient.Gather_Required_Data();
                    // --------------

                    // Cleans UI Folder
                    // --------------
                    oCodeBoosterClient.Cleanse_UI_Patch_Folder();
                    // --------------

                    #region Person
                    #region Search Screen
                    oUIFields_Criteria = new()
                    {
                        MainTableName = "[TBL_PERSON]",
                        Based_On_Type = "BLC.Params_Get_Person_By_Criteria"
                    };

                    oUIFields_Result = new()
                    {
                        MainTableName = "[TBL_PERSON]",
                        Based_On_Type = "BLC.Person",
                        GetMethodName = "Get_Person_By_Criteria",
                        GridFields = new()
                    };



                    oSearch_AdvancedProp = new()
                    {
                        ContainerMargins = "0,5,0,5"
                    };
                    oCodeBooster.Entity_FriendlyName = "Person";
                    oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.With_Criteria_Section,oUIFields_Criteria,oUIFields_Result,oSearch_AdvancedProp);
                    #endregion
                    #endregion


                    // Send UI Patch
                    // -------------
                    oCodeBoosterClient.Send_UI_Patch();
                    // --------------

                    break;
                #endregion
                #region Case "051"
                case "051":
                    Params_Generate_Mobile_Native_UI oParams_Generate_Mobile_Native_UI = new()
                    {
                        MOBILE_PLATFORM = "ANDROID",
                        VIEW_TYPE = "001",
                        TABLE_NAME = "[TBL_AC]",
                        GET_METHOD_NAME = "Get_Ac_By_Where",
                        TITLE = "Hotels",
                        BAR_BUTTON_ITEM_TITLE = "Bla Bla",
                        IMAGE_BASE_URL = @"https://www.igloorooms.com/irimages/aclogo/AcLogo_\(myData[indexPath.row].AC_ID!).jpg"
                    };
                    //oCodeBoosterClient.Generate_Mobile_Native_UI(oParams_Generate_Mobile_Native_UI);

                    oParams_Generate_Mobile_Native_UI = new()
                    {
                        MOBILE_PLATFORM = "IOS",
                        VIEW_TYPE = "001",
                        TABLE_NAME = "[TBL_AC]",
                        GET_METHOD_NAME = "Get_Ac_By_Where",
                        TITLE = "Hotels",
                        BAR_BUTTON_ITEM_TITLE = "Bla Bla",
                        IMAGE_BASE_URL = @"https://www.igloorooms.com/irimages/aclogo/AcLogo_\(myData[indexPath.row].AC_ID!).jpg"
                    };
                    //oCodeBoosterClient.Generate_Mobile_Native_UI(oParams_Generate_Mobile_Native_UI);

                    break;
                    #endregion
            }
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadLine();
            #endregion
        }
        #endregion
    }
}
