using commercetools.Base.Client;
using commercetools.Base.Serialization;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.PaymentIntegrations
{

    public partial class ByProjectKeyPaymentIntegrationsKeyByKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        private string Key { get; }

        public ByProjectKeyPaymentIntegrationsKeyByKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Key = key;
        }

        public ByProjectKeyPaymentIntegrationsKeyByKeyGet Get()
        {
            return new ByProjectKeyPaymentIntegrationsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyPaymentIntegrationsKeyByKeyPost Post(commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.IPaymentIntegrationUpdateActions paymentIntegrationUpdateActions)
        {
            return new ByProjectKeyPaymentIntegrationsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, paymentIntegrationUpdateActions);
        }

        public ByProjectKeyPaymentIntegrationsKeyByKeyHead Head()
        {
            return new ByProjectKeyPaymentIntegrationsKeyByKeyHead(ApiHttpClient, ProjectKey, Key);
        }

        public ByProjectKeyPaymentIntegrationsKeyByKeyDelete Delete()
        {
            return new ByProjectKeyPaymentIntegrationsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
        }

    }
}
