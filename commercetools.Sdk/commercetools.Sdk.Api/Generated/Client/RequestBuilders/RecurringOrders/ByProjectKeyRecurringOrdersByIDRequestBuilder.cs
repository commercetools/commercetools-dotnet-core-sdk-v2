using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.RecurringOrders
{

    public partial class ByProjectKeyRecurringOrdersByIDRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string ID { get; }

        public ByProjectKeyRecurringOrdersByIDRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
        }

        public ByProjectKeyRecurringOrdersByIDGet Get()
        {
            return new ByProjectKeyRecurringOrdersByIDGet(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyRecurringOrdersByIDHead Head()
        {
            return new ByProjectKeyRecurringOrdersByIDHead(ApiHttpClient, ProjectKey, ID);
        }

        public ByProjectKeyRecurringOrdersByIDPost Post(commercetools.Sdk.Api.Models.RecurringOrders.IRecurringOrderUpdate recurringOrderUpdate)
        {
            return new ByProjectKeyRecurringOrdersByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, recurringOrderUpdate);
        }

    }
}
