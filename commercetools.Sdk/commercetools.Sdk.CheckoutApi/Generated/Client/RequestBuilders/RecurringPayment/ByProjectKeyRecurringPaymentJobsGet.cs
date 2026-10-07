using System;
using System.Globalization;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.RecurringPayment
{

    public partial class ByProjectKeyRecurringPaymentJobsGet : ApiMethod<ByProjectKeyRecurringPaymentJobsGet>, IApiMethod<ByProjectKeyRecurringPaymentJobsGet, commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.IPaginatedRecurringPaymentJob>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_view_recurring_payment_jobsTrait<ByProjectKeyRecurringPaymentJobsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyRecurringPaymentJobsGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{Uri.EscapeDataString(ProjectKey)}/recurring-payment-jobs";
        }

        public List<string> GetSort()
        {
            return this.GetQueryParam("sort");
        }

        public List<string> GetLimit()
        {
            return this.GetQueryParam("limit");
        }

        public List<string> GetOffset()
        {
            return this.GetQueryParam("offset");
        }

        public List<string> GetWithTotal()
        {
            return this.GetQueryParam("withTotal");
        }

        public List<string> GetStatusState()
        {
            return this.GetQueryParam("status.state");
        }

        public ByProjectKeyRecurringPaymentJobsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyRecurringPaymentJobsGet WithLimit(long limit)
        {
            return this.AddQueryParam("limit", limit.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyRecurringPaymentJobsGet WithOffset(long offset)
        {
            return this.AddQueryParam("offset", offset.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyRecurringPaymentJobsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyRecurringPaymentJobsGet WithStatusState(string statusState)
        {
            return this.AddQueryParam("status.state", statusState);
        }


        public async Task<commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.IPaginatedRecurringPaymentJob> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.IPaginatedRecurringPaymentJob>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.IPaginatedRecurringPaymentJob>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.CheckoutApi.Models.RecurringPaymentJobs.IPaginatedRecurringPaymentJob>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
