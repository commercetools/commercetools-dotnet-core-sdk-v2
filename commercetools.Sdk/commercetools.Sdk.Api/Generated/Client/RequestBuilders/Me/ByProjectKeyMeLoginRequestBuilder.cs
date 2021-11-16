using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Me
{

    public class ByProjectKeyMeLoginRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMeLoginRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMeLoginPost Post(commercetools.Api.Models.Customers.ICustomerSignin customerSignin)
        {
            return new ByProjectKeyMeLoginPost(ApiHttpClient, SerializerService, ProjectKey, customerSignin);
        }

    }
}
