using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Variants
{

    public partial class ByProjectKeyVariantsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyVariantsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyVariantsKeyByKeyGet Get()
        {
            return new ByProjectKeyVariantsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyVariantsKeyByKeyHead Head()
        {
            return new ByProjectKeyVariantsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyVariantsKeyByKeyPost Post(commercetools.Sdk.Api.Models.Variants.IVariantUpdate variantUpdate)
        {
            return new ByProjectKeyVariantsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, variantUpdate);
        }

        public ByProjectKeyVariantsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyVariantsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
