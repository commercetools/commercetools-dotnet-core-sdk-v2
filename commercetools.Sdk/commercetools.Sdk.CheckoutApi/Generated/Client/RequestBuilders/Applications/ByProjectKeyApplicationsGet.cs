using System.Globalization;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Client.RequestBuilders.Applications
{

    public partial class ByProjectKeyApplicationsGet : ApiMethod<ByProjectKeyApplicationsGet>, IApiMethod<ByProjectKeyApplicationsGet, commercetools.Sdk.CheckoutApi.Models.Applications.IPaginatedApplication>, commercetools.Sdk.CheckoutApi.Client.ISecured_by_view_applicationsTrait<ByProjectKeyApplicationsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyApplicationsGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/applications";
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

        public ByProjectKeyApplicationsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyApplicationsGet WithLimit(long limit)
        {
            return this.AddQueryParam("limit", limit.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyApplicationsGet WithOffset(long offset)
        {
            return this.AddQueryParam("offset", offset.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyApplicationsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }


        public async Task<commercetools.Sdk.CheckoutApi.Models.Applications.IPaginatedApplication> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.CheckoutApi.Models.Applications.IPaginatedApplication>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.CheckoutApi.Models.Applications.IPaginatedApplication>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.CheckoutApi.Models.Applications.IPaginatedApplication>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
