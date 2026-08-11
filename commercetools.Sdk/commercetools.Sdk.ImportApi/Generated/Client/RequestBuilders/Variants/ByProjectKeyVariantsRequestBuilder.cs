using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Variants
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



        public ByProjectKeyVariantsImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyVariantsImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
