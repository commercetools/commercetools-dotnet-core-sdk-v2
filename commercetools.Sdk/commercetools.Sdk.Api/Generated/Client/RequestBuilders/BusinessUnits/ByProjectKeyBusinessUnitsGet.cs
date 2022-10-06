using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.BusinessUnits
{

    public partial class ByProjectKeyBusinessUnitsGet : ApiMethod<ByProjectKeyBusinessUnitsGet>, IApiMethod<ByProjectKeyBusinessUnitsGet, commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyBusinessUnitsGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyBusinessUnitsGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyBusinessUnitsGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeyBusinessUnitsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyBusinessUnitsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyBusinessUnitsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyBusinessUnitsGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/business-units";
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

        public ByProjectKeyBusinessUnitsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyBusinessUnitsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyBusinessUnitsGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyBusinessUnitsGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyBusinessUnitsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyBusinessUnitsGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyBusinessUnitsGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitPagedQueryResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitPagedQueryResponse>(requestMessage);
        }

    }
}
