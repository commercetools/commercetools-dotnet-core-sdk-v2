using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Me
{
   public class ByProjectKeyMePaymentsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyMePaymentsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyMePaymentsByIDGet Get() {
           return new ByProjectKeyMePaymentsByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyMePaymentsByIDPost Post(commercetools.Api.Models.Me.IMyPaymentUpdate myPaymentUpdate) {
           return new ByProjectKeyMePaymentsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, myPaymentUpdate);
       }
       
       public ByProjectKeyMePaymentsByIDDelete Delete() {
           return new ByProjectKeyMePaymentsByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
