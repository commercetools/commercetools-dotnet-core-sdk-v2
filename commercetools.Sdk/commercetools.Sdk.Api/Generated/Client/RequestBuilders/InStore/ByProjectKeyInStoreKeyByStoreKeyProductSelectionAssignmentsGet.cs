using System.Globalization;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsGet : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsGet>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsGet, commercetools.Sdk.Api.Models.ProductSelections.IProductsInStorePagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string StoreKey { get; }


        public ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsGet(IClient apiHttpClient, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/product-selection-assignments";
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

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public List<string> GetWhere()
        {
            return this.GetQueryParam("where");
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsGet WithLimit(long limit)
        {
            return this.AddQueryParam("limit", limit.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsGet WithOffset(long offset)
        {
            return this.AddQueryParam("offset", offset.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.ProductSelections.IProductsInStorePagedQueryResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ProductSelections.IProductsInStorePagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.ProductSelections.IProductsInStorePagedQueryResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.ProductSelections.IProductsInStorePagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
