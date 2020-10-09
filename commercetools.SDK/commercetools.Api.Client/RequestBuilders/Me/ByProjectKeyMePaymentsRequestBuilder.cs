using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;
using commercetools.Api.Client.RequestBuilders.Me;

namespace commercetools.Api.Client.RequestBuilders.Me
{
   public class ByProjectKeyMePaymentsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyMePaymentsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyMePaymentsGet Get() {
           return new ByProjectKeyMePaymentsGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyMePaymentsPost Post(commercetools.Api.Models.Me.MyPaymentDraft myPaymentDraft) {
           return new ByProjectKeyMePaymentsPost(ApiHttpClient, SerializerService, ProjectKey, myPaymentDraft);
       }
       
       public ByProjectKeyMePaymentsKeyByKeyRequestBuilder WithKey(string key) {
           return new ByProjectKeyMePaymentsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
       }
       public ByProjectKeyMePaymentsByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyMePaymentsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
