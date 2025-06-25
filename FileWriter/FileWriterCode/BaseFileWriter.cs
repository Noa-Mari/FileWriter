

namespace FileWriter
{
    public abstract class BaseFileWriter
    {
        private Func<string> getConfig;

        public string FilePath { get; private set; }

        public BaseFileWriter(string filePath)
        {
            FilePath = filePath;
        }

        protected BaseFileWriter(Func<string> getConfig)
        {
            this.getConfig = getConfig;
        }

        public void WriteLine(string line)
        {
            StreamWriter sw = new StreamWriter(FilePath,true);
            sw.WriteLine(line);
            sw.Close();
        }
        
    }
}