using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ProductKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string productKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ProductKey = productKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringGet(ApiHttpClient, ProjectKey, StoreKey, ProductKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringPost Post(commercetools.Sdk.Api.Models.Carts.IProductTailoringUpdate productTailoringUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ProductKey, productTailoringUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringDelete(ApiHttpClient, ProjectKey, StoreKey, ProductKey);
        }


        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringImagesRequestBuilder Images()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringImagesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ProductKey);
        }
    }
}
