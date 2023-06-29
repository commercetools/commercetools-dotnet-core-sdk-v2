using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Client.RequestBuilders.Customers
{

    public partial class ByProjectKeyCustomersGet : ApiMethod<ByProjectKeyCustomersGet>, IApiMethod<ByProjectKeyCustomersGet, commercetools.Sdk.Api.Models.Customers.ICustomerPagedQueryResponse>, commercetools.Sdk.Api.Models.IPagedQueryResourceRequest<ByProjectKeyCustomersGet, commercetools.Sdk.Api.Models.Customers.ICustomerPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCustomersGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyCustomersGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyCustomersGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeyCustomersGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCustomersGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCustomersGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyCustomersGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/customers";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
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

        public List<string> GetWhere()
        {
            return this.GetQueryParam("where");
        }

        public ByProjectKeyCustomersGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyCustomersGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyCustomersGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyCustomersGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyCustomersGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyCustomersGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyCustomersGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.Customers.ICustomerPagedQueryResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Customers.ICustomerPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.Customers.ICustomerPagedQueryResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.Customers.ICustomerPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
