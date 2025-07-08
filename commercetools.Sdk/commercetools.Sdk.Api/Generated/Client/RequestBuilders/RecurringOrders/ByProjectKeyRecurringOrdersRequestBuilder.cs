using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.RecurringOrders
{

    public partial class ByProjectKeyRecurringOrdersRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyRecurringOrdersRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyRecurringOrdersGet Get()
        {
            return new ByProjectKeyRecurringOrdersGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyRecurringOrdersHead Head()
        {
            return new ByProjectKeyRecurringOrdersHead(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyRecurringOrdersPost Post(commercetools.Sdk.Api.Models.RecurringOrders.IRecurringOrderDraft recurringOrderDraft)
        {
            return new ByProjectKeyRecurringOrdersPost(ApiHttpClient, SerializerService, ProjectKey, recurringOrderDraft);
        }


        public ByProjectKeyRecurringOrdersByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyRecurringOrdersByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }

        public ByProjectKeyRecurringOrdersKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyRecurringOrdersKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }
    }
}
