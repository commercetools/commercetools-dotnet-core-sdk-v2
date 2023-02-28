using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Client.RequestBuilders.Payments
{

    public partial class ByProjectKeyPaymentsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyPaymentsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyPaymentsGet Get()
        {
            return new ByProjectKeyPaymentsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyPaymentsPost Post(commercetools.Sdk.Api.Models.Payments.IPaymentDraft paymentDraft)
        {
            return new ByProjectKeyPaymentsPost(ApiHttpClient, SerializerService, ProjectKey, paymentDraft);
        }


        public ByProjectKeyPaymentsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyPaymentsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }

        public ByProjectKeyPaymentsByIDRequestBuilder WithId(string ID)
        {
            return new ByProjectKeyPaymentsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
        }
    }
}
