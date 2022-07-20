// See https://aka.ms/new-console-template for more information
using System;
using Microsoft.Win32;
Console.WriteLine("Welcome to Dock Fix 0.01");
Console.WriteLine("");
Console.WriteLine("This utility resets your ...");
Console.WriteLine("Unplug your Surface Dock now!");
Console.WriteLine("Press any key to continue...");
ConsoleKeyInfo keyPress = Console.ReadKey();
RegistryKey rk = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", true);
rk.DeleteSubKeyTree("Configuration");
rk.DeleteSubKeyTree("Connectivity");
rk.DeleteSubKeyTree("ScaleFactors");
//string[] names = rk.GetSubKeyNames();
//foreach (string s in names)
//{
//    Console.WriteLine(s);
//}
Console.WriteLine("Plug your Surface Dock back in now.");
Console.WriteLine("Press any key to continue...");
keyPress = Console.ReadKey();
System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("displayswitch.exe", "/extend");
System.Diagnostics.Process proc = new System.Diagnostics.Process();
proc.StartInfo = procStartInfo;
proc.Start();
Console.WriteLine("Okay, we're done!");
Console.WriteLine("Press any key to exit...");
keyPress = Console.ReadKey();