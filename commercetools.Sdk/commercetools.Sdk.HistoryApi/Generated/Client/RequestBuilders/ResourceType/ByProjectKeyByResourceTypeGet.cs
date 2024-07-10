using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Sdk.HistoryApi.Models.ChangeHistories;

// ReSharper disable CheckNamespace
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

        public List<string> GetClientId()
        {
            return this.GetQueryParam("clientId");
        }

        public List<string> GetCustomerId()
        {
            return this.GetQueryParam("customerId");
        }

        public List<string> GetAssociateId()
        {
            return this.GetQueryParam("associateId");
        }

        public List<string> GetBusinessUnit()
        {
            return this.GetQueryParam("businessUnit");
        }

        public List<string> GetType()
        {
            return this.GetQueryParam("type");
        }

        public List<string> GetResourceKey()
        {
            return this.GetQueryParam("resourceKey");
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

        public ByProjectKeyByResourceTypeGet WithLimit(long limit)
        {
            return this.AddQueryParam("limit", limit.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyByResourceTypeGet WithOffset(long offset)
        {
            return this.AddQueryParam("offset", offset.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyByResourceTypeGet WithUserId(string userId)
        {
            return this.AddQueryParam("userId", userId);
        }

        public ByProjectKeyByResourceTypeGet WithClientId(string clientId)
        {
            return this.AddQueryParam("clientId", clientId);
        }

        public ByProjectKeyByResourceTypeGet WithCustomerId(string customerId)
        {
            return this.AddQueryParam("customerId", customerId);
        }

        public ByProjectKeyByResourceTypeGet WithAssociateId(string associateId)
        {
            return this.AddQueryParam("associateId", associateId);
        }

        public ByProjectKeyByResourceTypeGet WithBusinessUnit(string businessUnit)
        {
            return this.AddQueryParam("businessUnit", businessUnit);
        }

        public ByProjectKeyByResourceTypeGet WithType(string type)
        {
            return this.AddQueryParam("type", type);
        }

        public ByProjectKeyByResourceTypeGet WithResourceKey(string resourceKey)
        {
            return this.AddQueryParam("resourceKey", resourceKey);
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

        public ByProjectKeyByResourceTypeGet WithExcludePlatformInitiatedChanges(IPlatformInitiatedChange excludePlatformInitiatedChanges)
        {
            return this.AddQueryParam("excludePlatformInitiatedChanges", excludePlatformInitiatedChanges.ToString());
        }

        public ByProjectKeyByResourceTypeGet WithExpand(bool expand)
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
