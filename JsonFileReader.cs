using System.IO;

namespace olo
{
    public class JsonFileReader
    {
        public string GetJsonFileContent(string targetJsonFile)
        {
            using (StreamReader reader = new StreamReader(targetJsonFile))
            {
                reader.ReadToEndAsync();
            }

            return string.Empty;
        }
    }
}