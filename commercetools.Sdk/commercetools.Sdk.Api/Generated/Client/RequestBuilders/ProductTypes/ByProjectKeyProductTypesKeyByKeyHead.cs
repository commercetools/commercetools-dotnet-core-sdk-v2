using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System.Text.Json;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductTypes
{

    public partial class ByProjectKeyProductTypesKeyByKeyHead : ApiMethod<ByProjectKeyProductTypesKeyByKeyHead>, IApiMethod<ByProjectKeyProductTypesKeyByKeyHead, JsonElement>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductTypesKeyByKeyHead>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyProductTypesKeyByKeyHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyProductTypesKeyByKeyHead(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/product-types/key={Key}";
        }




        public async Task<JsonElement> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<JsonElement>(requestMessage, cancellationToken);
        }

    }
}
