using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ProductID { get; }

        public ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string productId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ProductID = productId;
        }



        public ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringRequestBuilder ProductTailoring()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductsByProductIDProductTailoringRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ProductID);
        }
    }
}
