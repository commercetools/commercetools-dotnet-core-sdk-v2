using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.Customers
{

    public partial class ByProjectKeyCustomersImportContainersByImportContainerKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }

        public ByProjectKeyCustomersImportContainersByImportContainerKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string importContainerKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
        }

        public ByProjectKeyCustomersImportContainersByImportContainerKeyPost Post(commercetools.Sdk.ImportApi.Models.Importrequests.ICustomerImportRequest customerImportRequest)
        {
            return new ByProjectKeyCustomersImportContainersByImportContainerKeyPost(ApiHttpClient, SerializerService, ProjectKey, ImportContainerKey, customerImportRequest);
        }

    }
}
