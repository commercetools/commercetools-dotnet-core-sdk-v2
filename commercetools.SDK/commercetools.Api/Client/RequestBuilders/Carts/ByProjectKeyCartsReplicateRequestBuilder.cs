using System.IO;
using System.Text.Json;
using commercetools.Base.Serialization;
using commercetools.Base.Client;

namespace commercetools.Api.Client.RequestBuilders.Carts
{
   public class ByProjectKeyCartsReplicateRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyCartsReplicateRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyCartsReplicatePost Post(commercetools.Api.Models.Carts.ReplicaCartDraft replicaCartDraft) {
           return new ByProjectKeyCartsReplicatePost(ApiHttpClient, SerializerService, ProjectKey, replicaCartDraft);
       }
       
   }
}
