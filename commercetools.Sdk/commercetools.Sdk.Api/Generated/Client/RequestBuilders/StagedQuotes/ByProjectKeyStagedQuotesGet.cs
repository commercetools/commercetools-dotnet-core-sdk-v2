using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.StagedQuotes
{
    public partial class ByProjectKeyStagedQuotesGet : ApiMethod<ByProjectKeyStagedQuotesGet>, IApiMethod<ByProjectKeyStagedQuotesGet, commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuotePagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyStagedQuotesGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyStagedQuotesGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyStagedQuotesGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeyStagedQuotesGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyStagedQuotesGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyStagedQuotesGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyStagedQuotesGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/staged-quotes";
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

        public ByProjectKeyStagedQuotesGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyStagedQuotesGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyStagedQuotesGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyStagedQuotesGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyStagedQuotesGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyStagedQuotesGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyStagedQuotesGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuotePagedQueryResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.StagedQuotes.IStagedQuotePagedQueryResponse>(requestMessage);
        }

    }
}
