using System;
using System.Globalization;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Sdk.HistoryApi.Models.ChangeHistories;

// ReSharper disable CheckNamespace
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

        public List<string> GetResourceTypes()
        {
            return this.GetQueryParam("resourceTypes");
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

        public List<string> GetResourceId()
        {
            return this.GetQueryParam("resourceId");
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

        public ByProjectKeyGet WithResourceTypes(IChangeHistoryResourceType resourceTypes)
        {
            return this.AddQueryParam("resourceTypes", resourceTypes.ToString());
        }

        public ByProjectKeyGet WithDateFrom(Object dateFrom)
        {
            return this.AddQueryParam("date.from", dateFrom.ToString());
        }

        public ByProjectKeyGet WithDateTo(Object dateTo)
        {
            return this.AddQueryParam("date.to", dateTo.ToString());
        }

        public ByProjectKeyGet WithLimit(long limit)
        {
            return this.AddQueryParam("limit", limit.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyGet WithOffset(long offset)
        {
            return this.AddQueryParam("offset", offset.ToString(CultureInfo.InvariantCulture));
        }

        public ByProjectKeyGet WithUserId(string userId)
        {
            return this.AddQueryParam("userId", userId);
        }

        public ByProjectKeyGet WithClientId(string clientId)
        {
            return this.AddQueryParam("clientId", clientId);
        }

        public ByProjectKeyGet WithCustomerId(string customerId)
        {
            return this.AddQueryParam("customerId", customerId);
        }

        public ByProjectKeyGet WithAssociateId(string associateId)
        {
            return this.AddQueryParam("associateId", associateId);
        }

        public ByProjectKeyGet WithBusinessUnit(string businessUnit)
        {
            return this.AddQueryParam("businessUnit", businessUnit);
        }

        public ByProjectKeyGet WithType(string type)
        {
            return this.AddQueryParam("type", type);
        }

        public ByProjectKeyGet WithResourceId(string resourceId)
        {
            return this.AddQueryParam("resourceId", resourceId);
        }

        public ByProjectKeyGet WithResourceKey(string resourceKey)
        {
            return this.AddQueryParam("resourceKey", resourceKey);
        }

        public ByProjectKeyGet WithSource(ISource source)
        {
            return this.AddQueryParam("source", source.JsonName);
        }

        public ByProjectKeyGet WithChanges(string changes)
        {
            return this.AddQueryParam("changes", changes);
        }

        public ByProjectKeyGet WithStores(string stores)
        {
            return this.AddQueryParam("stores", stores);
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
