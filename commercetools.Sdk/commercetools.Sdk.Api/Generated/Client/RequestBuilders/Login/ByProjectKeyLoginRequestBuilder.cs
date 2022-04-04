using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Login
{

    public class ByProjectKeyLoginRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyLoginRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyLoginPost Post(commercetools.Sdk.Api.Models.Customers.ICustomerSignin customerSignin)
        {
            return new ByProjectKeyLoginPost(ApiHttpClient, SerializerService, ProjectKey, customerSignin);
        }

    }
}
