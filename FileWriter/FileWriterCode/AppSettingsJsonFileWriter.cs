
using Microsoft.Extensions.Configuration;

namespace FileWriter
{
    public class AppSettingsJsonFileWriter : BaseFileWriter
    {
        public AppSettingsJsonFileWriter(string filePath) : base(GetConfig())
        {
        }

        public static string GetConfig()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("/Users/noamari/Desktop/mamas2/FileWriter/FileWriter/FileWriter/appsettings.json");

            IConfiguration config = builder.Build();

            string filePath = config["appSettings:FilePath2"];
            return filePath;
        }

    }
}