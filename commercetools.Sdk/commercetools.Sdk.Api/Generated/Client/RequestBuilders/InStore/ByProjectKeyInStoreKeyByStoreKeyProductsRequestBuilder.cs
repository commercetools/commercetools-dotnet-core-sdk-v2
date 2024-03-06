using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyProductsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyProductsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }



        public ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDRequestBuilder WithProductId(string productID)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, productID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyRequestBuilder WithProductKey(string productKey)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductsKeyByProductKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, productKey);
        }
    }
}
