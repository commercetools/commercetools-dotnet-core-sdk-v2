using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.RecurringOrders
{

    public partial class ByProjectKeyRecurringOrdersKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyRecurringOrdersKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyRecurringOrdersKeyByKeyGet Get()
        {
            return new ByProjectKeyRecurringOrdersKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyRecurringOrdersKeyByKeyHead Head()
        {
            return new ByProjectKeyRecurringOrdersKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyRecurringOrdersKeyByKeyPost Post(commercetools.Sdk.Api.Models.RecurringOrders.IRecurringOrderUpdate recurringOrderUpdate)
        {
            return new ByProjectKeyRecurringOrdersKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, recurringOrderUpdate);
        }

    }
}
