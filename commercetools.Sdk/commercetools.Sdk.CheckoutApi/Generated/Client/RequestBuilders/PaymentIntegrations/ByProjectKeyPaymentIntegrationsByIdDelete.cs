using System.Globalization;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.PaymentIntegrations
{

    public partial class ByProjectKeyPaymentIntegrationsByIdDelete : ApiMethod<ByProjectKeyPaymentIntegrationsByIdDelete>, IApiMethod<ByProjectKeyPaymentIntegrationsByIdDelete, commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations.IPaymentIntegration>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_manage_payment_integrationsTrait<ByProjectKeyPaymentIntegrationsByIdDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string Id { get; }


        public ByProjectKeyPaymentIntegrationsByIdDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Id = id;
            this.RequestUrl = $"/{ProjectKey}/payment-integrations/{Id}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public ByProjectKeyPaymentIntegrationsByIdDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString(CultureInfo.InvariantCulture));
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
