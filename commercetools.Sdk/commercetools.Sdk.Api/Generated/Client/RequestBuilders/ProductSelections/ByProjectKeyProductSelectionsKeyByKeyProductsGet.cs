using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductSelections
{

    public partial class ByProjectKeyProductSelectionsKeyByKeyProductsGet : ApiMethod<ByProjectKeyProductSelectionsKeyByKeyProductsGet>, IApiMethod<ByProjectKeyProductSelectionsKeyByKeyProductsGet, commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionProductPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyProductSelectionsKeyByKeyProductsGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyProductSelectionsKeyByKeyProductsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductSelectionsKeyByKeyProductsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyProductSelectionsKeyByKeyProductsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyProductSelectionsKeyByKeyProductsGet(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/product-selections/key={Key}/products";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
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

        public ByProjectKeyProductSelectionsKeyByKeyProductsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyProductSelectionsKeyByKeyProductsGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyProductSelectionsKeyByKeyProductsGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyProductSelectionsKeyByKeyProductsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }


        public async Task<commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionProductPagedQueryResponse> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionProductPagedQueryResponse>(requestMessage, cancellationToken);
        }

    }
}
