using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.RecurringPayment
{

    public partial class ByProjectKeyRecurringPaymentJobsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyRecurringPaymentJobsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyRecurringPaymentJobsGet Get()
        {
            return new ByProjectKeyRecurringPaymentJobsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyRecurringPaymentJobsPost Post(commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.IRecurringPaymentJobDraft recurringPaymentJobDraft)
        {
            return new ByProjectKeyRecurringPaymentJobsPost(ApiHttpClient, SerializerService, ProjectKey, recurringPaymentJobDraft);
        }


        public ByProjectKeyRecurringPaymentJobsByIdRequestBuilder WithId(string id)
        {
            return new ByProjectKeyRecurringPaymentJobsByIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, id);
        }

        public ByProjectKeyRecurringPaymentJobsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyRecurringPaymentJobsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }
    }
}
