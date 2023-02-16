using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ShippingMethods
{

    public partial class ByProjectKeyShippingMethodsMatchingOrdereditGet : ApiMethod<ByProjectKeyShippingMethodsMatchingOrdereditGet>, IApiMethod<ByProjectKeyShippingMethodsMatchingOrdereditGet, commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyShippingMethodsMatchingOrdereditGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyShippingMethodsMatchingOrdereditGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyShippingMethodsMatchingOrdereditGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/shipping-methods/matching-orderedit";
        }

        public List<string> GetOrderEditId()
        {
            return this.GetQueryParam("orderEditId");
        }

        public List<string> GetCountry()
        {
            return this.GetQueryParam("country");
        }

        public List<string> GetState()
        {
            return this.GetQueryParam("state");
        }

        public ByProjectKeyShippingMethodsMatchingOrdereditGet WithOrderEditId(string orderEditId)
        {
            return this.AddQueryParam("orderEditId", orderEditId);
        }

        public ByProjectKeyShippingMethodsMatchingOrdereditGet WithCountry(string country)
        {
            return this.AddQueryParam("country", country);
        }

        public ByProjectKeyShippingMethodsMatchingOrdereditGet WithState(string state)
        {
            return this.AddQueryParam("state", state);
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
