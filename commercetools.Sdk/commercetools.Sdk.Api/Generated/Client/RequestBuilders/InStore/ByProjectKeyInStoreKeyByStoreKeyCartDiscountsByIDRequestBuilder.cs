using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCartDiscountsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsByIDGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartDiscountsByIDGet(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsByIDHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartDiscountsByIDHead(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsByIDPost Post(commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscountUpdate cartDiscountUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartDiscountsByIDPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID, cartDiscountUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsByIDDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartDiscountsByIDDelete(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

    }
}
