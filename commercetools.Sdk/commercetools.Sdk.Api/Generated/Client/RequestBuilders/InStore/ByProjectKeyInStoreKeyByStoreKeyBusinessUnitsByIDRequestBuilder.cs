using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
        }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsByIDGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsByIDGet(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsByIDHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsByIDHead(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsByIDPost Post(commercetools.Sdk.Api.Models.BusinessUnits.IBusinessUnitUpdate businessUnitUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsByIDPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID, businessUnitUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsByIDDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyBusinessUnitsByIDDelete(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

    }
}
