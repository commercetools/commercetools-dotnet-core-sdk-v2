using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductTypes
{

    public partial class ByProjectKeyProductTypesByIDHead : ApiMethod<ByProjectKeyProductTypesByIDHead>, IApiMethod<ByProjectKeyProductTypesByIDHead, JsonElement>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductTypesByIDHead>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyProductTypesByIDHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyProductTypesByIDHead(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/product-types/{ID}";
        }




        public async Task<JsonElement> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<JsonElement>(requestMessage, cancellationToken);
        }

    }
}
