using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.Channels
{
   public class ByProjectKeyChannelsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyChannelsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyChannelsByIDGet Get() {
           return new ByProjectKeyChannelsByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyChannelsByIDPost Post(commercetools.Api.Models.Channels.ChannelUpdate channelUpdate) {
           return new ByProjectKeyChannelsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, channelUpdate);
       }
       
       public ByProjectKeyChannelsByIDDelete Delete() {
           return new ByProjectKeyChannelsByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
