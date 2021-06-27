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
public partial class BLC
{
#region BLC_OnPostEvent_Get_Plc_By_OWNER_ID_Eager_Loading
void BLC_OnPostEvent_Get_Plc_By_OWNER_ID_Eager_Loading(List<Plc> i_Result, Params_Get_Plc_By_OWNER_ID i_Params_Get_Plc_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Hardware_link> oList_Hardware_link = new List<Hardware_link>();
Params_Get_Hardware_link_By_OWNER_ID oParams_Get_Hardware_link_By_OWNER_ID = new Params_Get_Hardware_link_By_OWNER_ID();
#endregion
#region PreEvent_General
if (OnPreEvent_General != null)
{
OnPreEvent_General("BLC_OnPostEvent_Get_Plc_By_OWNER_ID_Eager_Loading");
}
#endregion
#region Body Section
if (i_Result != null)
{
// Get All available Hardware_link entries.
// ---------------------
oParams_Get_Hardware_link_By_OWNER_ID = new Params_Get_Hardware_link_By_OWNER_ID();
oParams_Get_Hardware_link_By_OWNER_ID.OWNER_ID = this.OwnerID;
oList_Hardware_link = Get_Hardware_link_By_OWNER_ID_Adv(oParams_Get_Hardware_link_By_OWNER_ID);
// ---------------------
// ---------------------
foreach (var oRow_Plc in i_Result)
{
if ((from oItem in oList_Hardware_link where (oItem.PLC_ID == oRow_Plc.PLC_ID) select oItem).FirstOrDefault() != null)
{
oRow_Plc.My_Hardware_link = (from oItem in oList_Hardware_link where (oItem.PLC_ID == oRow_Plc.PLC_ID) select oItem).ToList();
}
}
// ---------------------
}
#endregion
#region PostEvent_General
if (OnPostEvent_General != null)
{
OnPostEvent_General("BLC_OnPostEvent_Get_Plc_By_OWNER_ID_Eager_Loading");
}
#endregion
}
#endregion
#region BLC_OnPostEvent_Get_Hardware_link_By_OWNER_ID_Eager_Loading
void BLC_OnPostEvent_Get_Hardware_link_By_OWNER_ID_Eager_Loading(List<Hardware_link> i_Result, Params_Get_Hardware_link_By_OWNER_ID i_Params_Get_Hardware_link_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Outlet> oList_Outlet = new List<Outlet>();
Params_Get_Outlet_By_OWNER_ID oParams_Get_Outlet_By_OWNER_ID = new Params_Get_Outlet_By_OWNER_ID();
#endregion
#region PreEvent_General
if (OnPreEvent_General != null)
{
OnPreEvent_General("BLC_OnPostEvent_Get_Hardware_link_By_OWNER_ID_Eager_Loading");
}
#endregion
#region Body Section
if (i_Result != null)
{
// Get All available Outlet entries.
// ---------------------
oParams_Get_Outlet_By_OWNER_ID = new Params_Get_Outlet_By_OWNER_ID();
oParams_Get_Outlet_By_OWNER_ID.OWNER_ID = this.OwnerID;
oList_Outlet = Get_Outlet_By_OWNER_ID_Adv(oParams_Get_Outlet_By_OWNER_ID);
// ---------------------
// ---------------------
foreach (var oRow_Hardware_link in i_Result)
{
if ((from oItem in oList_Outlet where (oItem.HARDWARE_LINK_ID == oRow_Hardware_link.HARDWARE_LINK_ID) select oItem).FirstOrDefault() != null)
{
oRow_Hardware_link.My_Outlet = (from oItem in oList_Outlet where (oItem.HARDWARE_LINK_ID == oRow_Hardware_link.HARDWARE_LINK_ID) select oItem).ToList();
}
}
// ---------------------
}
#endregion
#region PostEvent_General
if (OnPostEvent_General != null)
{
OnPostEvent_General("BLC_OnPostEvent_Get_Hardware_link_By_OWNER_ID_Eager_Loading");
}
#endregion
}
#endregion
#region Initialize_Eager_Loading_Mechanism
public void Initialize_Eager_Loading_Mechanism()
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
this.OnPostEvent_Get_Plc_By_OWNER_ID +=new PostEvent_Handler_Get_Plc_By_OWNER_ID(BLC_OnPostEvent_Get_Plc_By_OWNER_ID_Eager_Loading);
this.OnPostEvent_Get_Hardware_link_By_OWNER_ID +=new PostEvent_Handler_Get_Hardware_link_By_OWNER_ID(BLC_OnPostEvent_Get_Hardware_link_By_OWNER_ID_Eager_Loading);

#endregion
}
#endregion
}
}
