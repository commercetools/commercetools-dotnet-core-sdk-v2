using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Subscriptions
{
    public partial class ByProjectKeySubscriptionsGet : ApiMethod<ByProjectKeySubscriptionsGet>, IApiMethod<ByProjectKeySubscriptionsGet, commercetools.Sdk.Api.Models.Subscriptions.ISubscriptionPagedQueryResponse>, commercetools.Sdk.Api.Models.IPagedQueryResourceRequest<ByProjectKeySubscriptionsGet, commercetools.Sdk.Api.Models.Subscriptions.ISubscriptionPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeySubscriptionsGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeySubscriptionsGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeySubscriptionsGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeySubscriptionsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeySubscriptionsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeySubscriptionsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeySubscriptionsGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/subscriptions";
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

        public ByProjectKeySubscriptionsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeySubscriptionsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeySubscriptionsGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeySubscriptionsGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeySubscriptionsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeySubscriptionsGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeySubscriptionsGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.Subscriptions.ISubscriptionPagedQueryResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Subscriptions.ISubscriptionPagedQueryResponse>(requestMessage);
        }

    }
}
