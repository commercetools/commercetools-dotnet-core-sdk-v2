using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductSelections
{

    public partial class ByProjectKeyProductSelectionsKeyByKeyProductsGet : ApiMethod<ByProjectKeyProductSelectionsKeyByKeyProductsGet>, IApiMethod<ByProjectKeyProductSelectionsKeyByKeyProductsGet, commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionProductPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyProductSelectionsKeyByKeyProductsGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyProductSelectionsKeyByKeyProductsGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyProductSelectionsKeyByKeyProductsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyProductSelectionsKeyByKeyProductsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyProductSelectionsKeyByKeyProductsGet>
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

        public List<string> GetSort()
        {
            return this.GetQueryParam("sort");
        }

        public ByProjectKeyProductSelectionsKeyByKeyProductsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyProductSelectionsKeyByKeyProductsGet WithLimit(long limit)
        {
            return this.AddQueryParam("limit", limit.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyProductSelectionsKeyByKeyProductsGet WithOffset(long offset)
        {
            return this.AddQueryParam("offset", offset.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyProductSelectionsKeyByKeyProductsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyProductSelectionsKeyByKeyProductsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }


        public async Task<commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionProductPagedQueryResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionProductPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionProductPagedQueryResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.ProductSelections.IProductSelectionProductPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
