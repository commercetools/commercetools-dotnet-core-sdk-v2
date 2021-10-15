using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Inventory
{
    public partial class ByProjectKeyInventoryPost : ApiMethod<ByProjectKeyInventoryPost>
    {


        private ISerializerService SerializerService { get; }

        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Post;

        private string ProjectKey { get; }

        private commercetools.Api.Models.Inventories.IInventoryEntryDraft InventoryEntryDraft;

        public ByProjectKeyInventoryPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.Inventories.IInventoryEntryDraft inventoryEntryDraft)
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


        public async Task<commercetools.Api.Models.Inventories.IInventoryEntry> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Inventories.IInventoryEntry>(requestMessage);
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
