using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Categories
{

    public partial class ByProjectKeyCategoriesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCategoriesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyCategoriesGet Get()
        {
            return new ByProjectKeyCategoriesGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyCategoriesHead Head()
        {
            return new ByProjectKeyCategoriesHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyCategoriesPost Post(commercetools.Sdk.Api.Models.Categories.ICategoryDraft categoryDraft)
        {
            return new ByProjectKeyCategoriesPost(ApiHttpClient, SerializerService, ProjectKey, categoryDraft);
        }


        public ByProjectKeyCategoriesKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyCategoriesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyCategoriesByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyCategoriesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
