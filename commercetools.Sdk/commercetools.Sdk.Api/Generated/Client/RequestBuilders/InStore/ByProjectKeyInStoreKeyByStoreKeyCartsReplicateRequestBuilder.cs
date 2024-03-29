using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCartsReplicateRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCartsReplicateRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCartsReplicatePost Post(commercetools.Sdk.Api.Models.Carts.IReplicaCartDraft replicaCartDraft)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCartsReplicatePost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, replicaCartDraft);
        }

    }
}
