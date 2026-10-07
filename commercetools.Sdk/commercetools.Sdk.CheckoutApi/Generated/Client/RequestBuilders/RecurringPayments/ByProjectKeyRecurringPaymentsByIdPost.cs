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

    public partial class ByProjectKeyRecurringPaymentsByIdPost : ApiMethod<ByProjectKeyRecurringPaymentsByIdPost>, IApiMethod<ByProjectKeyRecurringPaymentsByIdPost, commercetools.Sdk.CheckoutApi.Models.RecurringPayments.IRecurringPayment>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_manage_recurring_paymentsTrait<ByProjectKeyRecurringPaymentsByIdPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string Id { get; }

        private commercetools.Sdk.CheckoutApi.Models.RecurringPayments.IRecurringPaymentUpdateActions RecurringPaymentUpdateActions;

        public ByProjectKeyRecurringPaymentsByIdPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.CheckoutApi.Models.RecurringPayments.IRecurringPaymentUpdateActions recurringPaymentUpdateActions)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.Id = id;
            this.RecurringPaymentUpdateActions = recurringPaymentUpdateActions;
            this.RequestUrl = $"/{Uri.EscapeDataString(ProjectKey)}/recurring-payments/{Uri.EscapeDataString(Id)}";
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
                var body = this.SerializerService.Serialize(RecurringPaymentUpdateActions);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
