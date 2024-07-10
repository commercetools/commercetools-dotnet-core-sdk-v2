using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Subscriptions
{

    public partial class ByProjectKeySubscriptionsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeySubscriptionsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeySubscriptionsGet Get()
        {
            return new ByProjectKeySubscriptionsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeySubscriptionsHead Head()
        {
            return new ByProjectKeySubscriptionsHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeySubscriptionsPost Post(commercetools.Sdk.Api.Models.Subscriptions.ISubscriptionDraft subscriptionDraft)
        {
            return new ByProjectKeySubscriptionsPost(ApiHttpClient, SerializerService, ProjectKey, subscriptionDraft);
        }


        public ByProjectKeySubscriptionsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeySubscriptionsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeySubscriptionsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeySubscriptionsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
