namespace WebScraper
{
    public class CityModel
    {
        public CityModel(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public string Code { get; set; }
        public string Name { get; set; }
    }
}