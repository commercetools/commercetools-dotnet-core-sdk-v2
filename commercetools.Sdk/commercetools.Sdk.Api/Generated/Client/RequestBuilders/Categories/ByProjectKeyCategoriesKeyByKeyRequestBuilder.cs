using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Categories
{

    public partial class ByProjectKeyCategoriesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyCategoriesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyCategoriesKeyByKeyGet Get()
        {
            return new ByProjectKeyCategoriesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyCategoriesKeyByKeyPost Post(commercetools.Sdk.Api.Models.Categories.ICategoryUpdate categoryUpdate)
        {
            return new ByProjectKeyCategoriesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, categoryUpdate);
        }

        public ByProjectKeyCategoriesKeyByKeyDelete Delete()
        {
            return new ByProjectKeyCategoriesKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
