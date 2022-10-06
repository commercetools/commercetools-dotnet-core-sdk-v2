using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMeBusinessUnitsGet : ApiMethod<ByProjectKeyMeBusinessUnitsGet>, IApiMethod<ByProjectKeyMeBusinessUnitsGet, commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyMeBusinessUnitsGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyMeBusinessUnitsGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyMeBusinessUnitsGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeyMeBusinessUnitsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyMeBusinessUnitsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyMeBusinessUnitsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyMeBusinessUnitsGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/me/business-units";
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

        public ByProjectKeyMeBusinessUnitsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyMeBusinessUnitsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyMeBusinessUnitsGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyMeBusinessUnitsGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyMeBusinessUnitsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyMeBusinessUnitsGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyMeBusinessUnitsGet WithPredicateVar(string varName, string predicateVar)
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
