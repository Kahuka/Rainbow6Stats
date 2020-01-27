using R6Stats.Core.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace R6Stats.Core
{
    public class DataService
    {
        public static async Task<Profiles> GetR6Profiles(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            Profiles data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<Profiles>(response);
                return data;
            }
            return null;
        }

        public static async Task<OverallData> R6OverallData(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            OverallData data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<OverallData>(response);
                return data;
            }
            return null;
        }

        public static async Task<Stats> SeasonalData(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            Stats data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<Stats>(response);
                return data;
            }
            return null;
        }

    }
}
