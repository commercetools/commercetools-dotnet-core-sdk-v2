using System.IO;
using System.Text.Json;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.Zones;

using commercetools.Base.Client;

namespace commercetools.Api.Client.RequestBuilders.Zones
{
   public class ByProjectKeyZonesRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyZonesRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyZonesGet Get() {
           return new ByProjectKeyZonesGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyZonesPost Post(commercetools.Api.Models.Zones.ZoneDraft zoneDraft) {
           return new ByProjectKeyZonesPost(ApiHttpClient, SerializerService, ProjectKey, zoneDraft);
       }
       
       public ByProjectKeyZonesKeyByKeyRequestBuilder WithKey(string key) {
           return new ByProjectKeyZonesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
       }
       public ByProjectKeyZonesByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyZonesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
