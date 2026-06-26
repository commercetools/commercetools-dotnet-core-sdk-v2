using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Variants
{

    public partial class ByProjectKeyVariantsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyVariantsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyVariantsByIDGet Get()
        {
            return new ByProjectKeyVariantsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyVariantsByIDHead Head()
        {
            return new ByProjectKeyVariantsByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyVariantsByIDPost Post(commercetools.Sdk.Api.Models.Variants.IVariantUpdate variantUpdate)
        {
            return new ByProjectKeyVariantsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, variantUpdate);
        }

        public ByProjectKeyVariantsByIDDelete Delete()
        {
            return new ByProjectKeyVariantsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
