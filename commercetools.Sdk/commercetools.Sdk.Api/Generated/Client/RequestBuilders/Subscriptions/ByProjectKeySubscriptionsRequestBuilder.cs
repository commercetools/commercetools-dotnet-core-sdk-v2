using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.Subscriptions;

namespace commercetools.Api.Client.RequestBuilders.Subscriptions
{
   public class ByProjectKeySubscriptionsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeySubscriptionsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeySubscriptionsGet Get() {
           return new ByProjectKeySubscriptionsGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeySubscriptionsPost Post(commercetools.Api.Models.Subscriptions.ISubscriptionDraft subscriptionDraft) {
           return new ByProjectKeySubscriptionsPost(ApiHttpClient, SerializerService, ProjectKey, subscriptionDraft);
       }
       
       public ByProjectKeySubscriptionsKeyByKeyRequestBuilder WithKey(string key) {
           return new ByProjectKeySubscriptionsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
       }
       public ByProjectKeySubscriptionsByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeySubscriptionsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
