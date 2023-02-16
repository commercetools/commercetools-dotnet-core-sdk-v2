using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ShippingMethods
{

    public partial class ByProjectKeyShippingMethodsMatchingCartLocationGet : ApiMethod<ByProjectKeyShippingMethodsMatchingCartLocationGet>, IApiMethod<ByProjectKeyShippingMethodsMatchingCartLocationGet, commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyShippingMethodsMatchingCartLocationGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyShippingMethodsMatchingCartLocationGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyShippingMethodsMatchingCartLocationGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyShippingMethodsMatchingCartLocationGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/shipping-methods/matching-cart-location";
        }

        public List<string> GetCountry()
        {
            return this.GetQueryParam("country");
        }

        public List<string> GetState()
        {
            return this.GetQueryParam("state");
        }

        public List<string> GetCartId()
        {
            return this.GetQueryParam("cartId");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyShippingMethodsMatchingCartLocationGet WithCountry(string country)
        {
            return this.AddQueryParam("country", country);
        }

        public ByProjectKeyShippingMethodsMatchingCartLocationGet WithState(string state)
        {
            return this.AddQueryParam("state", state);
        }

        public ByProjectKeyShippingMethodsMatchingCartLocationGet WithCartId(string cartId)
        {
            return this.AddQueryParam("cartId", cartId);
        }

        public ByProjectKeyShippingMethodsMatchingCartLocationGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
