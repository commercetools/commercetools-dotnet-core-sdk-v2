using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Subscriptions
{
    public partial class ByProjectKeySubscriptionsByIDPost : ApiMethod<ByProjectKeySubscriptionsByIDPost>, IApiMethod<ByProjectKeySubscriptionsByIDPost, commercetools.Sdk.Api.Models.Subscriptions.ISubscription>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeySubscriptionsByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeySubscriptionsByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeySubscriptionsByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeySubscriptionsByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.Subscriptions.ISubscriptionUpdate SubscriptionUpdate;

        public ByProjectKeySubscriptionsByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.Subscriptions.ISubscriptionUpdate subscriptionUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.SubscriptionUpdate = subscriptionUpdate;
            this.RequestUrl = $"/{ProjectKey}/subscriptions/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeySubscriptionsByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Subscriptions.ISubscription> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Subscriptions.ISubscription>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(SubscriptionUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
