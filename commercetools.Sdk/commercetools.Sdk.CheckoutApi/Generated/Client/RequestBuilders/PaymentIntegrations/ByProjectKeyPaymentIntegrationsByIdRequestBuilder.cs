using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.PaymentIntegrations
{

    public partial class ByProjectKeyPaymentIntegrationsByIdRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Id { get; }

        public ByProjectKeyPaymentIntegrationsByIdRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Id = id;
        }

        public ByProjectKeyPaymentIntegrationsByIdGet Get()
        {
            return new ByProjectKeyPaymentIntegrationsByIdGet(ApiHttpClient, ProjectKey, Id);
        }

        public ByProjectKeyPaymentIntegrationsByIdHead Head()
        {
            return new ByProjectKeyPaymentIntegrationsByIdHead(ApiHttpClient, ProjectKey, Id);
        }

        public ByProjectKeyPaymentIntegrationsByIdPost Post(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.IPaymentIntegrationUpdateActions paymentIntegrationUpdateActions)
        {
            return new ByProjectKeyPaymentIntegrationsByIdPost(ApiHttpClient, SerializerService, ProjectKey, Id, paymentIntegrationUpdateActions);
        }

        public ByProjectKeyPaymentIntegrationsByIdDelete Delete(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.IPaymentIntegration paymentIntegration)
        {
            return new ByProjectKeyPaymentIntegrationsByIdDelete(ApiHttpClient, ProjectKey, Id, paymentIntegration);
        }

    }
}
