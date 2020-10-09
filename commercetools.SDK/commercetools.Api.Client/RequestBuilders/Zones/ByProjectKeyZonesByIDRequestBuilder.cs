using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.Zones
{
   public class ByProjectKeyZonesByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyZonesByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyZonesByIDGet Get() {
           return new ByProjectKeyZonesByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyZonesByIDPost Post(commercetools.Api.Models.Zones.ZoneUpdate zoneUpdate) {
           return new ByProjectKeyZonesByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, zoneUpdate);
       }
       
       public ByProjectKeyZonesByIDDelete Delete() {
           return new ByProjectKeyZonesByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
