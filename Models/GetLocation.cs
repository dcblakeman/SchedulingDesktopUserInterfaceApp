using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Net.Http;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;


namespace SchedulingDesktopUserInterfaceApp.Models
{
    class GetLocation
    {
        public static async Task GetTask()
        {
            string ipGeolocationUrl = "http://ip-api.com/json";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(ipGeolocationUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);

                string latitude = json["lat"].ToString();
                string longitude = json["lon"].ToString();

                Console.WriteLine($"Latitude: {latitude}, Longitude: {longitude}");
            }
        }

        public static async Task GetLocationDetails()
        {
            await GetTask();
        }
        
    }

}
