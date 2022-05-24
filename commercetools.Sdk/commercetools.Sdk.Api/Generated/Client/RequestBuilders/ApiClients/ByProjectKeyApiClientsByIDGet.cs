using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ApiClients
{
    public partial class ByProjectKeyApiClientsByIDGet : ApiMethod<ByProjectKeyApiClientsByIDGet>, IApiMethod<ByProjectKeyApiClientsByIDGet, commercetools.Sdk.Api.Models.ApiClients.IApiClient>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyApiClientsByIDGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyApiClientsByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyApiClientsByIDGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/api-clients/{ID}";
        }




        public async Task<commercetools.Sdk.Api.Models.ApiClients.IApiClient> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ApiClients.IApiClient>(requestMessage);
        }

    }
}
