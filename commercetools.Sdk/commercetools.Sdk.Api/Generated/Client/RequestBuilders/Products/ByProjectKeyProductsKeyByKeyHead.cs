using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Products
{
    public partial class ByProjectKeyProductsKeyByKeyHead : ApiMethod<ByProjectKeyProductsKeyByKeyHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyProductsKeyByKeyHead(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/products/key={Key}";
        }




        public async Task<JsonElement> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<JsonElement>(requestMessage);
        }

    }
}
