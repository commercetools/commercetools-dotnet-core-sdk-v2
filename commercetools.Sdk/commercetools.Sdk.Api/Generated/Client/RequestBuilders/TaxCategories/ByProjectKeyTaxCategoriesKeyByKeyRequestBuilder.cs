using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.TaxCategories
{

    public partial class ByProjectKeyTaxCategoriesKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyTaxCategoriesKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyTaxCategoriesKeyByKeyGet Get()
        {
            return new ByProjectKeyTaxCategoriesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyTaxCategoriesKeyByKeyHead Head()
        {
            return new ByProjectKeyTaxCategoriesKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyTaxCategoriesKeyByKeyPost Post(commercetools.Sdk.Api.Models.TaxCategories.ITaxCategoryUpdate taxCategoryUpdate)
        {
            return new ByProjectKeyTaxCategoriesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, taxCategoryUpdate);
        }

        public ByProjectKeyTaxCategoriesKeyByKeyDelete Delete()
        {
            return new ByProjectKeyTaxCategoriesKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
