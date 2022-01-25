using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.InStore
{

    public class ByProjectKeyInStoreKeyByStoreKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }



        public ByProjectKeyInStoreKeyByStoreKeyCartsRequestBuilder Carts()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyOrdersRequestBuilder Orders()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyOrdersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeRequestBuilder Me()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersRequestBuilder Customers()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyLoginRequestBuilder Login()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyLoginRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyShippingMethodsRequestBuilder ShippingMethods()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyShippingMethodsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyShoppingListsRequestBuilder ShoppingLists()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyShoppingListsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductProjectionsRequestBuilder ProductProjections()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductProjectionsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsRequestBuilder ProductSelectionAssignments()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyProductSelectionAssignmentsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }
    }
}
