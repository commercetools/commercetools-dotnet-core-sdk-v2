using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Variants
{

    public partial class ByProjectKeyVariantsBulkRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyVariantsBulkRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyVariantsBulkPost Post(commercetools.Sdk.Api.Models.Variants.IVariantBulkUpdate variantBulkUpdate)
        {
            return new ByProjectKeyVariantsBulkPost(ApiHttpClient, SerializerService, ProjectKey, variantBulkUpdate);
        }

    }
}
