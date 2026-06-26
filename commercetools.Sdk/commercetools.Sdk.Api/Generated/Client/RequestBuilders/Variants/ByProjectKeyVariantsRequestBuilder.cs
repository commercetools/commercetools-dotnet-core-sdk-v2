using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Variants
{

    public partial class ByProjectKeyVariantsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyVariantsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyVariantsGet Get()
        {
            return new ByProjectKeyVariantsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyVariantsPost Post(commercetools.Sdk.Api.Models.Variants.IVariantDraft variantDraft)
        {
            return new ByProjectKeyVariantsPost(ApiHttpClient, SerializerService, ProjectKey, variantDraft);
        }

        public ByProjectKeyVariantsHead Head()
        {
            return new ByProjectKeyVariantsHead(ApiHttpClient, ProjectKey);
        }


        public ByProjectKeyVariantsBulkRequestBuilder Bulk()
        {
            return new ByProjectKeyVariantsBulkRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyVariantsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyVariantsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyVariantsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyVariantsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
