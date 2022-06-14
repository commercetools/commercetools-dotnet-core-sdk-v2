using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public class ByProjectKeyInStoreKeyByStoreKeyMeEmailConfirmRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyMeEmailConfirmRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyMeEmailConfirmPost Post(commercetools.Sdk.Api.Models.Customers.ICustomerEmailVerify customerEmailVerify)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyMeEmailConfirmPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, customerEmailVerify);
        }

    }
}
