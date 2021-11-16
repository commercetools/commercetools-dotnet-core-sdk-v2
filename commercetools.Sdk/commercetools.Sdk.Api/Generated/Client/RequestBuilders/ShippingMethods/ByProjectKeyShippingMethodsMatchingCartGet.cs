using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Api.Client.RequestBuilders.ShippingMethods
{
    public partial class ByProjectKeyShippingMethodsMatchingCartGet : ApiMethod<ByProjectKeyShippingMethodsMatchingCartGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyShippingMethodsMatchingCartGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/shipping-methods/matching-cart";
        }

        public List<string> GetCartId()
        {
            return this.GetQueryParam("cartId");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyShippingMethodsMatchingCartGet WithCartId(string cartId)
        {
            return this.AddQueryParam("cartId", cartId);
        }

        public ByProjectKeyShippingMethodsMatchingCartGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>(requestMessage);
        }

    }
}
