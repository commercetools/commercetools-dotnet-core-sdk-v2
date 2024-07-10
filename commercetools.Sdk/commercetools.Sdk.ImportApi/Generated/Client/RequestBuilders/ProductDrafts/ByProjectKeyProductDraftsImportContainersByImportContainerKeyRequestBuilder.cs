using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductDrafts
{

    public partial class ByProjectKeyProductDraftsImportContainersByImportContainerKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }

        public ByProjectKeyProductDraftsImportContainersByImportContainerKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
        }

        public ByProjectKeyProductDraftsImportContainersByImportContainerKeyPost Post(commercetools.Sdk.ImportApi.Models.Importrequests.IProductDraftImportRequest productDraftImportRequest)
        {
            return new ByProjectKeyProductDraftsImportContainersByImportContainerKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportContainerKey, productDraftImportRequest);
        }

    }
}
