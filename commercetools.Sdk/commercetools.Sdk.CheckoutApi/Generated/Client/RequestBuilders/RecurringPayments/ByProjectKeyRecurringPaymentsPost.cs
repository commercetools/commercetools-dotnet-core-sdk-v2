using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.RecurringPayments
{

    public partial class ByProjectKeyRecurringPaymentsPost : ApiMethod<ByProjectKeyRecurringPaymentsPost>, IApiMethod<ByProjectKeyRecurringPaymentsPost, commercetools.Sdk.CheckoutApi.Models.RecurringPayments.IRecurringPayment>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_manage_recurring_paymentsTrait<ByProjectKeyRecurringPaymentsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.CheckoutApi.Models.RecurringPayments.IRecurringPaymentDraft RecurringPaymentDraft;

        public ByProjectKeyRecurringPaymentsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.CheckoutApi.Models.RecurringPayments.IRecurringPaymentDraft recurringPaymentDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.RecurringPaymentDraft = recurringPaymentDraft;
            this.RequestUrl = $"/{Uri.EscapeDataString(ProjectKey)}/recurring-payments";
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
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(RecurringPaymentDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
