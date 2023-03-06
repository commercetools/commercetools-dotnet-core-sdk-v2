using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenPost Post(commercetools.Sdk.Api.Models.Customers.ICustomerCreatePasswordResetToken customerCreatePasswordResetToken)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, customerCreatePasswordResetToken);
        }

    }
}
