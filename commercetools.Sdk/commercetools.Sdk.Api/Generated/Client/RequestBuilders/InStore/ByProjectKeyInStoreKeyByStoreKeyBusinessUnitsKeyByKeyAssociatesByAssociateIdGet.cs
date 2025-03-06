using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyAssociatesByAssociateIdGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyAssociatesByAssociateIdGet>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyAssociatesByAssociateIdGet, commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitAssociateResponse>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyAssociatesByAssociateIdGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyAssociatesByAssociateIdGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }

        private string AssociateId { get; }


        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyAssociatesByAssociateIdGet(IClient apiHttpClient, string projectKey, string storeKey, string key, string associateId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
            this.AssociateId = associateId;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/business-units/key={Key}/associates/{AssociateId}";
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
