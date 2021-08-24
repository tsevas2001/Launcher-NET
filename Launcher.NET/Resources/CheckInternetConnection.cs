using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.NET.Resources
{
    class CheckInternetConnection
    {

        public bool IsConnectedToInternet()
        {
            string host = "google.com";
            bool result = false;
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 2000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }
            return result;
        }
        
        public String CheckServerPing(String host)
        {
            Ping p = new Ping();
            //string s = "google.com";

            try
            {
                PingReply r = p.Send(host, 2000);
                if (r.Status == IPStatus.Success)
                {
                    return r.RoundtripTime.ToString();
                }
                else
                    return "Something went wrong!";
            }
            catch
            {
                return "Something went wrong!";
            }
            
        }
    }

    



}
