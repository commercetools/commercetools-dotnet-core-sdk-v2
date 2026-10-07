using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.RecurringPayment
{

    public partial class ByProjectKeyRecurringPaymentJobsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyRecurringPaymentJobsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyRecurringPaymentJobsKeyByKeyGet Get()
        {
            return new ByProjectKeyRecurringPaymentJobsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyRecurringPaymentJobsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyRecurringPaymentJobsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
