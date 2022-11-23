using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ApiClients
{

    public partial class ByProjectKeyApiClientsByIDDelete : ApiMethod<ByProjectKeyApiClientsByIDDelete>, IApiMethod<ByProjectKeyApiClientsByIDDelete, commercetools.Sdk.Api.Models.ApiClients.IApiClient>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyApiClientsByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyApiClientsByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyApiClientsByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/api-clients/{ID}";
        }




        public async Task<commercetools.Sdk.Api.Models.ApiClients.IApiClient> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ApiClients.IApiClient>(requestMessage, cancellationToken);
        }

    }
}
