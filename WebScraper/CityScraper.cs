using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebScraper
{
    public class CityScraper
    {
        public IEnumerable<CityModel> GetCities(CountryModel country)
        {
            var web = new HtmlWeb();
            var document = web.Load(country.Href);
            var tableRows = document.QuerySelectorAll("body > table:nth-child(3) tr").Skip(1);

            foreach (var item in tableRows)
            {
                var tds = item.QuerySelectorAll("td");
                var code = tds[1].InnerText;
                var cityName = tds[2].InnerText;

                yield return new CityModel(code, cityName);
            }
        }
    }
}