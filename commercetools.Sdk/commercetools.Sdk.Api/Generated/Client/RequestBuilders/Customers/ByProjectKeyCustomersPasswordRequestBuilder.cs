using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Customers
{

    public partial class ByProjectKeyCustomersPasswordRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCustomersPasswordRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyCustomersPasswordPost Post(commercetools.Sdk.Api.Models.Customers.ICustomerChangePassword customerChangePassword)
        {
            return new ByProjectKeyCustomersPasswordPost(ApiHttpClient, SerializerService, ProjectKey, customerChangePassword);
        }

    }
}
