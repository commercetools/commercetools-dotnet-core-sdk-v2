using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Inventory
{

    public partial class ByProjectKeyInventoryPost : ApiMethod<ByProjectKeyInventoryPost>, IApiMethod<ByProjectKeyInventoryPost, commercetools.Sdk.Api.Models.Inventories.IInventoryEntry>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInventoryPost>, commercetools.Sdk.Api.Client.IDeprecatable201Trait<ByProjectKeyInventoryPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInventoryPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Sdk.Api.Models.Inventories.IInventoryEntryDraft InventoryEntryDraft;

        public ByProjectKeyInventoryPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Sdk.Api.Models.Inventories.IInventoryEntryDraft inventoryEntryDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.InventoryEntryDraft = inventoryEntryDraft;
            this.RequestUrl = $"/{ProjectKey}/inventory";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInventoryPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Inventories.IInventoryEntry> ExecuteAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Inventories.IInventoryEntry>(requestMessage, cancellationToken);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(InventoryEntryDraft);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
