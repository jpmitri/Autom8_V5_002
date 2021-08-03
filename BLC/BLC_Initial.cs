using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

using Crypto;

using DALC;

namespace BLC
{
    #region BLC
    public partial class BLC: IDisposable
    {
        #region Enumeration
        public enum Enum_Language
        {
            English = 0,
            French = 1,
            Arabic = 2
        }
        public enum Enum_BR_Codes
        {
            BR_9999,  // Invalid Credentials
            BR_0000,  // Uniqueness Violation                      
            BR_0001,  // Password should be at least 4 characters
            BR_0002,  // PLC Error
            BR_0003,  // Outlet Not Found
            BR_0004   // Unable To Connect To PLC
        }
        public enum Enum_EditMode
        {
            Add,
            Update
        }
        public enum Enum_Environment
        {
            BHS = 0,
            MS = 1
        }
        public enum Enum_GradeMode
        {
            Over_One_Hundred = 0,
            Assignment = 1
        }
        #endregion
        #region Members
        private String _ConnectionString = String.Empty;
        private readonly DALC.IDALC _AppContext = null;
        #endregion
        #region Properties
        public Tools.Tools oTools { get; set; }
        public String ConnectionString
        {
            get => _ConnectionString;
            set => _ConnectionString = value;
        }
        public Int64? UserID { get; set; }
        public Int32? OwnerID { get; set; }
        public Enum_Language Language { get; set; }
        public String Messages_FilePath { get; set; }
        public List<Message> Messages { get; set; }
        public Enum_Environment Environment { get; set; }

