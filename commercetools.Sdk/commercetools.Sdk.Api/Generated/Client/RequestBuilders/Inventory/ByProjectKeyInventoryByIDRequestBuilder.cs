using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Inventory
{

    public class ByProjectKeyInventoryByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyInventoryByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyInventoryByIDGet Get()
        {
            return new ByProjectKeyInventoryByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyInventoryByIDPost Post(commercetools.Api.Models.Inventories.IInventoryEntryUpdate inventoryEntryUpdate)
        {
            return new ByProjectKeyInventoryByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, inventoryEntryUpdate);
        }

        public ByProjectKeyInventoryByIDDelete Delete()
        {
            return new ByProjectKeyInventoryByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
