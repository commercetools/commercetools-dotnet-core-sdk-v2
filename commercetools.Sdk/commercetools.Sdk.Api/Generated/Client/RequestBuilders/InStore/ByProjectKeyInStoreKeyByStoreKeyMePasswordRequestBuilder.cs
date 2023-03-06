using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyMePasswordRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyMePasswordRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyMePasswordPost Post(commercetools.Sdk.Api.Models.Customers.IMyCustomerChangePassword myCustomerChangePassword)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMePasswordPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, myCustomerChangePassword);
        }


        public ByProjectKeyInStoreKeyByStoreKeyMePasswordResetRequestBuilder Reset()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMePasswordResetRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey);
        }
    }
}
