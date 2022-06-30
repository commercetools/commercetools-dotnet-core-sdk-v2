using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.QuoteRequests
{
    public partial class ByProjectKeyQuoteRequestsGet : ApiMethod<ByProjectKeyQuoteRequestsGet>, IApiMethod<ByProjectKeyQuoteRequestsGet, commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyQuoteRequestsGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyQuoteRequestsGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyQuoteRequestsGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeyQuoteRequestsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyQuoteRequestsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyQuoteRequestsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyQuoteRequestsGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/quote-requests";
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

        public ByProjectKeyQuoteRequestsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyQuoteRequestsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyQuoteRequestsGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyQuoteRequestsGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyQuoteRequestsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyQuoteRequestsGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyQuoteRequestsGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestPagedQueryResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.QuoteRequests.IQuoteRequestPagedQueryResponse>(requestMessage);
        }

    }
}
