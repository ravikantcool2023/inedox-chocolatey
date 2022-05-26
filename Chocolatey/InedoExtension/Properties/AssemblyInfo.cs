﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Inedo.Extensibility;

[assembly: AssemblyTitle("Chocolatey")]
[assembly: AssemblyDescription("Contains operations for working with Chocolatey.")]
[assembly: AssemblyProduct("any")]
[assembly: AssemblyCompany("Inedo, LLC")]
[assembly: AssemblyCopyright("Copyright © Inedo 2022")]
[assembly: AssemblyVersion("2.0.1")]
[assembly: AssemblyFileVersion("2.0.1")]

[assembly: ComVisible(false)]
[assembly: CLSCompliant(false)]

[assembly: ScriptNamespace("Chocolatey")]
[assembly: AppliesTo(InedoProduct.BuildMaster | InedoProduct.Otter)]
