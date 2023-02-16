using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.CustomObjects
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class ByProjectKeyCustomObjectsGet : ApiMethod<ByProjectKeyCustomObjectsGet>, IApiMethod<ByProjectKeyCustomObjectsGet, commercetools.Sdk.Api.Models.CustomObjects.ICustomObjectPagedQueryResponse>, commercetools.Sdk.Api.Models.IPagedQueryResourceRequest<ByProjectKeyCustomObjectsGet, commercetools.Sdk.Api.Models.CustomObjects.ICustomObjectPagedQueryResponse>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyCustomObjectsGet>, commercetools.Sdk.Api.Client.ISortableTrait<ByProjectKeyCustomObjectsGet>, commercetools.Sdk.Api.Client.IPagingTrait<ByProjectKeyCustomObjectsGet>, commercetools.Sdk.Api.Client.IQueryTrait<ByProjectKeyCustomObjectsGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyCustomObjectsGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyCustomObjectsGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyCustomObjectsGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/custom-objects";
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

        public ByProjectKeyCustomObjectsGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }

        public ByProjectKeyCustomObjectsGet WithSort(string sort)
        {
            return this.AddQueryParam("sort", sort);
        }

        public ByProjectKeyCustomObjectsGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyCustomObjectsGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyCustomObjectsGet WithWithTotal(bool withTotal)
        {
            return this.AddQueryParam("withTotal", withTotal.ToString());
        }

        public ByProjectKeyCustomObjectsGet WithWhere(string where)
        {
            return this.AddQueryParam("where", where);
        }

        public ByProjectKeyCustomObjectsGet WithPredicateVar(string varName, string predicateVar)
        {
            return this.AddQueryParam($"var.{varName}", predicateVar);
        }

        public async Task<commercetools.Sdk.Api.Models.CustomObjects.ICustomObjectPagedQueryResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.CustomObjects.ICustomObjectPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.Api.Models.CustomObjects.ICustomObjectPagedQueryResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.Api.Models.CustomObjects.ICustomObjectPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
