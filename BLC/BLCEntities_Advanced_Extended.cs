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
#region Hardware_link
public partial class Hardware_link
{
#region Advanced Properties
public List<Outlet> My_Outlet {get;set;}
#endregion
}
#endregion
#region Plc
public partial class Plc
{
#region Advanced Properties
public List<Hardware_link> My_Hardware_link {get;set;}
#endregion
}
#endregion
}
