using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyShippingMethodsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyShippingMethodsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }



        public ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartRequestBuilder MatchingCart()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyShippingMethodsMatchingCartRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }
    }
}
