using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductDrafts
{

    public partial class ByProjectKeyProductDraftsImportContainersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductDraftsImportContainersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyProductDraftsImportContainersByImportContainerKeyRequestBuilder WithImportContainerKeyValue(string importContainerKey)
        {
            return new ByProjectKeyProductDraftsImportContainersByImportContainerKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, importContainerKey);
        }
    }
}
