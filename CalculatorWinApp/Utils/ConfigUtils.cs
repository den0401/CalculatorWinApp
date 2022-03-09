using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace CalculatorWinApp.Utils
{
    public static class ConfigUtils
    {
        private static readonly string _appsettings = "./Resources/appsettings.json";

        public static string GetConfigProperties(string key) => GetSpecificProperties(_appsettings, key);

        private static string GetSpecificProperties(string propertyPath, string key)
        {
            AppDomain domain = AppDomain.CurrentDomain;
            JObject jsonObject = JObject.Parse(File.ReadAllText(domain.BaseDirectory + propertyPath));
            string jsonString = jsonObject.ToString(Newtonsoft.Json.Formatting.None);

            return JObject.Parse(jsonString)[key].ToString();
        }
    }
}