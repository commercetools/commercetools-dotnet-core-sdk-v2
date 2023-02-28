using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Customers
{

    public partial class ByProjectKeyCustomersEmailConfirmRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCustomersEmailConfirmRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyCustomersEmailConfirmPost Post(commercetools.Sdk.Api.Models.Customers.ICustomerEmailVerify customerEmailVerify)
        {
            return new ByProjectKeyCustomersEmailConfirmPost(ApiHttpClient, SerializerService, ProjectKey, customerEmailVerify);
        }

    }
}
