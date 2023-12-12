using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Stores
{

    public partial class ByProjectKeyStoresKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyStoresKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyStoresKeyByKeyGet Get()
        {
            return new ByProjectKeyStoresKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyStoresKeyByKeyHead Head()
        {
            return new ByProjectKeyStoresKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyStoresKeyByKeyPost Post(commercetools.Sdk.Api.Models.Stores.IStoreUpdate storeUpdate)
        {
            return new ByProjectKeyStoresKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, storeUpdate);
        }

        public ByProjectKeyStoresKeyByKeyDelete Delete()
        {
            return new ByProjectKeyStoresKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
