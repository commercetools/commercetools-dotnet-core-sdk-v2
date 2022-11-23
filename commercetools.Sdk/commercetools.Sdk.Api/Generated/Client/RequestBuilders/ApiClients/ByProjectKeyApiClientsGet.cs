using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ApiClients
{

    public partial class ByProjectKeyApiClientsGet : ApiMethod<ByProjectKeyApiClientsGet>, IApiMethod<ByProjectKeyApiClientsGet, commercetools.Sdk.Api.Models.ApiClients.IApiClientPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyApiClientsGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyApiClientsGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyApiClientsGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeyApiClientsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyApiClientsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyApiClientsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyApiClientsGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/api-clients";
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

        public ByProjectKeyApiClientsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyApiClientsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyApiClientsGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyApiClientsGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyApiClientsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyApiClientsGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyApiClientsGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.ApiClients.IApiClientPagedQueryResponse> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ApiClients.IApiClientPagedQueryResponse>(requestMessage, cancellationToken);
        }

    }
}
