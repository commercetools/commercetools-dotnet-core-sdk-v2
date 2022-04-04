using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Customers
{

    public class ByProjectKeyCustomersPasswordTokenRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCustomersPasswordTokenRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyCustomersPasswordTokenPost Post(commercetools.Sdk.Api.Models.Customers.ICustomerCreatePasswordResetToken customerCreatePasswordResetToken)
        {
            return new ByProjectKeyCustomersPasswordTokenPost(ApiHttpClient, SerializerService, ProjectKey, customerCreatePasswordResetToken);
        }

    }
}
