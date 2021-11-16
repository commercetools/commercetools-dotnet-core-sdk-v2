using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Customers
{

    public class ByProjectKeyCustomersEmailTokenByEmailTokenRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string EmailToken { get; }

        public ByProjectKeyCustomersEmailTokenByEmailTokenRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string emailToken)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.EmailToken = emailToken;
        }

        public ByProjectKeyCustomersEmailTokenByEmailTokenGet Get()
        {
            return new ByProjectKeyCustomersEmailTokenByEmailTokenGet(ApiHttpClient, ProjectKey, EmailToken);
        }

    }
}
