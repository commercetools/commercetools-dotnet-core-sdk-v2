using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public class ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenPost Post(commercetools.Sdk.Api.Models.Customers.ICustomerCreateEmailToken customerCreateEmailToken)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersEmailTokenPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, customerCreateEmailToken);
        }

    }
}
