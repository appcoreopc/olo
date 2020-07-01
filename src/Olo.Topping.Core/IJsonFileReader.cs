using System.Threading.Tasks;

namespace Olo
{
    public interface IJsonFileReader
    {
        Task<string> GetJsonFileContent(string targetJsonFile);
    }
}