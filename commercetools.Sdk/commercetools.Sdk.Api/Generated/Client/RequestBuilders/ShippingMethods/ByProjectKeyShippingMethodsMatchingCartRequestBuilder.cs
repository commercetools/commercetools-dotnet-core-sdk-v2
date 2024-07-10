using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.ShippingMethods
{

    public partial class ByProjectKeyShippingMethodsMatchingCartRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyShippingMethodsMatchingCartRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyShippingMethodsMatchingCartGet Get()
        {
            return new ByProjectKeyShippingMethodsMatchingCartGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyShippingMethodsMatchingCartHead Head()
        {
            return new ByProjectKeyShippingMethodsMatchingCartHead(ApiHttpClient, ProjectKey);
        }

    }
}
