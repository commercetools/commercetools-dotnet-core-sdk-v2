using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.RecurringPayments
{

    public partial class ByProjectKeyRecurringPaymentsByIdGet : ApiMethod<ByProjectKeyRecurringPaymentsByIdGet>, IApiMethod<ByProjectKeyRecurringPaymentsByIdGet, commercetools.Sdk.CheckoutApi.Models.RecurringPayments.IRecurringPayment>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_view_recurring_paymentsTrait<ByProjectKeyRecurringPaymentsByIdGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Id { get; }


        public ByProjectKeyRecurringPaymentsByIdGet(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Id = id;
            this.RequestUrl = $"/{EscapePathParameter(ProjectKey)}/recurring-payments/{EscapePathParameter(Id)}";
        }




        public async Task<commercetools.Sdk.CheckoutApi.Models.RecurringPayments.IRecurringPayment> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.CheckoutApi.Models.RecurringPayments.IRecurringPayment>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.CheckoutApi.Models.RecurringPayments.IRecurringPayment>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.CheckoutApi.Models.RecurringPayments.IRecurringPayment>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
