using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Carts
{

    public partial class ByProjectKeyCartsCustomerIdByCustomerIdRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string CustomerId { get; }

        public ByProjectKeyCartsCustomerIdByCustomerIdRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string customerId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.CustomerId = customerId;
        }

        public ByProjectKeyCartsCustomerIdByCustomerIdGet Get()
        {
            return new ByProjectKeyCartsCustomerIdByCustomerIdGet(ApiHttpClient, ProjectKey, CustomerId);
        }

    }
}
