using System.Globalization;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringDelete : ApiMethod<ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringDelete>, IApiMethod<ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringDelete, commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ProductKey { get; }


        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringDelete(IClient apiHttpClient, string projectKey, string storeKey, string productKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ProductKey = productKey;
            this.RequestUrl = $"/{ProjectKey}/in-store/key={StoreKey}/products/key={ProductKey}/product-tailoring";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.ProductTailorings.IProductTailoring>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
