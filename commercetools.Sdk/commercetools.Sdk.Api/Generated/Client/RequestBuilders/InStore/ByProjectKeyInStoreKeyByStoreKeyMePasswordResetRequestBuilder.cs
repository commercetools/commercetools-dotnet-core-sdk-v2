using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyMePasswordResetRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyMePasswordResetRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyMePasswordResetPost Post(commercetools.Sdk.Api.Models.Customers.IMyCustomerResetPassword myCustomerResetPassword)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMePasswordResetPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, myCustomerResetPassword);
        }

    }
}
