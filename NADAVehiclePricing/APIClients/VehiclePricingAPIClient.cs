using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;

namespace NADAVehiclePricing.APIClients
{
    public class VehiclePricingAPIClient
    {

        private const string apiName = "NADAVehiclePricing";
        private readonly MBBaseClient client;

        public VehiclePricingAPIClient(string authorization, Uri baseURL)
        {
            client = new MBBaseClient(authorization, baseURL);
        }

        /// <summary>
        /// Get all states from API
        /// </summary>
        /// <returns>List of statest, names and ids</returns>
        public JsonObject GetStates()
        {
            var url = new Uri(client.BaseAddress + apiName + "/GetStates");
            var response = client.GetAsync(url).Result;
            var result = JsonSerializer.Deserialize<JsonObject>(response.Content.ReadAsStream());
            return result;
        }

        /// <summary>
        /// Get all years from API
        /// </summary>
        /// <returns>List of years</returns>
        public JsonObject GetYears()
        {
            var url = new Uri(client.BaseAddress + apiName + "/GetYears");
            var response = client.GetAsync(url).Result;
            var result = JsonSerializer.Deserialize<JsonObject>(response.Content.ReadAsStream());
            return result;
        }

        /// <summary>
        /// Get all makers from API
        /// </summary>
        /// <param name="year"></param>
        /// <returns>JSON list of makers, names and ids</returns>
        public JsonObject GetGetMake(int year)
        {
            var url = new Uri(client.BaseAddress + apiName + "/GetMake?year=" + year.ToString());
            var response = client.GetAsync(url).Result;
            var result = JsonSerializer.Deserialize<JsonObject>(response.Content.ReadAsStream());
            return result;
        }

        /// <summary>
        /// Get all Series from API
        /// </summary>
        /// <param name="year">Use parameters from GetYears method response</param>
        /// <param name="make">Use Id parametr from GetGetMake method response</param>
        /// <returns>JSON list of series, names and ids</returns>
        public JsonObject GetGetSeries(int year, int make)
        {
            var url = new Uri(client.BaseAddress + apiName + string.Format("/GetSeries?year={0}&make={1}", year, make));
            var response = client.GetAsync(url).Result;
            var result = JsonSerializer.Deserialize<JsonObject>(response.Content.ReadAsStream());
            return result;
        }

        /// <summary>
        /// Get body parameters from API
        /// </summary>
        /// <param name="year">Use parameters from GetYears method response</param>
        /// <param name="make">Use Id parametr from GetGetMake method response</param>
        /// <param name="series">Use Id parametr from GetGetSeries method response</param>
        /// <returns>JSON list of body, names and ids </returns>
        public JsonObject GetBody(int year, int make, int series)
        {
            var url = new Uri(client.BaseAddress + apiName + string.Format("/GetBody?year={0}&make={1}&series={2}", year, make, series));
            var response = client.GetAsync(url).Result;
            var result = JsonSerializer.Deserialize<JsonObject>(response.Content.ReadAsStream());
            return result;
        }

        /// <summary>
        /// Get report from API
        /// </summary>
        /// <param name="requestBody">For body use parameters from others requests</param>
        /// <returns>Json report</returns>
        public JsonObject GetReport(string requestBody)
        {
            var url = new Uri(client.BaseAddress + apiName + "/GetReport");
            var content = new StringContent(requestBody, Encoding.UTF8, "application/json");
            var response = client.PostAsync(url, content).Result;
            var result = JsonSerializer.Deserialize<JsonObject>(response.Content.ReadAsStream());
            return result;
        }
    }
}
