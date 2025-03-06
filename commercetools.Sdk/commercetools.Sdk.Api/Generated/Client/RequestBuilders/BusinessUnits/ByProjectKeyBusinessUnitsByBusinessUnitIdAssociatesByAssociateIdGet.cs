using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.BusinessUnits
{

    public partial class ByProjectKeyBusinessUnitsByBusinessUnitIdAssociatesByAssociateIdGet : ApiMethod<ByProjectKeyBusinessUnitsByBusinessUnitIdAssociatesByAssociateIdGet>, IApiMethod<ByProjectKeyBusinessUnitsByBusinessUnitIdAssociatesByAssociateIdGet, commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitAssociateResponse>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyBusinessUnitsByBusinessUnitIdAssociatesByAssociateIdGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyBusinessUnitsByBusinessUnitIdAssociatesByAssociateIdGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string BusinessUnitId { get; }

        private string AssociateId { get; }


        public ByProjectKeyBusinessUnitsByBusinessUnitIdAssociatesByAssociateIdGet(IClient apiHttpClient, string projectKey, string businessUnitId, string associateId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.BusinessUnitId = businessUnitId;
            this.AssociateId = associateId;
            this.RequestUrl = $"/{ProjectKey}/business-units/{BusinessUnitId}/associates/{AssociateId}";
        }




        public async Task<commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitAssociateResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitAssociateResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitAssociateResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitAssociateResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
