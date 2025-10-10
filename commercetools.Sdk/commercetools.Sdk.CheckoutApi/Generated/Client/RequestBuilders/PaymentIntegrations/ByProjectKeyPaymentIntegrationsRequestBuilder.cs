using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.PaymentIntegrations
{

    public partial class ByProjectKeyPaymentIntegrationsRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyPaymentIntegrationsRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyPaymentIntegrationsGet Get()
        {
            return new ByProjectKeyPaymentIntegrationsGet(ApiHttpClient, ProjectKey);
        }

        public ByProjectKeyPaymentIntegrationsPost Post(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrationDrafts.IPaymentIntegrationDraft paymentIntegrationDraft)
        {
            return new ByProjectKeyPaymentIntegrationsPost(ApiHttpClient, SerializerService, ProjectKey, paymentIntegrationDraft);
        }


        public ByProjectKeyPaymentIntegrationsByIdRequestBuilder WithId(string id)
        {
            return new ByProjectKeyPaymentIntegrationsByIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, id);
        }

        public ByProjectKeyPaymentIntegrationsKeyByKeyRequestBuilder WithKey(string key)
        {
            return new ByProjectKeyPaymentIntegrationsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
        }
    }
}