        #endregion
        #region Constructor
        public BLC()
        {
            #region Declaration And Initialization Section.
            #endregion
            #region Body Section.
            #endregion
        }
        public BLC(BLCInitializer i_BLCInitializer)
        {
            #region Declaration And Initialization Section.    
            Tools.Tools oTools = new();
            #endregion
            #region Body Section.
            // ---------------------
            ConnectionString = i_BLCInitializer.ConnectionString;
            UserID = i_BLCInitializer.UserID;
            OwnerID = i_BLCInitializer.OwnerID;
            Language = i_BLCInitializer.Language;
            Messages_FilePath = i_BLCInitializer.Messages_FilePath;
            _AppContext = new DALC.MSSQL_DALC(_ConnectionString);
            this.oTools = new Tools.Tools();
            // ---------------------

            // ---------------------
            LoadMessages();
            SubscribeToEvents();
            Initialize_Audit_Mechanism();
            // ---------------------


            #endregion
        }
        #endregion
        #region Subscribe To Events
        public void SubscribeToEvents()
        {
            #region Declaration And Initialization Section.
            Initialize_Eager_Loading_Mechanism();
            Register_Uploaded_Events_Handlers();
            #endregion
            #region Body Section.
            OnPostEvent_Get_Floor_By_OWNER_ID += BLC_OnPostEvent_Get_Floor_By_OWNER_ID;
            OnPostEvent_Get_Room_By_FLOOR_ID += BLC_OnPostEvent_Get_Room_By_FLOOR_ID;
            OnPostEvent_Get_Outlet_By_ROOM_ID += BLC_OnPostEvent_Get_Outlet_By_ROOM_ID;
            OnPostEvent_Get_Hardware_link_By_HARDWARE_LINK_ID += BLC_OnPostEvent_Get_Hardware_link_By_HARDWARE_LINK_ID;
            OnPreEvent_Edit_Outlet += BLC_OnPreEvent_Edit_Outlet;
            OnPostEvent_Edit_User += BLC_OnPostEvent_Edit_User;
            OnPreEvent_Edit_User += BLC_OnPreEvent_Edit_User;
            #endregion
        }
        #endregion
        #region IDisposable Members
        public void Dispose()
        {
            #region Body Section.
            #endregion
        }
        #endregion
        #region LoadMessages
        public void LoadMessages()
        {
            #region Declaration And Initialization Section.
            XElement oRoot = null;
            XElement oLanguage = null;
            #endregion
            #region Body Section.
            Messages = new List<Message>();

            if(!String.IsNullOrEmpty(Messages_FilePath))
            {
                oRoot = XElement.Load(Messages_FilePath);
                if(oRoot != null)
                {
                    oLanguage = Language switch
                    {
                        Enum_Language.English => oRoot.Element("ENGLISH"),
                        Enum_Language.Arabic => oRoot.Element("ARABIC"),
                        Enum_Language.French => oRoot.Element("FRENCH"),
                        _ => oRoot.Element("ENGLISH"),
                    };
                    foreach(XElement oItem in oLanguage.Elements("MESSAGE"))
                    {
                        Messages.Add(new Message() { Code = oItem.Attribute("CODE").Value,Content = oItem.Attribute("CONTENT").Value });
                    }
                }
            }
            #endregion
        }
        #endregion
        #region GetMessageContent
        public String GetMessageContent(Enum_BR_Codes i_BR_Code)
        {
            #region Declaration And Initialization Section.
            String str_ReturnValue = String.Empty;
            #endregion
            #region Body Section.
            Message oResult = Messages.First(x => x.Code == i_BR_Code.ToString());
            str_ReturnValue = oResult.Content;
            #endregion
            #region Return Section.
            return str_ReturnValue;
            #endregion
        }
        #endregion
        #region GetMessageContent
        public String GetMessageContent(Enum_BR_Codes i_BR_Code,Dictionary<String,String> i_PlaceHolders)
        {
            #region Declaration And Initialization Section.
            String str_ReturnValue = String.Empty;
            #endregion
            #region Body Section.
            Message oResult = Messages.First(x => x.Code == i_BR_Code.ToString());
            str_ReturnValue = oResult.Content;

            foreach(KeyValuePair<String,String> oItem in i_PlaceHolders)
            {
                str_ReturnValue = str_ReturnValue.Replace(oItem.Key,oItem.Value);
            }
            #endregion
            #region Return Section.
            return str_ReturnValue;
            #endregion
        }
        #endregion
        #region Events Implementation
        private void BLC_OnPostEvent_Get_Floor_By_OWNER_ID(ref List<Floor> i_Result,Params_Get_Floor_By_OWNER_ID i_Params_Get_Floor_By_OWNER_ID)
        {
            foreach(Floor floor in i_Result)
            {
                Params_Get_Room_By_FLOOR_ID params_Get_Room_By_FLOOR_ID = new();
                params_Get_Room_By_FLOOR_ID.FLOOR_ID = floor.FLOOR_ID;
                params_Get_Room_By_FLOOR_ID.UserID = i_Params_Get_Floor_By_OWNER_ID.UserID;
                params_Get_Room_By_FLOOR_ID.UserType = i_Params_Get_Floor_By_OWNER_ID.UserType;
                floor.MyRooms = Get_Room_By_FLOOR_ID(params_Get_Room_By_FLOOR_ID);
            }
        }
        private void BLC_OnPostEvent_Get_Room_By_FLOOR_ID(ref List<Room> i_Result,Params_Get_Room_By_FLOOR_ID i_Params_Get_Room_By_FLOOR_ID)
        {
            foreach(Room room in i_Result)
            {
                Params_Get_Outlet_By_ROOM_ID params_Get_Outlet_By_ROOM_ID = new();
                params_Get_Outlet_By_ROOM_ID.ROOM_ID = room.ROOM_ID;
                params_Get_Outlet_By_ROOM_ID.UserID = i_Params_Get_Room_By_FLOOR_ID.UserID;
                params_Get_Outlet_By_ROOM_ID.UserType = i_Params_Get_Room_By_FLOOR_ID.UserType;
                room.MyOutlets = Get_Outlet_By_ROOM_ID(params_Get_Outlet_By_ROOM_ID);
            }
        }
        private void BLC_OnPostEvent_Get_Outlet_By_ROOM_ID(ref List<Outlet> i_Result,Params_Get_Outlet_By_ROOM_ID i_Params_Get_Outlet_By_ROOM_ID)
        {
            foreach(Outlet outlet in i_Result)
            {
                if(i_Params_Get_Outlet_By_ROOM_ID.UserType != "001")
                {
                    try
                    {
                        List<dynamic> oQuery = _AppContext.UP_GET_OUTLET_UI_BY_OUTLET_USER(
                        outlet.OUTLET_ID,
                        i_Params_Get_Outlet_By_ROOM_ID.UserID
                        );
                        if(oQuery.Count == 1)
                        {
                            dynamic oResult = oQuery.First();
                            Outlet_ui outlet_Ui = new();
                            oTools.CopyPropValues(oResult,outlet_Ui);
                            Params_Get_Ui_By_UI_ID params_Get_Ui_By_UI_ID = new();
                            params_Get_Ui_By_UI_ID.UI_ID = outlet_Ui.UI_ID;
                            outlet.UI_Element = Get_Ui_By_UI_ID(params_Get_Ui_By_UI_ID);
                            outlet.My_Outlet_Ui = outlet_Ui;
                        }
                        else
                        {
                            throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0003));
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0003));
                    }
                }
                Params_Get_Hardware_link_By_HARDWARE_LINK_ID params_Get_Hardware_Link_By_HARDWARE_LINK_ID = new();
                params_Get_Hardware_Link_By_HARDWARE_LINK_ID.HARDWARE_LINK_ID = outlet.HARDWARE_LINK_ID;
                outlet.My_Hardware_link = Get_Hardware_link_By_HARDWARE_LINK_ID(params_Get_Hardware_Link_By_HARDWARE_LINK_ID);
            }
        }
        private void BLC_OnPostEvent_Get_Hardware_link_By_HARDWARE_LINK_ID(ref Hardware_link i_Result,Params_Get_Hardware_link_By_HARDWARE_LINK_ID i_Params_Get_Hardware_link_By_HARDWARE_LINK_ID)
        {
            Params_Get_Plc_By_PLC_ID params_Get_Plc_By_PLC_ID = new();
            params_Get_Plc_By_PLC_ID.PLC_ID = i_Result.PLC_ID;
            i_Result.My_Plc = Get_Plc_By_PLC_ID(params_Get_Plc_By_PLC_ID);
        }
        private void BLC_OnPreEvent_Edit_Outlet(Outlet i_Outlet,Enum_EditMode i_Enum_EditMode)
        {
            if(i_Outlet.OUTLET_ID != -1 && i_Outlet.CURRENT_VALUE != "-1")
            {
                if(i_Outlet.My_Hardware_link.My_Plc is not null)
                {
                    switch(i_Outlet.OUTLET_TYPE_ID)
                    {
                        case 2:
                            {
                                Double val = Double.Parse(i_Outlet.CURRENT_VALUE);
                                val *= 2.55;
                                Int32 intval = (Int32)Math.Round(val);
                                if(intval > 255)
                                {
                                    intval = 255;
                                }
                                if(intval < 0)
                                {
                                    intval = 0;
                                }
                                i_Outlet.CURRENT_VALUE = intval + "";
                                Params_Twincat2Write params_Twincat2Write = new();
                                params_Twincat2Write.AMSID = i_Outlet.My_Hardware_link.My_Plc.LOCATION;
                                params_Twincat2Write.Port = i_Outlet.My_Hardware_link.My_Plc.PORT;
                                params_Twincat2Write.VariableName = i_Outlet.My_Hardware_link.PLC_ADDRESS;
                                params_Twincat2Write.Value = i_Outlet.CURRENT_VALUE;
                                Twincat2Write(params_Twincat2Write);
                            }
                            break;
                        case 3:
                            {
                                Params_Twincat2Toggle params_Twincat2Toggle = new();
                                params_Twincat2Toggle.AMSID = i_Outlet.My_Hardware_link.My_Plc.LOCATION;
                                params_Twincat2Toggle.Port = i_Outlet.My_Hardware_link.My_Plc.PORT;
                                string[] states = i_Outlet.My_Hardware_link.PLC_ADDRESS.Split(",");
                                Console.WriteLine(states[0]);
                                Console.WriteLine(states[1]);
                                Params_Get_Outlet_By_OUTLET_ID params_Get_Outlet_By_OUTLET_ID = new();
                                params_Get_Outlet_By_OUTLET_ID.OUTLET_ID = i_Outlet.OUTLET_ID;
                                Params_Twincat2Write params_Twincat2Write = new();
                                params_Twincat2Write.AMSID = i_Outlet.My_Hardware_link.My_Plc.LOCATION;
                                params_Twincat2Write.Port = i_Outlet.My_Hardware_link.My_Plc.PORT;
                                params_Twincat2Toggle.outlet = i_Outlet;
                                List<dynamic> oQuery = _AppContext.UP_GET_SETUP_ENTRY(1,"_TIMER","001");
                                if(oQuery.Count == 1)
                                {
                                    dynamic oResult = oQuery.First();
                                    Boolean isParsed = Int32.TryParse(oResult.CODE_VALUE_EN,out Int32 parseRes);
                                    if(isParsed)
                                    {
                                        params_Twincat2Toggle.Delay = parseRes;
                                    }
                                    else
                                    {
                                        params_Twincat2Toggle.Delay = 40000;
                                    }
                                }
                                else
                                {
                                    params_Twincat2Toggle.Delay = 40000;
                                }
                                switch(Get_Outlet_By_OUTLET_ID(params_Get_Outlet_By_OUTLET_ID).CURRENT_VALUE)
                                {
                                    case "1":
                                        Console.WriteLine("DB case 1");
                                        params_Twincat2Write.VariableName = states[0];
                                        params_Twincat2Write.Value = "0";
                                        _ = Twincat2Write(params_Twincat2Write);
                                        break;
                                    case "2":
                                        Console.WriteLine("DB case 2");
                                        params_Twincat2Write.VariableName = states[1];
                                        params_Twincat2Write.Value = "0";
                                        _ = Twincat2Write(params_Twincat2Write);
                                        break;
                                    default:
                                        break;
                                }
                                switch(i_Outlet.CURRENT_VALUE)
                                {
                                    case "1":
                                        Console.WriteLine("PLC Case 1");
                                        params_Twincat2Toggle.VariableName = states[0];
                                        _ = Twincat2Toggle(params_Twincat2Toggle);
                                        break;
                                    case "2":
                                        Console.WriteLine("PLC Case 2");
                                        params_Twincat2Toggle.VariableName = states[1];
                                        _ = Twincat2Toggle(params_Twincat2Toggle);
                                        break;
                                    default:
                                        Console.WriteLine("PLC case default");
                                        params_Twincat2Write.VariableName = states[0];
                                        params_Twincat2Write.Value = "0";
                                        _ = Twincat2Write(params_Twincat2Write);
                                        params_Twincat2Write.VariableName = states[1];
                                        params_Twincat2Write.Value = "0";
                                        _ = Twincat2Write(params_Twincat2Write);
                                        break;
                                }
                            }
                            break;
                        case 4:
                            {
                                Params_Twincat2Toggle params_Twincat2Toggle = new();
                                params_Twincat2Toggle.AMSID = i_Outlet.My_Hardware_link.My_Plc.LOCATION;
                                params_Twincat2Toggle.Port = i_Outlet.My_Hardware_link.My_Plc.PORT;
                                params_Twincat2Toggle.VariableName = i_Outlet.My_Hardware_link.PLC_ADDRESS;
                                List<dynamic> oQuery = _AppContext.UP_GET_SETUP_ENTRY(1,"_TIMER","002");
                                if(oQuery.Count == 1)
                                {
                                    dynamic oResult = oQuery.First();
                                    Boolean isParsed = Int32.TryParse(oResult.CODE_VALUE_EN,out Int32 parseRes);
                                    if(isParsed)
                                    {
                                        params_Twincat2Toggle.Delay = parseRes;
                                    }
                                    else
                                    {
                                        params_Twincat2Toggle.Delay = 1000;
                                    }

                                }
                                else
                                {
                                    params_Twincat2Toggle.Delay = 1000;
                                }
                                _ = Twincat2Toggle(params_Twincat2Toggle);
                            }
                            break;
                        default:
                            {
                                Params_Twincat2Write params_Twincat2Write = new();
                                params_Twincat2Write.AMSID = i_Outlet.My_Hardware_link.My_Plc.LOCATION;
                                params_Twincat2Write.Port = i_Outlet.My_Hardware_link.My_Plc.PORT;
                                params_Twincat2Write.VariableName = i_Outlet.My_Hardware_link.PLC_ADDRESS;
                                params_Twincat2Write.Value = i_Outlet.CURRENT_VALUE;
                                Twincat2Write(params_Twincat2Write);
                            }
                            break;
                    }
                }
            }
        }
        private void BLC_OnPreEvent_Edit_User(User i_User,Enum_EditMode i_Enum_EditMode)
        {
            MiniCryptoHelper miniCrypto = new();
            i_User.PASSWORD = miniCrypto.Encrypt(i_User.PASSWORD);
        }
        private void BLC_OnPostEvent_Edit_User(User i_User,Enum_EditMode i_Enum_EditMode)
        {
            if(i_Enum_EditMode == Enum_EditMode.Add)
            {
                Params_Get_Outlet_By_OWNER_ID params_Get_Outlet_By_OWNER_ID = new();
                params_Get_Outlet_By_OWNER_ID.OWNER_ID = i_User.OWNER_ID;
                Params_Get_Ui_By_OWNER_ID params_Get_Ui_By_OWNER_ID = new();
                params_Get_Ui_By_OWNER_ID.OWNER_ID = i_User.OWNER_ID;
                List<Outlet> outlet = Get_Outlet_By_OWNER_ID(params_Get_Outlet_By_OWNER_ID);
                List<Ui> Ui = Get_Ui_By_OWNER_ID(params_Get_Ui_By_OWNER_ID);
                Params_Edit_Outlet_ui_List params_Edit_Outlet_Ui_List = new();
                params_Edit_Outlet_Ui_List.My_List_To_Edit = new();
                Random rand = new();
                foreach(Outlet i in outlet)
                {
                    Outlet_ui x = new();
                    x.OUTLET_UI_ID = -1;
                    x.OUTLET_ID = i.OUTLET_ID;
                    x.USER_ID = i_User.USER_ID;
                    x.UI_ID = Ui[rand.Next(0,Ui.Count - 1)].UI_ID;
                    params_Edit_Outlet_Ui_List.My_List_To_Edit.Add(x);
                }
                Edit_Outlet_ui_List(params_Edit_Outlet_Ui_List);
            }

        }
        #endregion
    }
    #endregion
    #region BLCInitializer
    public class BLCInitializer
    {
        #region Properties
        public String ConnectionString { get; set; }
        public Int64? UserID { get; set; }
        public Int32? OwnerID { get; set; }
        public BLC.Enum_Language Language { get; set; }
        public String Messages_FilePath { get; set; }
        #endregion
    }
    #endregion
    #region Message
    public class Message
    {
        #region Properties
        public String Code { get; set; }
        public String Content { get; set; }
        #endregion
    }
    #endregion
    #region EnvCode Attribute
    #region EnvCode
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Constructor,AllowMultiple = true)]
    public class EnvCode: System.Attribute
    {
        #region Properties
        public BLC.Enum_Environment Environment { get; set; }
        public String MethodName { get; set; }
        #endregion
        #region Constructor
        public EnvCode(BLC.Enum_Environment i_Environment,String i_MethodName)
        {
            #region Body Section.
            Environment = i_Environment;
            MethodName = i_MethodName;
            #endregion
        }
        #endregion
        #region Behavior
        #region GetEnvCode
        public static MethodInfo GetEnvCode(Params_GetEnvCode i_Params_GetEnvCode)
        {
            #region Declaration And Initialization Section.
            MethodInfo[] oMethods = null;
            MethodInfo oMethodInfo = null;
            Object[] oAttributes = null;
            EnvCode oEnvCode = null;

            Boolean Is_AlreadyFound = false;
            MethodInfo oMethodInfo_ReturnValue = null;
            #endregion
            #region Body Section.

            // ----------------------
            oMethods = i_Params_GetEnvCode.My_Type.GetMethods();
            // ----------------------

            // ----------------------
            for(Int32 i = 0; i < oMethods.GetLength(0); i++)
            {
                // ----------------------
                if(Is_AlreadyFound == true)
                {
                    break;
                }
                // ----------------------

                // ----------------------
                oMethodInfo = oMethods[i];
                oAttributes = oMethodInfo.GetCustomAttributes(true);
                // ----------------------

                // ----------------------
                foreach(Attribute oAttribute in oAttributes)
                {
                    if(oAttribute is EnvCode)
                    {
                        oEnvCode = oAttribute as EnvCode;
                        if(oEnvCode != null)
                        {
                            if((oEnvCode.Environment == i_Params_GetEnvCode.My_Environment) && (oEnvCode.MethodName == i_Params_GetEnvCode.My_MethodName))
                            {
                                oMethodInfo_ReturnValue = oMethodInfo;
                                Is_AlreadyFound = true;
                                break;
                            }
                        }
                    }
                }
                // ----------------------
            }
            // ----------------------
            #endregion
            #region Return Section.
            return oMethodInfo_ReturnValue;
            #endregion
        }
        #endregion
        #endregion
    }
    #endregion
    #region Params_GetEnvCode
    public class Params_GetEnvCode
    {
        #region Properties.
        public System.Type My_Type { get; set; }
        public BLC.Enum_Environment My_Environment { get; set; }
        public String My_MethodName { get; set; }
        #endregion
    }
    #endregion
    #endregion
}


