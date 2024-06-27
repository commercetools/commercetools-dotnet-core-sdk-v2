using System.IO;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringImagesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ProductKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringImagesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string productKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ProductKey = productKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringImagesPost Post(Stream stream)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyProductTailoringImagesPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ProductKey, stream);
        }

    }
}
