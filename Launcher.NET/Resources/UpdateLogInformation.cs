using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.NET.Resources
{
    public class ULogInformation
    {
        [JsonProperty("date")]
        public String date { get; set; }
        [JsonProperty("changes")]
        public List<Change> changes { get; set; }
    }
    public class Change
    {
        [JsonProperty("status")]
        public String status;
        [JsonProperty("log")]
        public String log;
    }

    class UpdateLogInformation
    {
        static readonly HttpClient client = new HttpClient();

        public async Task<List<ULogInformation>> UpdateInfo(string url)
        {
            //client.CancelPendingRequests();

            List<ULogInformation> info = new List<ULogInformation>();
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                info = JsonConvert.DeserializeObject<List<ULogInformation>>(responseBody);


                return info;

            }
            catch { return info; }

        }
    }

}
