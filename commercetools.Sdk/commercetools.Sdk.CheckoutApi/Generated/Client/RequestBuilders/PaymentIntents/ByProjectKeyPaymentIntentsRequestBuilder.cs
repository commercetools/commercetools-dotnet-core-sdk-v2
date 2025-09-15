using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.PaymentIntents
{

    public partial class ByProjectKeyPaymentIntentsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyPaymentIntentsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyPaymentIntentsByPaymentIdRequestBuilder WithPaymentId(string paymentId)
        {
            return new ByProjectKeyPaymentIntentsByPaymentIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, paymentId);
        }
    }
}
