using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http;

namespace ShoeTestsWithxUnit
{
    [ExcludeFromCodeCoverage]
    public class TestConfiguration
    {
        private static IConfiguration config;
        private static string environment = "DEV";
        public IConfiguration CreateConfig()
        {
            if (config == null)
            {
                config = new ConfigurationBuilder()
                    .AddJsonFile("specflow.runner.json", optional: false, reloadOnChange: true)
                    .Build();
            }
            return config;
        }

        public string GetConfigValue(string key)
        {
            return config[environment + ":" + key];
        }
       
    }
}
