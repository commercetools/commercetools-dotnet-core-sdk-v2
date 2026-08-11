using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.VariantProjections
{

    public partial class ByProjectKeyVariantProjectionsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyVariantProjectionsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyVariantProjectionsByIDGet Get()
        {
            return new ByProjectKeyVariantProjectionsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyVariantProjectionsByIDHead Head()
        {
            return new ByProjectKeyVariantProjectionsByIDHead(ApiHttpClient, ProjectKey, ID);
        }

    }
}
