using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyAssociatesByAssociateIdRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }

        private string AssociateId { get; }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyAssociatesByAssociateIdRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string key, string associateId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
            this.AssociateId = associateId;
        }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyAssociatesByAssociateIdGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyAssociatesByAssociateIdGet(ApiHttpClient, ProjectKey, StoreKey, Key, AssociateId);
        }

    }
}
