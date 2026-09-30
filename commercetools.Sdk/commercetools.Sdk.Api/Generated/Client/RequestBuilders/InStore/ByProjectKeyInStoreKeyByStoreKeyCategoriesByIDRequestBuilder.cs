using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.InStore
{

    public partial class ByProjectKeyInStoreKeyByStoreKeyCategoriesByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string StoreKey { get; }

        private string ID { get; }

        public ByProjectKeyInStoreKeyByStoreKeyCategoriesByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string storeKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.StoreKey = storeKey;
            this.ID = id;
        }

        public ByProjectKeyInStoreKeyByStoreKeyCategoriesByIDGet Get()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCategoriesByIDGet(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCategoriesByIDHead Head()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCategoriesByIDHead(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCategoriesByIDPost Post(commercetools.Sdk.Api.Models.Categories.ICategoryUpdate categoryUpdate)
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCategoriesByIDPost(ApiHttpClient, SerializerService, ProjectKey, StoreKey, ID, categoryUpdate);
        }

        public ByProjectKeyInStoreKeyByStoreKeyCategoriesByIDDelete Delete()
        {
            return new ByProjectKeyInStoreKeyByStoreKeyCategoriesByIDDelete(ApiHttpClient, ProjectKey, StoreKey, ID);
        }

    }
}
