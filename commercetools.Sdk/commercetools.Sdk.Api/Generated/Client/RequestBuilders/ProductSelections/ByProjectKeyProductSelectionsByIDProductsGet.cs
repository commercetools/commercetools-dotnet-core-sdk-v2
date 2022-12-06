using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductSelections
{

    public partial class ByProjectKeyProductSelectionsByIDProductsGet : ApiMethod<ByProjectKeyProductSelectionsByIDProductsGet>, IApiMethod<ByProjectKeyProductSelectionsByIDProductsGet, commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionProductPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyProductSelectionsByIDProductsGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyProductSelectionsByIDProductsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductSelectionsByIDProductsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyProductSelectionsByIDProductsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyProductSelectionsByIDProductsGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/product-selections/{ID}/products";
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

        public ByProjectKeyProductSelectionsByIDProductsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyProductSelectionsByIDProductsGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyProductSelectionsByIDProductsGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyProductSelectionsByIDProductsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }


        public async Task<commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionProductPagedQueryResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionProductPagedQueryResponse>(requestMessage, cancellationToken);
        }

    }
}
