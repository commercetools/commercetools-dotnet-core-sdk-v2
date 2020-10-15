using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Api.Serialization;
using commercetools.Sdk.Client;
using IClient = commercetools.Sdk.Client.IClient;
using IClientV2 = commercetools.Api.Client.IClient;

namespace commercetools.Sdk.V2Compat
{
    public class CtpV2CompatClient: IClientV2
    {
        private IClient client;

        public CtpV2CompatClient(IClient client)
        {
            this.client = client;
        }

        public ISerializerService SerializerService { get; }
        
        public string Name { get; set; }
        public async Task<T> ExecuteAsync<T>(HttpRequestMessage requestMessage)
        {
            return await client.ExecuteAsync(new HttpRequestCommand<T>(requestMessage));
        }

        public Task<string> ExecuteAsJsonAsync(HttpRequestMessage requestMessage)
        {
            throw new System.NotImplementedException();
        }
    }
}