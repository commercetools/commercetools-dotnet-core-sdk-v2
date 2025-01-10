using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
        }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsGet(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsHead(ApiHttpClient, ProjectKey, StoreKey);
        }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsPost Post(commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitDraft businessUnitDraft)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, businessUnitDraft);
        }


        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, key);
        }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID);
        }
    }
}
