using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ImportContainers
{

    public partial class ByProjectKeyImportContainersByImportContainerKeyImportSummariesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }

        public ByProjectKeyImportContainersByImportContainerKeyImportSummariesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
        }

        public ByProjectKeyImportContainersByImportContainerKeyImportSummariesGet Get()
        {
            return new ByProjectKeyImportContainersByImportContainerKeyImportSummariesGet(ApiHttpClient, ProjectKey, ImportContainerKey);
        }

    }
}
