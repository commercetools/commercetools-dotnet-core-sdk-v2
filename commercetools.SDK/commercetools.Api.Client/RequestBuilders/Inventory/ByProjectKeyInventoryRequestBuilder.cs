using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;
using commercetools.Api.Client.RequestBuilders.Inventory;

namespace commercetools.Api.Client.RequestBuilders.Inventory
{
   public class ByProjectKeyInventoryRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyInventoryRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyInventoryGet Get() {
           return new ByProjectKeyInventoryGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyInventoryPost Post(commercetools.Api.Models.Inventories.InventoryEntryDraft inventoryEntryDraft) {
           return new ByProjectKeyInventoryPost(ApiHttpClient, SerializerService, ProjectKey, inventoryEntryDraft);
       }
       
       public ByProjectKeyInventoryByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyInventoryByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
