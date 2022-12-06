using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartGet>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartGet, commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string StoreKey { get; }


        public ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartGet(IClient apiHttpClient, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/shipping-methods/matching-cart";
        }

        public List<string> GetCartId()
        {
            return this.GetQueryParam("cartId");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartGet WithCartId(string cartId)
        {
            return this.AddQueryParam("cartId", cartId);
        }

        public ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>(requestMessage, cancellationToken);
        }

    }
}
