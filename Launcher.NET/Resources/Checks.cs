using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.NET.Resources
{
    class Checks
    {
        public bool CheckForUpdatesAsync()
        {
            WebClient webClient = new WebClient();

            //get my own version to compare against latest.
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            Version myVersion = new Version(fvi.ProductVersion);

            try
            {
                if (webClient.DownloadString("https://pastebin.com/q1KyFdiG").Contains(myVersion.ToString()) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool checkWindowsDefender()
        {
            var path = @"SOFTWARE\Microsoft\Windows Defender\Real-Time Protection";
            var key = "DisableRealtimeMonitoring";
            var regkey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            if (regkey != null)
            {
                var subkey = regkey.OpenSubKey(path);
                var val = subkey.GetValue(key);
                if (val != null && val is Int32)
                {
                    var value = (int)val;
                    if (value == 1)
                    {
                        // Protection off
                        return false;
                    }
                    else
                    {
                        //value.Dump("Protection is on");
                        return true;
                    }
                }
                else
                {
                    //"probably".Dump("Protection is on");
                    return true;
                }
            }
            else
            {
                //"huh?".Dump("key is not found");
                return false;
            }
        }
    }
}
