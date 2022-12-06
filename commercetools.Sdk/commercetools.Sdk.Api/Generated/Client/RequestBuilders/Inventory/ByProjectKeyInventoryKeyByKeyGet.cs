using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Inventory
{

    public partial class ByProjectKeyInventoryKeyByKeyGet : ApiMethod<ByProjectKeyInventoryKeyByKeyGet>, IApiMethod<ByProjectKeyInventoryKeyByKeyGet, commercetools.Sdk.Api.Models.Inventories.IInventoryEntry>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInventoryKeyByKeyGet>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInventoryKeyByKeyGet>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInventoryKeyByKeyGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string Key { get; }


        public ByProjectKeyInventoryKeyByKeyGet(IClient apiHttpClient, string projectKey, string key)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.Key = key;
            this.RequestUrl = $"/{ProjectKey}/inventory/key={Key}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInventoryKeyByKeyGet WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Inventories.IInventoryEntry> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Inventories.IInventoryEntry>(requestMessage, cancellationToken);
        }

    }
}
