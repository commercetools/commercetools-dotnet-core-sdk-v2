using System.IO;
using System.Text.Json;
using commercetools.Base.Serialization;
using commercetools.Base.Client;

namespace commercetools.Api.Client.RequestBuilders.ShippingMethods
{
   public class ByProjectKeyShippingMethodsKeyByKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string Key { get; }
   
       public ByProjectKeyShippingMethodsKeyByKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Key = key;
       }
   
       public ByProjectKeyShippingMethodsKeyByKeyGet Get() {
           return new ByProjectKeyShippingMethodsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
       }
       
       public ByProjectKeyShippingMethodsKeyByKeyPost Post(commercetools.Api.Models.ShippingMethods.ShippingMethodUpdate shippingMethodUpdate) {
           return new ByProjectKeyShippingMethodsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, shippingMethodUpdate);
       }
       
       public ByProjectKeyShippingMethodsKeyByKeyDelete Delete() {
           return new ByProjectKeyShippingMethodsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
       }
       
   }
}
