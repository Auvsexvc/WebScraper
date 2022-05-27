using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WebScraper
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var countryScraper = new CountryScraper();
            var countries = countryScraper.GetCountries().Take(10);

            var cityScraper = new CityScraper();

            var result = new List<CountryDetails>();

            foreach (var country in countries)
            {
                Console.WriteLine($"Getting cities for : {country.Name}");
                var cities = cityScraper.GetCities(country).ToList();

                result.Add(new CountryDetails
                {
                    Code = country.Code,
                    Name = country.Name,
                    Cities = cities
                });
                cityScraper.GetCities(country);
            }
            var json = JsonConvert.SerializeObject(result);

            File.WriteAllText(@"c:\etc\blablabla.json", json);
            Console.WriteLine("Finished");
        }
    }
}