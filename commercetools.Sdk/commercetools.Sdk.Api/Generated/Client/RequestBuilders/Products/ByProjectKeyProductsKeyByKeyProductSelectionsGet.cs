using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Products
{
    public partial class ByProjectKeyProductsKeyByKeyProductSelectionsGet : ApiMethod<ByProjectKeyProductsKeyByKeyProductSelectionsGet>, IApiMethod<ByProjectKeyProductsKeyByKeyProductSelectionsGet, commercetools.Sdk.Api.Models.ProductSelections.IAssignedProductSelectionPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyProductsKeyByKeyProductSelectionsGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyProductsKeyByKeyProductSelectionsGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyProductsKeyByKeyProductSelectionsGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeyProductsKeyByKeyProductSelectionsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductsKeyByKeyProductSelectionsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyProductsKeyByKeyProductSelectionsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyProductsKeyByKeyProductSelectionsGet(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/products/key={Key}/product-selections";
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

        public ByProjectKeyProductsKeyByKeyProductSelectionsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyProductsKeyByKeyProductSelectionsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyProductsKeyByKeyProductSelectionsGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyProductsKeyByKeyProductSelectionsGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyProductsKeyByKeyProductSelectionsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyProductsKeyByKeyProductSelectionsGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyProductsKeyByKeyProductSelectionsGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.ProductSelections.IAssignedProductSelectionPagedQueryResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ProductSelections.IAssignedProductSelectionPagedQueryResponse>(requestMessage);
        }

    }
}
