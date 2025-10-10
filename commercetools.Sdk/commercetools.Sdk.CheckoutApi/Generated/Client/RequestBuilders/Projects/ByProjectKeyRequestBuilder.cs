using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.CheckoutApi.Client.RequestBuilders.PaymentIntents;
using commercetools.Sdk.CheckoutApi.Client.RequestBuilders.Transactions;
using commercetools.Sdk.CheckoutApi.Client.RequestBuilders.PaymentIntegrations;
using commercetools.Sdk.CheckoutApi.Client.RequestBuilders.Applications;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.Projects
{

    public partial class ByProjectKeyRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }



        public ByProjectKeyPaymentIntentsRequestBuilder PaymentIntents()
        {
            return new ByProjectKeyPaymentIntentsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyTransactionsRequestBuilder Transactions()
        {
            return new ByProjectKeyTransactionsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyPaymentIntegrationsRequestBuilder PaymentIntegrations()
        {
            return new ByProjectKeyPaymentIntegrationsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }

        public ByProjectKeyApplicationsRequestBuilder Applications()
        {
            return new ByProjectKeyApplicationsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
        }
    }
}
