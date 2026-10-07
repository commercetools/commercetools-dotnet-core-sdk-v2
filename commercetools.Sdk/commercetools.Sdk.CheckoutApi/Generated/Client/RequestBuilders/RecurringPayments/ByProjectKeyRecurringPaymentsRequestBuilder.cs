using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.RecurringPayments
{

    public partial class ByProjectKeyRecurringPaymentsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyRecurringPaymentsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyRecurringPaymentsGet Get()
        {
            return new ByProjectKeyRecurringPaymentsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyRecurringPaymentsPost Post(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.IRecurringPaymentDraft recurringPaymentDraft)
        {
            return new ByProjectKeyRecurringPaymentsPost(ApiHttpClient, SerializerService, ProjectKey, recurringPaymentDraft);
        }


        public ByProjectKeyRecurringPaymentsByIdRequestBuilder WithId(string id)
        {
            return new ByProjectKeyRecurringPaymentsByIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, id);
        }

        public ByProjectKeyRecurringPaymentsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyRecurringPaymentsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }
    }
}
