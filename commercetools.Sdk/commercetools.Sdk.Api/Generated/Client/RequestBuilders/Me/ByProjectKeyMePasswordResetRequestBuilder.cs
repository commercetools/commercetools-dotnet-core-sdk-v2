using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Me
{

    public partial class ByProjectKeyMePasswordResetRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyMePasswordResetRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyMePasswordResetPost Post(commercetools.Sdk.Api.Models.Customers.IMyCustomerResetPassword myCustomerResetPassword)
        {
            return new ByProjectKeyMePasswordResetPost(ApiHttpClient, SerializerService, ProjectKey, myCustomerResetPassword);
        }

    }
}
