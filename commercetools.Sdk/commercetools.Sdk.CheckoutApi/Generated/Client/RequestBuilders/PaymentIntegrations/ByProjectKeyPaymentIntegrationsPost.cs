using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.PaymentIntegrations
{

    public partial class ByProjectKeyPaymentIntegrationsPost : ApiMethod<ByProjectKeyPaymentIntegrationsPost>, IApiMethod<ByProjectKeyPaymentIntegrationsPost, commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.IPaymentIntegration>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_manage_payment_integrationsTrait<ByProjectKeyPaymentIntegrationsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.CheckoutApi.Models.PaymentIntegrationDrafts.IPaymentIntegrationDraft PaymentIntegrationDraft;

        public ByProjectKeyPaymentIntegrationsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.CheckoutApi.Models.PaymentIntegrationDrafts.IPaymentIntegrationDraft paymentIntegrationDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.PaymentIntegrationDraft = paymentIntegrationDraft;
            this.RequestUrl = $"/{ProjectKey}/payment-integrations";
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
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(PaymentIntegrationDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
