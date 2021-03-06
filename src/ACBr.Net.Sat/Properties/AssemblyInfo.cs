﻿using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
#if COM_INTEROP
[assembly: AssemblyTitle("ACBr.Net S@T ActiveX")]
[assembly: AssemblyDescription("ACBr.Net S@T ActiveX")]
[assembly: AssemblyProduct("ACBr.Net S@T ActiveX")]
[assembly: TypeLibVersion(109, 23)]
#else
[assembly: AssemblyTitle("ACBr.Net S@T")]
[assembly: AssemblyDescription("ACBr.Net S@T")]
[assembly: AssemblyProduct("ACBr.Net S@T")]
#endif

[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("ACBr.Net")]
[assembly: AssemblyCopyright("Copyright © Grupo ACBr.Net 2014 - 2016")]
[assembly: AssemblyTrademark("Grupo ACBr.Net https://acbrnet.github.io")]
[assembly: AssemblyKeyFile(@"../../../acbr.net.snk")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
#if COM_INTEROP
[assembly: ComVisible(true)]
#else
[assembly: ComVisible(false)]
#endif

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("ee443d74-27e7-4236-851e-5e31a8ab8e63")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.1.0")]