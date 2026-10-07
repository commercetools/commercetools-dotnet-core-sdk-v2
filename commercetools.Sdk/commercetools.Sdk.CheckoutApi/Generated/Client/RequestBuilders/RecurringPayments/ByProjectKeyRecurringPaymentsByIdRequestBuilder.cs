using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.RecurringPayments
{

    public partial class ByProjectKeyRecurringPaymentsByIdRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Id { get; }

        public ByProjectKeyRecurringPaymentsByIdRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Id = id;
        }

        public ByProjectKeyRecurringPaymentsByIdGet Get()
        {
            return new ByProjectKeyRecurringPaymentsByIdGet(ApiHttpClient, ProjectKey, Id);
        }

        public ByProjectKeyRecurringPaymentsByIdPost Post(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.IRecurringPaymentUpdateActions recurringPaymentUpdateActions)
        {
            return new ByProjectKeyRecurringPaymentsByIdPost(ApiHttpClient, SerializerService, ProjectKey, Id, recurringPaymentUpdateActions);
        }

        public ByProjectKeyRecurringPaymentsByIdDelete Delete()
        {
            return new ByProjectKeyRecurringPaymentsByIdDelete(ApiHttpClient, ProjectKey, Id);
        }

    }
}
