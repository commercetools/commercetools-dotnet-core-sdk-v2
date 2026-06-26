using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ProductProjections
{

    public partial class ByProjectKeyProductProjectionsKeyByKeyVariantAttributesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyProductProjectionsKeyByKeyVariantAttributesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyProductProjectionsKeyByKeyVariantAttributesGet Get()
        {
            return new ByProjectKeyProductProjectionsKeyByKeyVariantAttributesGet(ApiHttpClient, ProjectKey, Key);
        }

    }
}
