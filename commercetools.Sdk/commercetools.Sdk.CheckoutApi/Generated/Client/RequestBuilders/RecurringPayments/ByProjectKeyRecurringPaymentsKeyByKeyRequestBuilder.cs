using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.RecurringPayments
{

    public partial class ByProjectKeyRecurringPaymentsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyRecurringPaymentsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyRecurringPaymentsKeyByKeyGet Get()
        {
            return new ByProjectKeyRecurringPaymentsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyRecurringPaymentsKeyByKeyPost Post(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.IRecurringPaymentUpdateActions recurringPaymentUpdateActions)
        {
            return new ByProjectKeyRecurringPaymentsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, recurringPaymentUpdateActions);
        }

        public ByProjectKeyRecurringPaymentsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyRecurringPaymentsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
