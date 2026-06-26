using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.VariantProjections
{

    public partial class ByProjectKeyVariantProjectionsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyVariantProjectionsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyVariantProjectionsKeyByKeyGet Get()
        {
            return new ByProjectKeyVariantProjectionsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyVariantProjectionsKeyByKeyHead Head()
        {
            return new ByProjectKeyVariantProjectionsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

    }
}
