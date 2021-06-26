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
#region Floor
public partial class Floor
{
#region Advanced Properties
#endregion
}
#endregion
#region Hardware_link
public partial class Hardware_link
{
#region Advanced Properties
public Plc My_Plc {get;set;}
#endregion
}
#endregion
#region Outlet
public partial class Outlet
{
#region Advanced Properties
public Outlet_type My_Outlet_type {get;set;}
public Hardware_link My_Hardware_link {get;set;}
public Room My_Room {get;set;}
#endregion
}
#endregion
#region Outlet_type
public partial class Outlet_type
{
#region Advanced Properties
#endregion
}
#endregion
#region Outlet_ui
public partial class Outlet_ui
{
#region Advanced Properties
public Outlet My_Outlet {get;set;}
public Ui My_Ui {get;set;}
#endregion
}
#endregion
#region Owner
public partial class Owner
{
#region Advanced Properties
#endregion
}
#endregion
#region Plc
public partial class Plc
{
#region Advanced Properties
#endregion
}
#endregion
#region Room
public partial class Room
{
#region Advanced Properties
public Floor My_Floor {get;set;}
#endregion
}
#endregion
#region Ui
public partial class Ui
{
#region Advanced Properties
#endregion
}
#endregion
#region Uploaded_file
public partial class Uploaded_file
{
#region Advanced Properties
#endregion
}
#endregion
#region User
public partial class User
{
#region Advanced Properties
#endregion
}
#endregion
}
