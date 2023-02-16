using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Sdk.HistoryApi.Models.ChangeHistories;

namespace commercetools.Sdk.HistoryApi.Client.RequestBuilders.Projects
{

    public partial class ByProjectKeyGet : ApiMethod<ByProjectKeyGet>, IApiMethod<ByProjectKeyGet, commercetools.Sdk.HistoryApi.Models.ChangeHistories.IRecordPagedQueryResponse>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}";
        }

        public List<string> GetResourceType()
        {
            return this.GetQueryParam("resourceType");
        }

        public List<string> GetDateFrom()
        {
            return this.GetQueryParam("date.from");
        }

        public List<string> GetDateTo()
        {
            return this.GetQueryParam("date.to");
        }

        public List<string> GetLimit()
        {
            return this.GetQueryParam("limit");
        }

        public List<string> GetOffset()
        {
            return this.GetQueryParam("offset");
        }

        public List<string> GetUserId()
        {
            return this.GetQueryParam("userId");
        }

        public new List<string> GetType()
        {
            return this.GetQueryParam("type");
        }

        public List<string> GetClientId()
        {
            return this.GetQueryParam("clientId");
        }

        public List<string> GetResourceId()
        {
            return this.GetQueryParam("resourceId");
        }

        public List<string> GetSource()
        {
            return this.GetQueryParam("source");
        }

        public List<string> GetChanges()
        {
            return this.GetQueryParam("changes");
        }

        public List<string> GetStores()
        {
            return this.GetQueryParam("stores");
        }

        public List<string> GetCustomerId()
        {
            return this.GetQueryParam("customerId");
        }

        public List<string> GetExcludePlatformInitiatedChanges()
        {
            return this.GetQueryParam("excludePlatformInitiatedChanges");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyGet WithResourceType(IChangeHistoryResourceType resourceType)
        {
            return this.AddQueryParam("resourceType", resourceType.ToString());
        }

        public ByProjectKeyGet WithDateFrom(Object dateFrom)
        {
            return this.AddQueryParam("date.from", dateFrom.ToString());
        }

        public ByProjectKeyGet WithDateTo(Object dateTo)
        {
            return this.AddQueryParam("date.to", dateTo.ToString());
        }

        public ByProjectKeyGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyGet WithUserId(string userId)
        {
            return this.AddQueryParam("userId", userId);
        }

        public ByProjectKeyGet WithType(string type)
        {
            return this.AddQueryParam("type", type);
        }

        public ByProjectKeyGet WithClientId(string clientId)
        {
            return this.AddQueryParam("clientId", clientId);
        }

        public ByProjectKeyGet WithResourceId(string resourceId)
        {
            return this.AddQueryParam("resourceId", resourceId);
        }

        public ByProjectKeyGet WithSource(string source)
        {
            return this.AddQueryParam("source", source);
        }

        public ByProjectKeyGet WithChanges(string changes)
        {
            return this.AddQueryParam("changes", changes);
        }

        public ByProjectKeyGet WithStores(string stores)
        {
            return this.AddQueryParam("stores", stores);
        }

        public ByProjectKeyGet WithCustomerId(string customerId)
        {
            return this.AddQueryParam("customerId", customerId);
        }

        public ByProjectKeyGet WithExcludePlatformInitiatedChanges(IPlatformInitiatedChange excludePlatformInitiatedChanges)
        {
            return this.AddQueryParam("excludePlatformInitiatedChanges", excludePlatformInitiatedChanges.ToString());
        }

        public ByProjectKeyGet WithExpand(bool expand)
        {
            return this.AddQueryParam("expand", expand.ToString());
        }


        public async Task<commercetools.Sdk.HistoryApi.Models.ChangeHistories.IRecordPagedQueryResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.HistoryApi.Models.ChangeHistories.IRecordPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.HistoryApi.Models.ChangeHistories.IRecordPagedQueryResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.HistoryApi.Models.ChangeHistories.IRecordPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
