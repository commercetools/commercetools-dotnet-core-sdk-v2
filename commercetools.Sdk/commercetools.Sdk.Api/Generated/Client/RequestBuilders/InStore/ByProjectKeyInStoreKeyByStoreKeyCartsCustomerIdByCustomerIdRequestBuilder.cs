using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string CustomerId { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string customerId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.CustomerId = customerId;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartsCustomerIdByCustomerIdGet(ApiHttpClient, ProjectKey, StoreKey, CustomerId);
        }

    }
}
