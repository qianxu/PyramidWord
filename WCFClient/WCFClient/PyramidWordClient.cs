using System.ServiceModel;
using System.Threading.Tasks;
using WCFClient.PyramidWordServiceReference;

namespace WCFClient
{
    class PyramidWordClient : ClientBase<IPyramidWordService>
    {
        public PyramidWordClient()
        {
        }

        public async Task<bool> IsPyramidWordAsync(string word)
        {
            return await Channel.IsPyramidWordAsync(word);
        }
    }
}
