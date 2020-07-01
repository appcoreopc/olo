using System.IO;
using System.Threading.Tasks;

namespace Olo
{
    public class JsonFileReader : IJsonFileReader
    {
        public async Task<string> GetJsonFileContent(string targetJsonFile)
        {
            using (StreamReader reader = new StreamReader(targetJsonFile))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}