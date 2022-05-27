namespace WebScraper
{
    public class CountryModel
    {
        public CountryModel(string code, string name, string href)
        {
            Code = code;
            Name = name;
            Href = href;
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }
    }
}