using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.RecurringPayment
{

    public partial class ByProjectKeyRecurringPaymentJobsPost : ApiMethod<ByProjectKeyRecurringPaymentJobsPost>, IApiMethod<ByProjectKeyRecurringPaymentJobsPost, commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.IRecurringPaymentJob>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_manage_recurring_payment_jobsTrait<ByProjectKeyRecurringPaymentJobsPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.IRecurringPaymentJobDraft RecurringPaymentJobDraft;

        public ByProjectKeyRecurringPaymentJobsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.IRecurringPaymentJobDraft recurringPaymentJobDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.RecurringPaymentJobDraft = recurringPaymentJobDraft;
            this.RequestUrl = $"/{Uri.EscapeDataString(ProjectKey)}/recurring-payment-jobs";
        }




        public async Task<commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.IRecurringPaymentJob> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.IRecurringPaymentJob>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.IRecurringPaymentJob>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.IRecurringPaymentJob>(requestMessage, cancellationToken);

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
                var body = this.SerializerService.Serialize(RecurringPaymentJobDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
