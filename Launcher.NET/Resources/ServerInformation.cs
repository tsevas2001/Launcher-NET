using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.NET.Resources
{   
    public class ServerIp
    {
        [JsonProperty("ip")]
        public String ip { get; set; }
        [JsonProperty("discord")]
        public String discord { get; set; }
        [JsonProperty("name")]
        public String Name { get; set; }
    }



    public class ServerInfo
    {
        [JsonProperty("vars")]
        public Var vars { get; set; }
    }

    public class Var
    {
        [JsonProperty("sv_maxClients")]
        public int sv_maxClients;
    }

    public class Players
    {
        public String name { get; set; }
        public int id { get; set; }

        public int ping { get; set; }

    }

    class ServerInformation
    {
        static readonly HttpClient client = new HttpClient();

        public String status;

        public async Task<List<Players>> PlayerInfo(string url)
        {
            List<Players> player = new List<Players>();
            try
            {
                HttpResponseMessage response = await client.GetAsync(url + "/players.json");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                player = JsonConvert.DeserializeObject<List<Players>>(responseBody);

                status = "ONLINE";
                return player;
                //Console.WriteLine(player.Count);
                //Console.WriteLine(responseBody);
            }
            catch
            {
                //Console.WriteLine("\nException Caught!");
                //Console.WriteLine("Message :{0} ", i.Message);
                status = "OFFLINE";
                return player;
            }
        }

        public async Task<ServerInfo> SInfo(string url)
        {
            //client.CancelPendingRequests();
            
            ServerInfo vars = new ServerInfo();
            try
            {
                HttpResponseMessage response = await client.GetAsync(url + "/info.json");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                vars = JsonConvert.DeserializeObject<ServerInfo>(responseBody);
               

                return vars;

            }
            catch{ return vars; }

        }

        public async Task<List<ServerIp>> IpInfo (string url)
        {
            List<ServerIp> info = new List<ServerIp>();

            try
            {
                HttpResponseMessage response = await client.GetAsync(url + "/servers.json");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                info = JsonConvert.DeserializeObject<List<ServerIp>>(responseBody);


                return info;

            }
            catch { return info; }
        }
    }
}
