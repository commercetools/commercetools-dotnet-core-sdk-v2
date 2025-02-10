using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string Key { get; }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.Key = key;
        }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyGet(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyHead(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyPost Post(commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitUpdate businessUnitUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, Key, businessUnitUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyDelete(ApiHttpClient, ProjectKey, StoreKey, Key);
        }

    }
}
