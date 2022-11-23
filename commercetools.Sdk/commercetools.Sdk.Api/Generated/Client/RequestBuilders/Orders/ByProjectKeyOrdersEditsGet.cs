using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public partial class ByProjectKeyOrdersEditsGet : ApiMethod<ByProjectKeyOrdersEditsGet>, IApiMethod<ByProjectKeyOrdersEditsGet, commercetools.Sdk.Api.Models.OrderEdits.IOrderEditPagedQueryResponse>, commercetools.Sdk.Api.Models.IPagedQueryResourceRequest<ByProjectKeyOrdersEditsGet, commercetools.Sdk.Api.Models.OrderEdits.IOrderEditPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyOrdersEditsGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyOrdersEditsGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyOrdersEditsGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeyOrdersEditsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyOrdersEditsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyOrdersEditsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyOrdersEditsGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/orders/edits";
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

        public ByProjectKeyOrdersEditsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyOrdersEditsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyOrdersEditsGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyOrdersEditsGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyOrdersEditsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyOrdersEditsGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyOrdersEditsGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.OrderEdits.IOrderEditPagedQueryResponse> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.OrderEdits.IOrderEditPagedQueryResponse>(requestMessage, cancellationToken);
        }

    }
}
