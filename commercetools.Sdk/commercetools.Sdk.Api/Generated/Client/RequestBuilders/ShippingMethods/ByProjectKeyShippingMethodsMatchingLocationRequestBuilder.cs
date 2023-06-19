using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ShippingMethods
{

    public partial class ByProjectKeyShippingMethodsMatchingLocationRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyShippingMethodsMatchingLocationRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyShippingMethodsMatchingLocationGet Get()
        {
            return new ByProjectKeyShippingMethodsMatchingLocationGet(ApiHttpClient, ProjectKey);
        }

    }
}
