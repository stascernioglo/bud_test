using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryAPI
{
    public class Country
    {
        public string? Name { get; set; }
        public string? Region { get; set; }
        public string? CapitalCity { get; set; }
        public string? Longitude { get; set; }
        public string? Latitude { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"\nCountry Name: {Name}\nRegion: {Region}\nCapital City: {CapitalCity}" +
                $"\nLongitude: {Longitude}\nLatitude: {Latitude}");
        }

    }
}
