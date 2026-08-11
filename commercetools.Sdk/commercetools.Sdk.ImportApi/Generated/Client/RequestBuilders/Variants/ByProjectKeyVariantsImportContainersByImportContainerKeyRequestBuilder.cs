using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Variants
{

    public partial class ByProjectKeyVariantsImportContainersByImportContainerKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }

        public ByProjectKeyVariantsImportContainersByImportContainerKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
        }

        public ByProjectKeyVariantsImportContainersByImportContainerKeyPost Post(commercetools.Sdk.ImportApi.Models.Importrequests.IVariantImportRequest variantImportRequest)
        {
            return new ByProjectKeyVariantsImportContainersByImportContainerKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportContainerKey, variantImportRequest);
        }

    }
}
