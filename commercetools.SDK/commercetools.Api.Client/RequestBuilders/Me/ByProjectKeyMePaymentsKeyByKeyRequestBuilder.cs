using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.Me
{
   public class ByProjectKeyMePaymentsKeyByKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string Key { get; }
   
       public ByProjectKeyMePaymentsKeyByKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Key = key;
       }
   
       public ByProjectKeyMePaymentsKeyByKeyGet Get() {
           return new ByProjectKeyMePaymentsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
       }
       
       public ByProjectKeyMePaymentsKeyByKeyPost Post(commercetools.Api.Models.Me.MyPaymentUpdate myPaymentUpdate) {
           return new ByProjectKeyMePaymentsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, myPaymentUpdate);
       }
       
       public ByProjectKeyMePaymentsKeyByKeyDelete Delete() {
           return new ByProjectKeyMePaymentsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
       }
       
   }
}
