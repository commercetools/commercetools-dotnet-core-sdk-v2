using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.ImportApi.Client.RequestBuilders.ProductVariant
{

    public partial class ByProjectKeyProductVariantPatchesRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyProductVariantPatchesRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyProductVariantPatchesImportContainersRequestBuilder ImportContainers()
        {
            return new ByProjectKeyProductVariantPatchesImportContainersRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
