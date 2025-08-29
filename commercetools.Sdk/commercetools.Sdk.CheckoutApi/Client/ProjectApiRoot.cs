using commercetools.Base.Client;
using commercetools.Sdk.CheckoutApi.Client.RequestBuilders.PaymentIntents;
using commercetools.Sdk.CheckoutApi.Client.RequestBuilders.Projects;
using commercetools.Sdk.CheckoutApi.Client.RequestBuilders.Transactions;

namespace commercetools.Sdk.CheckoutApi.Client
{
    public class ProjectApiRoot
    {
        public string ClientName { get; }

        private string ProjectKey { get; }

        private IClient ApiHttpClient { get; }

        public ProjectApiRoot(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ClientName = apiHttpClient.Name;
        }

        private ByProjectKeyRequestBuilder With()
        {
            return new CheckoutApiRoot(ApiHttpClient).WithProject(ProjectKey);
        }

        public ByProjectKeyPaymentIntentsRequestBuilder PaymentIntents()
        {
            return With().PaymentIntents();
        }

        public ByProjectKeyTransactionsRequestBuilder Transactions()
        {
            return With().Transactions();
        }
    }
}