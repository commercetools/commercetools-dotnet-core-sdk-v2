using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.BusinessUnits
{

    public partial class ByProjectKeyBusinessUnitsSearchIndexingStatusGet : ApiMethod<ByProjectKeyBusinessUnitsSearchIndexingStatusGet>, IApiMethod<ByProjectKeyBusinessUnitsSearchIndexingStatusGet, commercetools.Sdk.Api.Models.BusinessUnitSearches.IBusinessUnitSearchIndexingStatusResponse>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyBusinessUnitsSearchIndexingStatusGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyBusinessUnitsSearchIndexingStatusGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyBusinessUnitsSearchIndexingStatusGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/business-units/search/indexing-status";
        }




        public async Task<commercetools.Sdk.Api.Models.BusinessUnitSearches.IBusinessUnitSearchIndexingStatusResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.BusinessUnitSearches.IBusinessUnitSearchIndexingStatusResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.BusinessUnitSearches.IBusinessUnitSearchIndexingStatusResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.BusinessUnitSearches.IBusinessUnitSearchIndexingStatusResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
