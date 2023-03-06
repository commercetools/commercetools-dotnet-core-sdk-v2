using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenByPasswordTokenRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string PasswordToken { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenByPasswordTokenRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string passwordToken)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.PasswordToken = passwordToken;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenByPasswordTokenGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCustomersPasswordTokenByPasswordTokenGet(ApiHttpClient, ProjectKey, StoreKey, PasswordToken);
        }

    }
}
