using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Extensions
{

    public partial class ByProjectKeyExtensionsByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyExtensionsByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyExtensionsByIDGet Get()
        {
            return new ByProjectKeyExtensionsByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyExtensionsByIDHead Head()
        {
            return new ByProjectKeyExtensionsByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyExtensionsByIDPost Post(commercetools.Sdk.Api.Models.Extensions.IExtensionUpdate extensionUpdate)
        {
            return new ByProjectKeyExtensionsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, extensionUpdate);
        }

        public ByProjectKeyExtensionsByIDDelete Delete()
        {
            return new ByProjectKeyExtensionsByIDDelete(ApiHttpClient, ProjectKey, ID);
        }

    }
}
