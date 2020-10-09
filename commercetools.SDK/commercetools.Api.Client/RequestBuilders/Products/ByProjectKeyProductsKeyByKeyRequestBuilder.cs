using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.Products
{
   public class ByProjectKeyProductsKeyByKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string Key { get; }
   
       public ByProjectKeyProductsKeyByKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Key = key;
       }
   
       public ByProjectKeyProductsKeyByKeyGet Get() {
           return new ByProjectKeyProductsKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
       }
       
       public ByProjectKeyProductsKeyByKeyPost Post(commercetools.Api.Models.Products.ProductUpdate productUpdate) {
           return new ByProjectKeyProductsKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, productUpdate);
       }
       
       public ByProjectKeyProductsKeyByKeyDelete Delete() {
           return new ByProjectKeyProductsKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
       }
       
   }
}
