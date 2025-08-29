using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.PaymentIntents
{

    public partial class ByProjectKeyPaymentIntentsByPaymentIdRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string PaymentId { get; }

        public ByProjectKeyPaymentIntentsByPaymentIdRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string paymentId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.PaymentId = paymentId;
        }

        public ByProjectKeyPaymentIntentsByPaymentIdPost Post(commercetools.Sdk.CheckoutApi.Models.PaymentIntents.IPaymentIntent paymentIntent)
        {
            return new ByProjectKeyPaymentIntentsByPaymentIdPost(ApiHttpClient, SerializerService, ProjectKey, PaymentId, paymentIntent);
        }

    }
}
