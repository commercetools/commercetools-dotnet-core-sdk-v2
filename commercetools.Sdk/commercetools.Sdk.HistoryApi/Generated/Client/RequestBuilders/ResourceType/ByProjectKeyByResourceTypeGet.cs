using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Sdk.HistoryApi.Models.ChangeHistories;

namespace commercetools.Sdk.HistoryApi.Client.RequestBuilders.ResourceType
{

    public partial class ByProjectKeyByResourceTypeGet : ApiMethod<ByProjectKeyByResourceTypeGet>, IApiMethod<ByProjectKeyByResourceTypeGet, commercetools.Sdk.HistoryApi.Models.ChangeHistories.IRecordPagedQueryResponse>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ResourceType { get; }


        public ByProjectKeyByResourceTypeGet(IClient apiHttpClient, string projectKey, string resourceType)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ResourceType = resourceType;
            this.RequestUrl = $"/{ProjectKey}/{ResourceType}";
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

        public ByProjectKeyByResourceTypeGet WithDateFrom(Object dateFrom)
        {
            return this.AddQueryParam("date.from", dateFrom.ToString());
        }

        public ByProjectKeyByResourceTypeGet WithDateTo(Object dateTo)
        {
            return this.AddQueryParam("date.to", dateTo.ToString());
        }

        public ByProjectKeyByResourceTypeGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyByResourceTypeGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyByResourceTypeGet WithUserId(string userId)
        {
            return this.AddQueryParam("userId", userId);
        }

        public ByProjectKeyByResourceTypeGet WithType(string type)
        {
            return this.AddQueryParam("type", type);
        }

        public ByProjectKeyByResourceTypeGet WithClientId(string clientId)
        {
            return this.AddQueryParam("clientId", clientId);
        }

        public ByProjectKeyByResourceTypeGet WithResourceId(string resourceId)
        {
            return this.AddQueryParam("resourceId", resourceId);
        }

        public ByProjectKeyByResourceTypeGet WithSource(string source)
        {
            return this.AddQueryParam("source", source);
        }

        public ByProjectKeyByResourceTypeGet WithChanges(string changes)
        {
            return this.AddQueryParam("changes", changes);
        }

        public ByProjectKeyByResourceTypeGet WithStores(string stores)
        {
            return this.AddQueryParam("stores", stores);
        }

        public ByProjectKeyByResourceTypeGet WithCustomerId(string customerId)
        {
            return this.AddQueryParam("customerId", customerId);
        }

        public ByProjectKeyByResourceTypeGet WithExcludePlatformInitiatedChanges(IPlatformInitiatedChange excludePlatformInitiatedChanges)
        {
            return this.AddQueryParam("excludePlatformInitiatedChanges", excludePlatformInitiatedChanges.ToString());
        }

        public ByProjectKeyByResourceTypeGet WithExpand(bool expand)
        {
            return this.AddQueryParam("expand", expand.ToString());
        }


        public async Task<commercetools.Sdk.HistoryApi.Models.ChangeHistories.IRecordPagedQueryResponse> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.HistoryApi.Models.ChangeHistories.IRecordPagedQueryResponse>(requestMessage, cancellationToken);
        }

    }
}
