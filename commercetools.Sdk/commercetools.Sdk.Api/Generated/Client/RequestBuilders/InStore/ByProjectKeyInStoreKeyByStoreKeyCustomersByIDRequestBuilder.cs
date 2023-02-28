using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCustomersByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersByIDGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersByIDGet(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersByIDPost Post(commercetools.Sdk.Api.Models.Customers.ICustomerUpdate customerUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersByIDPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID, customerUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersByIDDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersByIDDelete(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

    }
}
