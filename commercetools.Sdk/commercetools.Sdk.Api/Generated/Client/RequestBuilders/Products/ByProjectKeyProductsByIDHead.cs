using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Products
{
    public partial class ByProjectKeyProductsByIDHead : ApiMethod<ByProjectKeyProductsByIDHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyProductsByIDHead(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/products/{ID}";
        }




        public async Task<JsonElement> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<JsonElement>(requestMessage);
        }

    }
}
