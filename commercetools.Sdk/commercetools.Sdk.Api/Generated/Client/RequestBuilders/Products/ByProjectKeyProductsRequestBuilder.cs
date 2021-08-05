using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.Products;

namespace commercetools.Api.Client.RequestBuilders.Products
{
   
   public class ByProjectKeyProductsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyProductsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyProductsGet Get() {
           return new ByProjectKeyProductsGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyProductsPost Post(commercetools.Api.Models.Products.IProductDraft productDraft) {
           return new ByProjectKeyProductsPost(ApiHttpClient, SerializerService, ProjectKey, productDraft);
       }
       
       
       public ByProjectKeyProductsKeyByKeyRequestBuilder WithKey(string key) {
           return new ByProjectKeyProductsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
       }
       
       public ByProjectKeyProductsByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyProductsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
