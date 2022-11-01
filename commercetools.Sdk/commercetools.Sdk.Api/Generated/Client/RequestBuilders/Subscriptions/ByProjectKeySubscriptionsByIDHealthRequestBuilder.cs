using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Subscriptions
{

    public class ByProjectKeySubscriptionsByIDHealthRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeySubscriptionsByIDHealthRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeySubscriptionsByIDHealthGet Get()
        {
            return new ByProjectKeySubscriptionsByIDHealthGet(ApiHttpClient, ProjectKey, ID);
        }

    }
}
