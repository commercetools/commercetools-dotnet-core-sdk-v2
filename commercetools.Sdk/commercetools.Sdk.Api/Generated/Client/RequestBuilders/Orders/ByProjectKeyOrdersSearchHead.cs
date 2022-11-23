using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersSearchHead : ApiMethod<ByProjectKeyOrdersSearchHead>, IApiMethod<ByProjectKeyOrdersSearchHead, JsonElement>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyOrdersSearchHead>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyOrdersSearchHead>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Head;

        private string ProjectKey { get; }


        public ByProjectKeyOrdersSearchHead(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/orders/search";
        }




        public async Task<JsonElement> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<JsonElement>(requestMessage, cancellationToken);
        }

    }
}
