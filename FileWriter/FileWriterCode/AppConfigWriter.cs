using System.Configuration;


namespace FileWriter
{
    public class AppConfigWriter : BaseFileWriter
    {
        public string FilePath { get; private set; }

        public AppConfigWriter(string filePath) : base(ConfigurationManager.AppSettings["FilePath"])
        {
            FilePath = filePath;
        }

    }
}