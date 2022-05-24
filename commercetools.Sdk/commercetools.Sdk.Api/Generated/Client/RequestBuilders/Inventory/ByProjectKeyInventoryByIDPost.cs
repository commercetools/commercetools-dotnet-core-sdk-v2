using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Sdk.Api.Client.RequestBuilders.Inventory
{
    public partial class ByProjectKeyInventoryByIDPost : ApiMethod<ByProjectKeyInventoryByIDPost>, IApiMethod<ByProjectKeyInventoryByIDPost, commercetools.Sdk.Api.Models.Inventories.IInventoryEntry>, commercetools.Sdk.Api.Client.IConflictingTrait<ByProjectKeyInventoryByIDPost>, commercetools.Sdk.Api.Client.IExpandableTrait<ByProjectKeyInventoryByIDPost>, commercetools.Sdk.Api.Client.IDeprecatable200Trait<ByProjectKeyInventoryByIDPost>, commercetools.Sdk.Api.Client.IErrorableTrait<ByProjectKeyInventoryByIDPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private string ID { get; }

        private commercetools.Sdk.Api.Models.Inventories.IInventoryEntryUpdate InventoryEntryUpdate;

        public ByProjectKeyInventoryByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Sdk.Api.Models.Inventories.IInventoryEntryUpdate inventoryEntryUpdate)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.InventoryEntryUpdate = inventoryEntryUpdate;
            this.RequestUrl = $"/{ProjectKey}/inventory/{ID}";
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyInventoryByIDPost WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Sdk.Api.Models.Inventories.IInventoryEntry> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.Api.Models.Inventories.IInventoryEntry>(requestMessage);
        }
        public override HttpRequestMessage Build()
        {
            var request = base.Build();
            if (SerializerService != null)
            {
                var body = this.SerializerService.Serialize(InventoryEntryUpdate);
                if (!string.IsNullOrEmpty(body))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
            }
            return request;
        }

    }
}
