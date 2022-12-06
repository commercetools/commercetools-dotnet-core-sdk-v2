using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Serialization;
using commercetools.Sdk.Client;
using IClient = commercetools.Sdk.Client.IClient;
using IClientV2 = commercetools.Base.Client.IClient;

namespace commercetools.Sdk.V2Compat
{
    public class CtpV2CompatClient : IClientV2
    {
        private IClient client;

        public CtpV2CompatClient(IClient client)
        {
            this.client = client;
        }

        public ISerializerService SerializerService { get; }

        public string Name { get; set; }
        public async Task<T> ExecuteAsync<T>(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default)
        {
            return await client.ExecuteAsync(new HttpRequestCommand<T>(requestMessage));
        }

        public Task<string> ExecuteAsJsonAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}