using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ShippingMethods
{

    public partial class ByProjectKeyShippingMethodsMatchingLocationGet : ApiMethod<ByProjectKeyShippingMethodsMatchingLocationGet>, IApiMethod<ByProjectKeyShippingMethodsMatchingLocationGet, commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyShippingMethodsMatchingLocationGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyShippingMethodsMatchingLocationGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyShippingMethodsMatchingLocationGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyShippingMethodsMatchingLocationGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyShippingMethodsMatchingLocationGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/shipping-methods/matching-location";
        }

        public List<string> GetCountry()
        {
            return this.GetQueryParam("country");
        }

        public List<string> GetState()
        {
            return this.GetQueryParam("state");
        }

        public List<string> GetCurrency()
        {
            return this.GetQueryParam("currency");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public List<string> GetSort()
        {
            return this.GetQueryParam("sort");
        }

        public ByProjectKeyShippingMethodsMatchingLocationGet WithCountry(string country)
        {
            return this.AddQueryParam("country", country);
        }

        public ByProjectKeyShippingMethodsMatchingLocationGet WithState(string state)
        {
            return this.AddQueryParam("state", state);
        }

        public ByProjectKeyShippingMethodsMatchingLocationGet WithCurrency(string currency)
        {
            return this.AddQueryParam("currency", currency);
        }

        public ByProjectKeyShippingMethodsMatchingLocationGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyShippingMethodsMatchingLocationGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }


        public async Task<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ShippingMethods.IShippingMethodPagedQueryResponse>(requestMessage, cancellationToken);
        }

    }
}
