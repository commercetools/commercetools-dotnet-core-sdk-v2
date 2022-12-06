using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Subscriptions
{

    public partial class ByProjectKeySubscriptionsByIDDelete : ApiMethod<ByProjectKeySubscriptionsByIDDelete>, IApiMethod<ByProjectKeySubscriptionsByIDDelete, commercetools.Sdk.Api.Models.Subscriptions.ISubscription>, commercetools.Sdk.Api.Client.IVersionedTrait<ByProjectKeySubscriptionsByIDDelete>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeySubscriptionsByIDDelete>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeySubscriptionsByIDDelete>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeySubscriptionsByIDDelete>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeySubscriptionsByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeySubscriptionsByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/subscriptions/{ID}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeySubscriptionsByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }

        public ByProjectKeySubscriptionsByIDDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Subscriptions.ISubscription> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Subscriptions.ISubscription>(requestMessage, cancellationToken);
        }

    }
}
