using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCartDiscountsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartDiscountsGet(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartDiscountsHead(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsPost Post(commercetools.Sdk.Api.Models.CartDiscounts.ICartDiscountDraft cartDiscountDraft)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartDiscountsPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, cartDiscountDraft);
        }


        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartDiscountsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartDiscountsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartDiscountsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID);
        }
    }
}
