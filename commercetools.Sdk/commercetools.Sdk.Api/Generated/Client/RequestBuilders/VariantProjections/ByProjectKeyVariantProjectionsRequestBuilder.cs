using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.VariantProjections
{

    public partial class ByProjectKeyVariantProjectionsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyVariantProjectionsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyVariantProjectionsGet Get()
        {
            return new ByProjectKeyVariantProjectionsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyVariantProjectionsHead Head()
        {
            return new ByProjectKeyVariantProjectionsHead(ApiHttpClient, ProjectKey);
        }


        public ByProjectKeyVariantProjectionsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyVariantProjectionsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyVariantProjectionsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyVariantProjectionsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
