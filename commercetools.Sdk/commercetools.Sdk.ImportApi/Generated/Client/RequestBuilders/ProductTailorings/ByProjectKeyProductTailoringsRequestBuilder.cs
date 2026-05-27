using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductTailorings
{

    public partial class ByProjectKeyProductTailoringsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductTailoringsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyProductTailoringsImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyProductTailoringsImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
