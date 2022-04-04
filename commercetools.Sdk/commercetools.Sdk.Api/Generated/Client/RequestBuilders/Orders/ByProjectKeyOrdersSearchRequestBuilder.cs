using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Orders
{

    public class ByProjectKeyOrdersSearchRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyOrdersSearchRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyOrdersSearchPost Post(commercetools.Sdk.Api.Models.Orders.IOrderSearchRequest orderSearchRequest)
        {
            return new ByProjectKeyOrdersSearchPost(ApiHttpClient, SerializerService, ProjectKey, orderSearchRequest);
        }

        public ByProjectKeyOrdersSearchHead Head()
        {
            return new ByProjectKeyOrdersSearchHead(ApiHttpClient, ProjectKey);
        }

    }
}
