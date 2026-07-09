using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyDiscountCodesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyDiscountCodesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyDiscountCodesGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyDiscountCodesGet(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyDiscountCodesHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyDiscountCodesHead(ApiHttpClient, ProjectKey, StoreKey);
        }


        public ByProjectKeyInStoreKeyByStoreKeyDiscountCodesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyDiscountCodesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyDiscountCodesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyDiscountCodesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID);
        }
    }
}
