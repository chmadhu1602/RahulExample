using Newtonsoft.Json.Linq;
using RahulRathoreFinalVersion.Settings;
using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.Interfaces;
using System.Text.Json;

namespace RahulRathoreFinalVersion.Configuration
{
    public class AppJsonReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            string JsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appSettings.json");
            String JsonText = File.ReadAllText(JsonPath);
            var JsonUN = JsonSerializer.Deserialize<AppJsonKeys>(JsonText, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            //return JsonUN.Browser;
            string browserName = JsonUN.Browser;
            return (BrowserType)Enum.Parse(typeof(BrowserType), browserName);
        }

        public string GetWebsite()
        {
            string JsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appSettings.json");
            String JsonText = File.ReadAllText(JsonPath);
            var JsonUN = JsonSerializer.Deserialize<AppJsonKeys>(JsonText, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return JsonUN.Website;
        }
     

        public string GetPassword()
        {
            string JsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appSettings.json");
            String JsonText = File.ReadAllText(JsonPath);
            var JsonUN = JsonSerializer.Deserialize<AppJsonKeys>(JsonText);

            return JsonUN.Password;
        }

        public int GetElementLoadTimeOut()
        {
           
            string JsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appSettings.json");
            String JsonText = File.ReadAllText(JsonPath);
            var JsonUN = JsonSerializer.Deserialize<AppJsonKeys>(JsonText);

            if (JsonUN.ElementLoadTimeout == null)
                return 30;
            return Convert.ToInt32(JsonUN.ElementLoadTimeout);
        }

        public int GetPageLoadTimeOut()
        {
            string JsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appSettings.json");
            String JsonText = File.ReadAllText(JsonPath);
            var JsonUN = JsonSerializer.Deserialize<AppJsonKeys>(JsonText);

            if (JsonUN.PageLoadTimeout == null)
                return 30;
            return Convert.ToInt32(JsonUN.PageLoadTimeout);
        }

        public string GetUsername()
        {
            string JsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appSettings.json");
            String JsonText = File.ReadAllText(JsonPath);
            var JsonUN = JsonSerializer.Deserialize<AppJsonKeys>(JsonText);

            return JsonUN.UserName;
        }

        public string GetSeverity(string token)
        {
           var jsonString= File.ReadAllText("appSettings.json");
            var parsedJson = JToken.Parse(jsonString);
            var severity= parsedJson.SelectToken(token).Value<string>();
            return severity;
        }

        public string GetHardware(string token)
        {
            var jsonString = File.ReadAllText("appSettings.json");
            var parsedJson = JToken.Parse(jsonString);
            var hardware = parsedJson.SelectToken(token).Value<string>();
            return hardware;
        }

        public string GetOS(string token)
        {
            var jsonString = File.ReadAllText("appSettings.json");
            var parsedJson = JToken.Parse(jsonString);
            var os = parsedJson.SelectToken(token).Value<string>();
            return os;
        }

        public string GetShortDesc(string token)
        {
            var jsonString = File.ReadAllText("appSettings.json");
            var parsedJson = JToken.Parse(jsonString);
            var shortDesc = parsedJson.SelectToken(token).Value<string>();
            return shortDesc;
        }

        public string GetDesc(string token)
        {
            var jsonString = File.ReadAllText("appSettings.json");
            var parsedJson = JToken.Parse(jsonString);
            var Desc = parsedJson.SelectToken(token).Value<string>();
            return Desc;
        }
    }
}
