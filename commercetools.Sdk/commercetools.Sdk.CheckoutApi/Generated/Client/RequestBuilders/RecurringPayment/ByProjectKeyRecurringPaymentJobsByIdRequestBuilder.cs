using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.RecurringPayment
{

    public partial class ByProjectKeyRecurringPaymentJobsByIdRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Id { get; }

        public ByProjectKeyRecurringPaymentJobsByIdRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Id = id;
        }

        public ByProjectKeyRecurringPaymentJobsByIdGet Get()
        {
            return new ByProjectKeyRecurringPaymentJobsByIdGet(ApiHttpClient, ProjectKey, Id);
        }

        public ByProjectKeyRecurringPaymentJobsByIdDelete Delete()
        {
            return new ByProjectKeyRecurringPaymentJobsByIdDelete(ApiHttpClient, ProjectKey, Id);
        }

    }
}
