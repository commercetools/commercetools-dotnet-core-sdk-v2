using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.BusinessUnits
{

    public partial class ByProjectKeyBusinessUnitsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyBusinessUnitsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyBusinessUnitsImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyBusinessUnitsImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
