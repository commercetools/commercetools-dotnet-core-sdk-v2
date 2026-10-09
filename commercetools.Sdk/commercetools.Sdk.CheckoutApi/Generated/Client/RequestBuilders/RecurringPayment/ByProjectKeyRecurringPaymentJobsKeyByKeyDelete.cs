using System.Globalization;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.RecurringPayment
{

    public partial class ByProjectKeyRecurringPaymentJobsKeyByKeyDelete : ApiMethod<ByProjectKeyRecurringPaymentJobsKeyByKeyDelete>, IApiMethod<ByProjectKeyRecurringPaymentJobsKeyByKeyDelete, commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.IRecurringPaymentJob>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_manage_recurring_payment_jobsTrait<ByProjectKeyRecurringPaymentJobsKeyByKeyDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyRecurringPaymentJobsKeyByKeyDelete(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{EscapePathParameter(ProjectKey)}/recurring-payment-jobs/key={EscapePathParameter(Key)}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public ByProjectKeyRecurringPaymentJobsKeyByKeyDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString(CultureInfo.InvariantCulture));
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

    }
}
