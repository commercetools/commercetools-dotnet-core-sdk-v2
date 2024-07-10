using System.Globalization;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet, commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string StoreKey { get; }


        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet(IClient apiHttpClient, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/quote-requests";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public List<string> GetSort()
        {
            return this.GetQueryParam("sort");
        }

        public List<string> GetLimit()
        {
            return this.GetQueryParam("limit");
        }

        public List<string> GetOffset()
        {
            return this.GetQueryParam("offset");
        }

        public List<string> GetWithTotal()
        {
            return this.GetQueryParam("withTotal");
        }

        public List<string> GetWhere()
        {
            return this.GetQueryParam("where");
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet WithLimit(long limit)
        {
            return this.AddQueryParam("limit", limit.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet WithOffset(long offset)
        {
            return this.AddQueryParam("offset", offset.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyInStoreKeyByStoreKeyQuoteRequestsGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestPagedQueryResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestPagedQueryResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
