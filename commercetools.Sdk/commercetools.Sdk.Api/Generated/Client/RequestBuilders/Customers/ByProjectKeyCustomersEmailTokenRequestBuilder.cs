using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Customers
{

    public class ByProjectKeyCustomersEmailTokenRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCustomersEmailTokenRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyCustomersEmailTokenPost Post(commercetools.Sdk.Api.Models.Customers.ICustomerCreateEmailToken customerCreateEmailToken)
        {
            return new ByProjectKeyCustomersEmailTokenPost(ApiHttpClient, SerializerService, ProjectKey, customerCreateEmailToken);
        }

    }
}
