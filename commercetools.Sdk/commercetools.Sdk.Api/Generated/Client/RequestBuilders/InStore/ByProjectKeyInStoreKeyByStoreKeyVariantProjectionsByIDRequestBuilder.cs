using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDGet(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyVariantProjectionsByIDHead(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

    }
}
