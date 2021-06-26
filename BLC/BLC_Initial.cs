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
    public partial class BLC : IDisposable
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
            MS  = 1
        }
        public enum Enum_GradeMode
        {
            Over_One_Hundred = 0,
            Assignment = 1
        }
        #endregion
        #region Members
        private string _ConnectionString = string.Empty;
        DALC.IDALC _AppContext = null;     
        #endregion
        #region Properties
	public Tools.Tools oTools { get; set; }
        public string ConnectionString
        {
            get
            {
                return _ConnectionString;
            }
            set
            {
                _ConnectionString = value;
            }
        }
        public long? UserID { get; set; }
        public Int32? OwnerID { get; set; }
        public Enum_Language Language { get; set; }
        public string Messages_FilePath { get; set; }
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
            Tools.Tools oTools = new Tools.Tools();
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
            //Initialize_Eager_Loading_Mechanism();
            Register_Uploaded_Events_Handlers();
            #endregion
            #region Body Section.
            OnPostEvent_Get_Floor_By_OWNER_ID += BLC_OnPostEvent_Get_Floor_By_OWNER_ID;
            OnPostEvent_Get_Room_By_FLOOR_ID += BLC_OnPostEvent_Get_Room_By_FLOOR_ID;
            OnPostEvent_Get_Outlet_By_ROOM_ID += BLC_OnPostEvent_Get_Outlet_By_ROOM_ID;
            OnPostEvent_Get_Hardware_link_By_HARDWARE_LINK_ID += BLC_OnPostEvent_Get_Hardware_link_By_HARDWARE_LINK_ID;
            OnPreEvent_Edit_Outlet += BLC_OnPreEvent_Edit_Outlet;
            OnPostEvent_Edit_User += BLC_OnPostEvent_Edit_User;
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
            this.Messages = new List<Message>();

            if (!string.IsNullOrEmpty(this.Messages_FilePath))
            {
                oRoot = XElement.Load(this.Messages_FilePath);
                if (oRoot != null)
                {
                    switch (Language)
                    {
                        case Enum_Language.English:
                            oLanguage = oRoot.Element("ENGLISH");
                            break;
                        case Enum_Language.Arabic:
                            oLanguage = oRoot.Element("ARABIC");
                            break;
                        default:
                            oLanguage = oRoot.Element("ENGLISH");
                            break;
                    }

                    foreach (var oItem in oLanguage.Elements("MESSAGE"))
                    {
                        this.Messages.Add(new Message() { Code = oItem.Attribute("CODE").Value, Content = oItem.Attribute("CONTENT").Value });
                    }
                }
            }
            #endregion
        }
        #endregion
        #region GetMessageContent
        public string GetMessageContent(Enum_BR_Codes i_BR_Code)
        {
            #region Declaration And Initialization Section.
            string str_ReturnValue = string.Empty;
            #endregion
            #region Body Section.
            var oResult = this.Messages.First(x => x.Code == i_BR_Code.ToString());
            str_ReturnValue = oResult.Content;
            #endregion
            #region Return Section.
            return str_ReturnValue;
            #endregion
        }
        #endregion
        #region GetMessageContent
        public string GetMessageContent(Enum_BR_Codes i_BR_Code, Dictionary<string, string> i_PlaceHolders)
        {
            #region Declaration And Initialization Section.
            string str_ReturnValue = string.Empty;
            #endregion
            #region Body Section.
            var oResult = this.Messages.First(x => x.Code == i_BR_Code.ToString());
            str_ReturnValue = oResult.Content;

            foreach (var oItem in i_PlaceHolders)
            {
                str_ReturnValue = str_ReturnValue.Replace(oItem.Key, oItem.Value);
            }
            #endregion
            #region Return Section.
            return str_ReturnValue;
            #endregion
        }
        #endregion
        #region Events Implementation
        private void BLC_OnPostEvent_Get_Floor_By_OWNER_ID(ref List<Floor> i_Result, Params_Get_Floor_By_OWNER_ID i_Params_Get_Floor_By_OWNER_ID)
        {
            foreach (Floor floor in i_Result)
            {
                Params_Get_Room_By_FLOOR_ID params_Get_Room_By_FLOOR_ID = new();
                params_Get_Room_By_FLOOR_ID.FLOOR_ID = floor.FLOOR_ID;
                params_Get_Room_By_FLOOR_ID.UserID = i_Params_Get_Floor_By_OWNER_ID.UserID;
                floor.MyRooms = Get_Room_By_FLOOR_ID(params_Get_Room_By_FLOOR_ID);
            }
        }
        private void BLC_OnPostEvent_Get_Room_By_FLOOR_ID(ref List<Room> i_Result, Params_Get_Room_By_FLOOR_ID i_Params_Get_Room_By_FLOOR_ID)
        {
            foreach (Room room in i_Result)
            {
                Params_Get_Outlet_By_ROOM_ID params_Get_Outlet_By_ROOM_ID = new();
                params_Get_Outlet_By_ROOM_ID.ROOM_ID = room.ROOM_ID;
                params_Get_Outlet_By_ROOM_ID.UserID = i_Params_Get_Room_By_FLOOR_ID.UserID;
                room.MyOutlets = Get_Outlet_By_ROOM_ID(params_Get_Outlet_By_ROOM_ID);
            }
        }
        private void BLC_OnPostEvent_Get_Outlet_By_ROOM_ID(ref List<Outlet> i_Result, Params_Get_Outlet_By_ROOM_ID i_Params_Get_Outlet_By_ROOM_ID)
        {
            foreach (Outlet outlet in i_Result)
            {
                try
                {
                    var oQuery = _AppContext.UP_GET_OUTLET_UI_BY_OUTLET_USER(
                    outlet.OUTLET_ID,
                    i_Params_Get_Outlet_By_ROOM_ID.UserID
                    );
                    if (oQuery.Count() == 1)
                    {
                        var oResult = oQuery.First();
                        Outlet_ui outlet_Ui = new();
                        oTools.CopyPropValues(oResult, outlet_Ui);
                        Params_Get_Ui_By_UI_ID params_Get_Ui_By_UI_ID = new();
                        params_Get_Ui_By_UI_ID.UI_ID = outlet_Ui.UI_ID;
                        outlet.UI_Element = Get_Ui_By_UI_ID(params_Get_Ui_By_UI_ID);
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
                Params_Get_Hardware_link_By_HARDWARE_LINK_ID params_Get_Hardware_Link_By_HARDWARE_LINK_ID = new();
                params_Get_Hardware_Link_By_HARDWARE_LINK_ID.HARDWARE_LINK_ID = outlet.HARDWARE_LINK_ID;
                outlet.My_Hardware_link = Get_Hardware_link_By_HARDWARE_LINK_ID(params_Get_Hardware_Link_By_HARDWARE_LINK_ID);
            }
        }
        private void BLC_OnPostEvent_Get_Hardware_link_By_HARDWARE_LINK_ID(ref Hardware_link i_Result, Params_Get_Hardware_link_By_HARDWARE_LINK_ID i_Params_Get_Hardware_link_By_HARDWARE_LINK_ID)
        {
            Params_Get_Plc_By_PLC_ID params_Get_Plc_By_PLC_ID = new();
            params_Get_Plc_By_PLC_ID.PLC_ID = i_Result.PLC_ID;
            i_Result.My_Plc = Get_Plc_By_PLC_ID(params_Get_Plc_By_PLC_ID);
        }
        private void BLC_OnPreEvent_Edit_Outlet(Outlet i_Outlet, Enum_EditMode i_Enum_EditMode)
        {
            if(i_Outlet.OUTLET_ID!=-1 && i_Outlet.CURRENT_VALUE!="-1")
            {
                switch(i_Outlet.OUTLET_TYPE_ID)
                {
                    case 3:
                        {
                            Params_Twincat2Toggle params_Twincat2Toggle = new();
                            params_Twincat2Toggle.AMSID = i_Outlet.My_Hardware_link.My_Plc.LOCATION;
                            params_Twincat2Toggle.Port = i_Outlet.My_Hardware_link.My_Plc.PORT;
                            params_Twincat2Toggle.VariableName = i_Outlet.My_Hardware_link.PLC_ADDRESS;
                            var oQuery = _AppContext.UP_GET_SETUP_ENTRY(1, "_TIMER", "001");
                            if (oQuery.Count == 1)
                            {
                                var oResult = oQuery.First();
                                int parseRes;
                                bool isParsed = int.TryParse(oResult.CODE_VALUE_EN, out parseRes);
                                if (isParsed)
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
                            _ = Twincat2Toggle(params_Twincat2Toggle);
                        }
                        break;
                    case 4:
                        {
                            Params_Twincat2Toggle params_Twincat2Toggle = new();
                            params_Twincat2Toggle.AMSID = i_Outlet.My_Hardware_link.My_Plc.LOCATION;
                            params_Twincat2Toggle.Port = i_Outlet.My_Hardware_link.My_Plc.PORT;
                            params_Twincat2Toggle.VariableName = i_Outlet.My_Hardware_link.PLC_ADDRESS;
                            var oQuery = _AppContext.UP_GET_SETUP_ENTRY(1, "_TIMER", "002");
                            if (oQuery.Count == 1)
                            {
                                var oResult = oQuery.First();
                                int parseRes;
                                bool isParsed =int.TryParse(oResult.CODE_VALUE_EN, out parseRes);
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
        private void BLC_OnPostEvent_Edit_User(User i_User, Enum_EditMode i_Enum_EditMode)
        {
            MiniCryptoHelper miniCrypto = new();
            i_User.PASSWORD = miniCrypto.Encrypt(i_User.PASSWORD);
        }
        #endregion
    }
    #endregion
    #region BLCInitializer
    public class BLCInitializer
    {
        #region Properties
        public string ConnectionString { get; set; }
        public long? UserID { get; set; }
        public Int32? OwnerID { get; set; }
        public BLC.Enum_Language Language { get; set; }
        public string Messages_FilePath { get; set; }
        #endregion
    }
    #endregion
    #region Message
    public class Message
    {
        #region Properties
        public string Code { get; set; }
        public string Content { get; set; }
        #endregion
    }
    #endregion
    #region EnvCode Attribute
    #region EnvCode
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Constructor, AllowMultiple = true)]
    public class EnvCode : System.Attribute
    {
        #region Properties
        public BLC.Enum_Environment Environment { get; set; }
        public string MethodName { get; set; }
        #endregion
        #region Constructor
        public EnvCode(BLC.Enum_Environment i_Environment, string i_MethodName)
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
            object[] oAttributes = null;
            EnvCode oEnvCode = null;

            bool Is_AlreadyFound = false;
            MethodInfo oMethodInfo_ReturnValue = null;
            #endregion
            #region Body Section.

            // ----------------------
            oMethods = i_Params_GetEnvCode.My_Type.GetMethods();
            // ----------------------

            // ----------------------
            for (int i = 0; i < oMethods.GetLength(0); i++)
            {
                // ----------------------
                if (Is_AlreadyFound == true)
                {
                    break;
                }
                // ----------------------

                // ----------------------
                oMethodInfo = oMethods[i];
                oAttributes = oMethodInfo.GetCustomAttributes(true);
                // ----------------------

                // ----------------------
                foreach (Attribute oAttribute in oAttributes)
                {
                    if (oAttribute is EnvCode)
                    {
                        oEnvCode = oAttribute as EnvCode;
                        if (oEnvCode != null)
                        {
                            if ((oEnvCode.Environment == i_Params_GetEnvCode.My_Environment) && (oEnvCode.MethodName == i_Params_GetEnvCode.My_MethodName))
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
        public string My_MethodName { get; set; }
        #endregion
    }
    #endregion
    #endregion
}


