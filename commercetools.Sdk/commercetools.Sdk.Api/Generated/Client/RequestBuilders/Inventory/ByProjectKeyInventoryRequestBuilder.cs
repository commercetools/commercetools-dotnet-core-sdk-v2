using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Inventory
{

    public class ByProjectKeyInventoryRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyInventoryRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyInventoryGet Get()
        {
            return new ByProjectKeyInventoryGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyInventoryPost Post(commercetools.Api.Models.Inventories.IInventoryEntryDraft inventoryEntryDraft)
        {
            return new ByProjectKeyInventoryPost(ApiHttpClient, SerializerService, ProjectKey, inventoryEntryDraft);
        }


        public ByProjectKeyInventoryByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyInventoryByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }

        public ByProjectKeyInventoryKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyInventoryKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }
    }
}
