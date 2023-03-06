using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordPost Post(commercetools.Sdk.Api.Models.Customers.ICustomerChangePassword customerChangePassword)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, customerChangePassword);
        }

    }
}
