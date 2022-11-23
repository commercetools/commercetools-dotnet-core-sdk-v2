using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Messages
{

    public partial class ByProjectKeyMessagesGet : ApiMethod<ByProjectKeyMessagesGet>, IApiMethod<ByProjectKeyMessagesGet, commercetools.Sdk.Api.Models.Messages.IMessagePagedQueryResponse>, commercetools.Sdk.Api.Models.IPagedQueryResourceRequest<ByProjectKeyMessagesGet, commercetools.Sdk.Api.Models.Messages.IMessagePagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyMessagesGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyMessagesGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyMessagesGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeyMessagesGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMessagesGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyMessagesGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyMessagesGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/messages";
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

        public ByProjectKeyMessagesGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyMessagesGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyMessagesGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyMessagesGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyMessagesGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyMessagesGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyMessagesGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.Messages.IMessagePagedQueryResponse> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Messages.IMessagePagedQueryResponse>(requestMessage, cancellationToken);
        }

    }
}
