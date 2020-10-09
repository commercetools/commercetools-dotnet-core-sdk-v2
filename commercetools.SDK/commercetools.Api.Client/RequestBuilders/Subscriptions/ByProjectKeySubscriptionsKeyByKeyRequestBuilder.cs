using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.Subscriptions
{
   public class ByProjectKeySubscriptionsKeyByKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string Key { get; }
   
       public ByProjectKeySubscriptionsKeyByKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Key = key;
       }
   
       public ByProjectKeySubscriptionsKeyByKeyGet Get() {
           return new ByProjectKeySubscriptionsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
       }
       
       public ByProjectKeySubscriptionsKeyByKeyPost Post(commercetools.Api.Models.Subscriptions.SubscriptionUpdate subscriptionUpdate) {
           return new ByProjectKeySubscriptionsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, subscriptionUpdate);
       }
       
       public ByProjectKeySubscriptionsKeyByKeyDelete Delete() {
           return new ByProjectKeySubscriptionsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
       }
       
   }
}
