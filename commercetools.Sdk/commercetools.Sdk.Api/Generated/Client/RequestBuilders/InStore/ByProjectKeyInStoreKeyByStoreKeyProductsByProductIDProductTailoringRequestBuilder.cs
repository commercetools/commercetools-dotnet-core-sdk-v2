using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ProductID { get; }

        public ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string productId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ProductID = productId;
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringGet(ApiHttpClient, ProjectKey, StoreKey, ProductID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringPost Post(commercetools.Sdk.Api.Models.Carts.IProductTailoringUpdate productTailoringUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ProductID, productTailoringUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringDelete(ApiHttpClient, ProjectKey, StoreKey, ProductID);
        }


        public ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringImagesRequestBuilder Images()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringImagesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ProductID);
        }
    }
}
