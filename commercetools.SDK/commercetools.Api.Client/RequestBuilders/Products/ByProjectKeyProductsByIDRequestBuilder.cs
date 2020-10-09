using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;
using commercetools.Api.Client.RequestBuilders.Products;

namespace commercetools.Api.Client.RequestBuilders.Products
{
   public class ByProjectKeyProductsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyProductsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyProductsByIDGet Get() {
           return new ByProjectKeyProductsByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyProductsByIDPost Post(commercetools.Api.Models.Products.ProductUpdate productUpdate) {
           return new ByProjectKeyProductsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, productUpdate);
       }
       
       public ByProjectKeyProductsByIDDelete Delete() {
           return new ByProjectKeyProductsByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyProductsByIDImagesRequestBuilder Images() {
           return new ByProjectKeyProductsByIDImagesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
