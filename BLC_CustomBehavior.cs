using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using DALC;

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
        #region Get_Setup
        public List<SetupEntry> Get_Setup_By_Table_Name(Params_Get_Setup_By_OWNER_ID_TBL_NAME i_Params_Get_Setup_By_OWNER_ID_TBL_NAME)
        {
            #region Declaration And Initialization Section.
            List<SetupEntry> oList = new();
            #endregion.
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Owner_id_Tbl_name");
            }
            #endregion
            #region Body Section
            int? OWNER_ID = i_Params_Get_Setup_By_OWNER_ID_TBL_NAME.OWNER_ID;
            string TBL_NAME = i_Params_Get_Setup_By_OWNER_ID_TBL_NAME.TBL_NAME;
            List<dynamic> oList_DBEntries = _AppContext.UP_GET_SETUP_BY_OWNER_ID_TBL_NAME(OWNER_ID, TBL_NAME);
            if (oList_DBEntries != null)
            {
                foreach (var oDBEntry in oList_DBEntries)
                {
                    SetupEntry oSetupEntry = new();
                    oTools.CopyPropValues(oDBEntry, oSetupEntry);
                    oList.Add(oSetupEntry);
                }

            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Owner_id_Tbl_name");
            }
            #endregion
            return oList;
        }
        #endregion
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
    #region User Permission
    public partial class User_permission
    {
        public User My_User { get; set; }
    }
    #endregion
    #region Floor Section
    public partial class Floor_section
    {
        public List<Uploaded_file> My_Uploaded_files { get; set; }
        public List<Zone> My_zones { get; set; }
    }
    #endregion
    #region Shape
    public partial class Shape
    {
        public List<Uploaded_file> My_Uploaded_files { get; set; }
    }
    #endregion
    #region Zone
    public partial class Zone
    {
        public List<Uploaded_file> My_Uploaded_files { get; set; }
        public List<Shape> My_Shapes { get; set; }
    }
    #endregion
    #region PLC_Test

    public class PLC_Tx_Rx
    {
        public string VariableName { get; set; }
        public string AMSID { get; set; }
        public int Port { get; set; }

        public PLC_Tx_Rx(string variableName, string aMSID, int port)
        {
            VariableName = variableName ?? throw new ArgumentNullException(nameof(variableName));
            AMSID = aMSID ?? throw new ArgumentNullException(nameof(aMSID));
            Port = port;
        }

        public Boolean? Set_Output()
        {
            Light_BLC.ctrLight twincatTest = new();
            try
            {
                return twincatTest.Set_Output(VariableName, AMSID, Port);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }
    }
    #endregion
    #endregion
}


