using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace CountryAPI
{
    public class Client
    {
        public static async Task<Country> GetCountryAsync(string code)
        {
            Country country = null;

            dynamic countryData = null;

            using (var client = new HttpClient())
            {
                var response =
                    await client.GetAsync($"http://api.worldbank.org/v2/country/{code}?format=json");
                
                if (response.IsSuccessStatusCode)
                {
                    var stringResponse = await response.Content.ReadAsStringAsync();

                    if (stringResponse.Contains("Invalid value"))
                    {
                        return country;
                    }

                    countryData = JsonConvert.DeserializeObject<dynamic>(stringResponse)!;
                }
                else
                {
                    Console.WriteLine($"\nStatus Code: {response.StatusCode}");
                    Environment.Exit(0);
                }

                country = new Country
                {
                    Name = countryData?[1][0].name,
                    Region = countryData?[1][0].region["value"],
                    CapitalCity = countryData?[1][0].capitalCity,
                    Longitude = countryData?[1][0].longitude,
                    Latitude = countryData?[1][0].latitude
                };

                return country;
            }
        }
    }
}
