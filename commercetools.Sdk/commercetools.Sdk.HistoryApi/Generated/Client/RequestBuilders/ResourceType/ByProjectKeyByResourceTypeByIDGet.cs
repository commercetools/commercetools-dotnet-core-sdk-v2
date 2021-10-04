using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.HistoryApi.Models;

namespace commercetools.HistoryApi.Client.RequestBuilders.ResourceType
{
    public partial class ByProjectKeyByResourceTypeByIDGet : ApiMethod<ByProjectKeyByResourceTypeByIDGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ResourceType { get; }

        private string ID { get; }


        public ByProjectKeyByResourceTypeByIDGet(IClient apiHttpClient, string projectKey, string resourceType, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ResourceType = resourceType;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/{ResourceType}/{ID}";
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

        public List<string> GetType()
        {
            return this.GetQueryParam("type");
        }

        public List<string> GetClientId()
        {
            return this.GetQueryParam("clientId");
        }

        public List<string> GetSource()
        {
            return this.GetQueryParam("source");
        }

        public List<string> GetChanges()
        {
            return this.GetQueryParam("changes");
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

        public ByProjectKeyByResourceTypeByIDGet WithDateFrom(Object dateFrom)
        {
            return this.AddQueryParam("date.from", dateFrom.ToString());
        }

        public ByProjectKeyByResourceTypeByIDGet WithDateTo(Object dateTo)
        {
            return this.AddQueryParam("date.to", dateTo.ToString());
        }

        public ByProjectKeyByResourceTypeByIDGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyByResourceTypeByIDGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyByResourceTypeByIDGet WithUserId(string userId)
        {
            return this.AddQueryParam("userId", userId);
        }

        public ByProjectKeyByResourceTypeByIDGet WithType(string type)
        {
            return this.AddQueryParam("type", type);
        }

        public ByProjectKeyByResourceTypeByIDGet WithClientId(string clientId)
        {
            return this.AddQueryParam("clientId", clientId);
        }

        public ByProjectKeyByResourceTypeByIDGet WithSource(string source)
        {
            return this.AddQueryParam("source", source);
        }

        public ByProjectKeyByResourceTypeByIDGet WithChanges(string changes)
        {
            return this.AddQueryParam("changes", changes);
        }

        public ByProjectKeyByResourceTypeByIDGet WithCustomerId(string customerId)
        {
            return this.AddQueryParam("customerId", customerId);
        }

        public ByProjectKeyByResourceTypeByIDGet WithExcludePlatformInitiatedChanges(IPlatformInitiatedChange excludePlatformInitiatedChanges)
        {
            return this.AddQueryParam("excludePlatformInitiatedChanges", excludePlatformInitiatedChanges.ToString());
        }

        public ByProjectKeyByResourceTypeByIDGet WithExpand(bool expand)
        {
            return this.AddQueryParam("expand", expand.ToString());
        }


        public async Task<commercetools.HistoryApi.Models.IRecordPagedQueryResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.HistoryApi.Models.IRecordPagedQueryResponse>(requestMessage);
        }
    }
}
