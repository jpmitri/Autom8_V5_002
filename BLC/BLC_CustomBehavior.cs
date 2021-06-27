using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BLC
{
    #region Enumeration
    public enum Enum_EntityNameFormat
    {
        FML,
        FLM,
        MFL,
        MLF,
        LFM,
        LMF
    }
    #endregion
    public partial class BLC
    {
        #region Members
        #endregion
        #region Setup

        #region EditSetup
        public void EditSetup(SetupEntry i_SetupEntry)
        {
            #region Declaration And Initialization Section.
            Tools.Tools oTools = new Tools.Tools();
            #endregion
            #region Environment Related Code Handling
            Params_GetEnvCode oParams_GetEnvCode = new Params_GetEnvCode();
            oParams_GetEnvCode.My_Environment = this.Environment;
            oParams_GetEnvCode.My_MethodName = "EditSetup";
            oParams_GetEnvCode.My_Type = typeof(BLC);
            MethodInfo oMethodInfo = EnvCode.GetEnvCode(oParams_GetEnvCode);
            if (oMethodInfo != null)
            {
                oMethodInfo.Invoke(this, new object[] { i_SetupEntry });
                return;
            }
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("EditSetup");
            }
            #endregion
            #region Body Section.
            i_SetupEntry.ENTRY_USER_ID = this.UserID;
            i_SetupEntry.OWNER_ID = this.OwnerID;
            i_SetupEntry.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
            oTools.InvokeMethod(_AppContext, "UP_EDIT_SETUP", i_SetupEntry);
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("EditSetup");
            }
            #endregion
        }
        #endregion

        #endregion
        #region Ticket
        #region ResolveTicket
        public Dictionary<string, string> ResolveTicket(string i_Input)
        {
            #region Declaration And Initialization Section.
            Dictionary<string, string> oList = new Dictionary<string, string>();
            string str_Ticket_PlainText = string.Empty;
            Crypto.Crypto oCrypto = new Crypto.Crypto();
            string[] oMainTempList = null;
            string[] oSubTempList = null;
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("ResolveTicket");
            }
            #endregion
            #region Body Section.
            if (!string.IsNullOrEmpty(i_Input))
            {
                //str_Ticket_PlainText = oCrypto.Decrypt(i_Input, _KeySet);
                str_Ticket_PlainText = i_Input;

                if (!string.IsNullOrEmpty(str_Ticket_PlainText))
                {
                    oMainTempList = str_Ticket_PlainText.Split(new string[] { "[~!@]" }, StringSplitOptions.RemoveEmptyEntries);

                    var oQuery = from oItem in oMainTempList
                                 select oItem;

                    foreach (var oRow in oQuery)
                    {
                        oSubTempList = oRow.Split(new string[] { ":" }, StringSplitOptions.None);
                        oList.Add(oSubTempList[0], oSubTempList[1]);
                    }
                }
            }
            else
            {
                oList.Add("USER_ID", "1");
                oList.Add("OWNER_ID", "1");
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("ResolveTicket");
            }
            #endregion
            #region Return Section.
            return oList;
            #endregion
        }
        #endregion
        #region IsValidTicket
        public bool IsValidTicket(string i_Input)
        {
            #region Declaration And Initialization Section.
            bool Is_ValidTicket = false;
            long? i_MinutesElapsedSinceMidnight = 0;
            string str_CurrentDate = string.Empty;
            Tools.Tools oTools = new Tools.Tools();
            Dictionary<string, string> oTicketParts = new Dictionary<string, string>();
            #endregion
            #region Environment Related Code Handling
            Params_GetEnvCode oParams_GetEnvCode = new Params_GetEnvCode();
            oParams_GetEnvCode.My_Environment = this.Environment;
            oParams_GetEnvCode.My_MethodName = "IsValidTicket";
            oParams_GetEnvCode.My_Type = typeof(BLC);
            MethodInfo oMethodInfo = EnvCode.GetEnvCode(oParams_GetEnvCode);
            if (oMethodInfo != null)
            {
                return Convert.ToBoolean(oMethodInfo.Invoke(this, new object[] { i_Input }));
                // Intentially Left Empty.
            }
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("IsValidTicket");
            }
            #endregion
            #region Body Section.
            try
            {
                oTicketParts = ResolveTicket(i_Input);
                str_CurrentDate = oTools.GetDateString(DateTime.Today);

                if (oTicketParts["START_DATE"] == str_CurrentDate) // Session Started In Different Day.
                {
                    i_MinutesElapsedSinceMidnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;

                    if (i_MinutesElapsedSinceMidnight <= Convert.ToInt32(oTicketParts["START_MINUTE"]) + Convert.ToInt32(oTicketParts["SESSION_PERIOD"]))
                    {
                        Is_ValidTicket = true;
                    }
                }

            }
            catch (Exception ex)
            {
                Is_ValidTicket = false;
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("IsValidTicket");
            }
            #endregion
            #region Return Section.
            return Is_ValidTicket;
            #endregion
        }
        #endregion
        #endregion
        #region LogIn
        public All_Data Get_All_Data(Params_Get_All_Data i_Params_Get_All_Data)
        {
            #region Declaration And Initialization Section.
            Crypto.MiniCryptoHelper oCrypto = new Crypto.MiniCryptoHelper();
            Crypto.Crypto sCrypto = new Crypto.Crypto();
            string str_Ticket_PlainText = string.Empty;
            string str_Ticket_Encrypted = string.Empty;
            Int32? i_ExpiryPeriod = 240; // In Minutes
            long? i_MinutesElapsedSinceMidnight = 0;
            All_Data all_Data = new();
            Tools.Tools oTools = new Tools.Tools();

            #endregion
            #region Body Section.
            var oQuery = from oItem in _AppContext.UP_GET_ALL_DATA(
                i_Params_Get_All_Data.My_UserInfo.UserName,
                oCrypto.Encrypt(i_Params_Get_All_Data.My_UserInfo.Password)
                )
                         select oItem;

            if (oQuery.Count() == 1)
            {
                var oResult = oQuery.First();
                // ------------------------------
                i_Params_Get_All_Data.My_UserInfo.IsAuthenticated = true;
                i_Params_Get_All_Data.My_UserInfo.UserID = oResult.USER_ID;
                i_Params_Get_All_Data.My_UserInfo.OwnerID = oResult.OWNER_ID;
                // ------------------------------


                // ------------------------------
                this.UserID = i_Params_Get_All_Data.My_UserInfo.UserID;
                this.OwnerID = i_Params_Get_All_Data.My_UserInfo.OwnerID;
                // ------------------------------

                // ------------------------------
                i_MinutesElapsedSinceMidnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;
                str_Ticket_PlainText = string.Format(
                    "USER_ID:{0}[~!@]OWNER_ID:{1}[~!@]START_DATE:{2}[~!@]START_MINUTE:{3}[~!@]SESSION_PERIOD:{4}",
                    i_Params_Get_All_Data.My_UserInfo.UserID.ToString(),
                    i_Params_Get_All_Data.My_UserInfo.OwnerID.ToString(),
                    oTools.GetDateString(DateTime.Today),
                    i_MinutesElapsedSinceMidnight.ToString(),
                    i_ExpiryPeriod.ToString()
                    );
                str_Ticket_Encrypted = sCrypto.ScrambleQueryString(str_Ticket_PlainText);
                str_Ticket_Encrypted=System.Net.WebUtility.UrlEncode(str_Ticket_Encrypted);
                all_Data.User = i_Params_Get_All_Data.My_UserInfo;
                all_Data.User.Ticket = str_Ticket_Encrypted;
                // ------------------------------
                Params_Get_Floor_By_OWNER_ID params_Get_Floor_By_OWNER_ID = new();
                params_Get_Floor_By_OWNER_ID.OWNER_ID = i_Params_Get_All_Data.My_UserInfo.OwnerID;
                params_Get_Floor_By_OWNER_ID.UserID = (Int32)i_Params_Get_All_Data.My_UserInfo.UserID;
                all_Data.Floors = Get_Floor_By_OWNER_ID(params_Get_Floor_By_OWNER_ID);
                Params_Get_Ui_By_OWNER_ID params_Get_Ui_By_OWNER_ID = new();
                params_Get_Ui_By_OWNER_ID.OWNER_ID = 1;
                all_Data.MyColors = Get_Ui_By_OWNER_ID(params_Get_Ui_By_OWNER_ID);
            }
            else
            {
                throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_9999));
            }

            #endregion
            #region Return Section.
            return all_Data;
            #endregion
        }

        #endregion
        #region LogInAdmin
        public Admin_log_in_res Admin_log_in(Params_Admin_log_in i_Params_Admin_log_in)
        {
            #region Declaration And Initialization Section.
            Crypto.MiniCryptoHelper oCrypto = new Crypto.MiniCryptoHelper();
            Crypto.Crypto sCrypto = new Crypto.Crypto();
            string str_Ticket_PlainText = string.Empty;
            string str_Ticket_Encrypted = string.Empty;
            Int32? i_ExpiryPeriod = 240; // In Minutes
            long? i_MinutesElapsedSinceMidnight = 0;
            Admin_log_in_res admin_log_in = new();
            Tools.Tools oTools = new Tools.Tools();

            #endregion
            #region Body Section.
            var oQuery = from oItem in _AppContext.UP_GET_ALL_DATA(
                i_Params_Admin_log_in.My_UserInfo.UserName,
                oCrypto.Encrypt(i_Params_Admin_log_in.My_UserInfo.Password)
                )
                         select oItem;

            if (oQuery.Count() == 1)
            {
                var oResult = oQuery.First();
                // ------------------------------
                i_Params_Admin_log_in.My_UserInfo.IsAuthenticated = true;
                i_Params_Admin_log_in.My_UserInfo.UserID = oResult.USER_ID;
                i_Params_Admin_log_in.My_UserInfo.OwnerID = oResult.OWNER_ID;
                // ------------------------------


                // ------------------------------
                this.UserID = i_Params_Admin_log_in.My_UserInfo.UserID;
                this.OwnerID = i_Params_Admin_log_in.My_UserInfo.OwnerID;
                // ------------------------------

                // ------------------------------
                i_MinutesElapsedSinceMidnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;
                str_Ticket_PlainText = string.Format(
                    "USER_ID:{0}[~!@]OWNER_ID:{1}[~!@]START_DATE:{2}[~!@]START_MINUTE:{3}[~!@]SESSION_PERIOD:{4}",
                    i_Params_Admin_log_in.My_UserInfo.UserID.ToString(),
                    i_Params_Admin_log_in.My_UserInfo.OwnerID.ToString(),
                    oTools.GetDateString(DateTime.Today),
                    i_MinutesElapsedSinceMidnight.ToString(),
                    i_ExpiryPeriod.ToString()
                    );
                str_Ticket_Encrypted = sCrypto.ScrambleQueryString(str_Ticket_PlainText);
                str_Ticket_Encrypted = System.Net.WebUtility.UrlEncode(str_Ticket_Encrypted);
                admin_log_in.MyUser = i_Params_Admin_log_in.My_UserInfo;
                admin_log_in.MyUser.Ticket = str_Ticket_Encrypted;
                // ------------------------------
            }
            else
            {
                throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_9999));
            }

            #endregion
            #region Return Section.
            return admin_log_in;
            #endregion
        }
        #endregion
        #region Log In Service
        
             public Service_Data_Result Get_Service_Data(Params_Get_Service_Data i_Params_Get_Service_Data)
        {
            #region Declaration And Initialization Section.
            Crypto.MiniCryptoHelper oCrypto = new Crypto.MiniCryptoHelper();
            Crypto.Crypto sCrypto = new Crypto.Crypto();
            string str_Ticket_PlainText = string.Empty;
            string str_Ticket_Encrypted = string.Empty;
            Int32? i_ExpiryPeriod = 240; // In Minutes
            long? i_MinutesElapsedSinceMidnight = 0;
            Service_Data_Result result = new();
            Tools.Tools oTools = new Tools.Tools();

            #endregion
            #region Body Section.
            var oQuery = from oItem in _AppContext.UP_GET_ALL_DATA(
                i_Params_Get_Service_Data.My_UserInfo.UserName,
                oCrypto.Encrypt(i_Params_Get_Service_Data.My_UserInfo.Password)
                )
                         select oItem;

            if (oQuery.Count() == 1)
            {
                var oResult = oQuery.First();
                // ------------------------------
                i_Params_Get_Service_Data.My_UserInfo.IsAuthenticated = true;
                i_Params_Get_Service_Data.My_UserInfo.UserID = oResult.USER_ID;
                i_Params_Get_Service_Data.My_UserInfo.OwnerID = oResult.OWNER_ID;
                // ------------------------------


                // ------------------------------
                this.UserID = i_Params_Get_Service_Data.My_UserInfo.UserID;
                this.OwnerID = i_Params_Get_Service_Data.My_UserInfo.OwnerID;
                // ------------------------------

                // ------------------------------
                i_MinutesElapsedSinceMidnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;
                str_Ticket_PlainText = string.Format(
                    "USER_ID:{0}[~!@]OWNER_ID:{1}[~!@]START_DATE:{2}[~!@]START_MINUTE:{3}[~!@]SESSION_PERIOD:{4}",
                    i_Params_Get_Service_Data.My_UserInfo.UserID.ToString(),
                    i_Params_Get_Service_Data.My_UserInfo.OwnerID.ToString(),
                    oTools.GetDateString(DateTime.Today),
                    i_MinutesElapsedSinceMidnight.ToString(),
                    i_ExpiryPeriod.ToString()
                    );
                str_Ticket_Encrypted = sCrypto.ScrambleQueryString(str_Ticket_PlainText);
                str_Ticket_Encrypted = System.Net.WebUtility.UrlEncode(str_Ticket_Encrypted);
                result.My_UserInfo = i_Params_Get_Service_Data.My_UserInfo;
                result.My_UserInfo.Ticket = str_Ticket_Encrypted;
                // ------------------------------
                Params_Get_Plc_By_OWNER_ID params_Get_Plc_By_OWNER_ID = new();
                params_Get_Plc_By_OWNER_ID.OWNER_ID = 1;
                result.My_PLCs = Get_Plc_By_OWNER_ID(params_Get_Plc_By_OWNER_ID);
            }
            else
            {
                throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_9999));
            }

            #endregion
            #region Return Section.
            return result;
            #endregion
        }
        #endregion
    }
    #region Business Entities
    #region Setup
    #region SetupEntry
    public class SetupEntry
    {
        #region Properties
        public Int32? OWNER_ID { get; set; }
        public string TBL_NAME { get; set; }
        public string CODE_NAME { get; set; }
        public bool? ISSYSTEM { get; set; }
        public bool? ISDELETEABLE { get; set; }
        public bool? ISUPDATEABLE { get; set; }
        public bool? ISVISIBLE { get; set; }
        public bool? ISDELETED { get; set; }
        public Int32? DISPLAY_ORDER { get; set; }
        public string CODE_VALUE_EN { get; set; }
        public string CODE_VALUE_FR { get; set; }
        public string CODE_VALUE_AR { get; set; }
        public string ENTRY_DATE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string NOTES { get; set; }

        public string INVARIANT_VALUE { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_Table_Name
    public class Params_Get_Setup_By_OWNER_ID_TBL_NAME
    {
        public Int32? OWNER_ID { get; set; }
        public string TBL_NAME { get; set; }
    }
    #endregion
    #endregion
    #region Uploaded_file
    public partial class Uploaded_file
    {
        public string My_URL { get; set; }
    }
    #endregion
    #region Floor
    public partial class Floor
    {
        public List<Room> MyRooms { get; set; }
    }
    #endregion
    #region Room
    public partial class Room
    {
        public List<Outlet> MyOutlets { get; set; }
    }
    #endregion
    #region Outlet
    public partial class Outlet
    {
        public Ui? UI_Element { get; set; }
    }
    #endregion
    #region Outlet UI
    public partial class Outlet_ui
    {
        public User My_User { get; set; }
    }

    #endregion
    #region LogInFetch
    public class UserInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Int32 OwnerID { get; set; }
        public Int64 UserID { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Ticket { get; set; }
    }
    public class Params_Get_All_Data
    {
        public UserInfo My_UserInfo { get; set; }
    }
    public partial class All_Data
    {
        public UserInfo User { get; set; }
        public List<Floor> Floors { get; set; }
        public List<Ui> MyColors { get; set; }
    }
    public partial class Params_Get_Floor_By_OWNER_ID
    {
        public Int32? UserID { get; set; }
    }
    public partial class Params_Get_Room_By_FLOOR_ID
    {
        public Int32? UserID { get; set; }
    }
    public partial class Params_Get_Outlet_By_ROOM_ID
    {
        public Int32? UserID { get; set; }
    }
    #endregion
    #region Admin Log In
    public partial class Params_Admin_log_in
    {
        public UserInfo My_UserInfo { get; set; }
    }
    public partial class Admin_log_in_res
    {
        public UserInfo MyUser { get; set; }
    }
    #endregion
    #region Log In Service
    public class Params_Get_Service_Data
    {
        public UserInfo My_UserInfo { get; set; }
    }
    public partial class Service_Data_Result
    {
        public List<Plc> My_PLCs { get; set; }
        public UserInfo My_UserInfo { get; set; }
    }
    #endregion
    #endregion
}