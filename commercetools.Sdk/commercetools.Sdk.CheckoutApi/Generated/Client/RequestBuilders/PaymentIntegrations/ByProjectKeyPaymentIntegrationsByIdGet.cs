using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.PaymentIntegrations
{

    public partial class ByProjectKeyPaymentIntegrationsByIdGet : ApiMethod<ByProjectKeyPaymentIntegrationsByIdGet>, IApiMethod<ByProjectKeyPaymentIntegrationsByIdGet, commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.IPaymentIntegration>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_view_payment_integrationsTrait<ByProjectKeyPaymentIntegrationsByIdGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Id { get; }


        public ByProjectKeyPaymentIntegrationsByIdGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Id = id;
            this.RequestUrl = $"/{ProjectKey}/payment-integrations/{Id}";
        }




        public async Task<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.IPaymentIntegration> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.IPaymentIntegration>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.IPaymentIntegration>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.IPaymentIntegration>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
