using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.RecurringPayments
{

    public partial class ByProjectKeyRecurringPaymentsKeyByKeyGet : ApiMethod<ByProjectKeyRecurringPaymentsKeyByKeyGet>, IApiMethod<ByProjectKeyRecurringPaymentsKeyByKeyGet, commercetools.Sdk.CheckoutApi.Models.RecurringPayments.IRecurringPayment>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_view_recurring_paymentsTrait<ByProjectKeyRecurringPaymentsKeyByKeyGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyRecurringPaymentsKeyByKeyGet(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{Uri.EscapeDataString(ProjectKey)}/recurring-payments/key={Uri.EscapeDataString(Key)}";
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
