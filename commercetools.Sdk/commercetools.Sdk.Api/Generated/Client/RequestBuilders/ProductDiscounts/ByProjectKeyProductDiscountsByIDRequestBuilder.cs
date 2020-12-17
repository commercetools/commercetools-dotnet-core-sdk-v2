using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.ProductDiscounts
{
   public class ByProjectKeyProductDiscountsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyProductDiscountsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyProductDiscountsByIDGet Get() {
           return new ByProjectKeyProductDiscountsByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyProductDiscountsByIDPost Post(commercetools.Api.Models.ProductDiscounts.IProductDiscountUpdate productDiscountUpdate) {
           return new ByProjectKeyProductDiscountsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, productDiscountUpdate);
       }
       
       public ByProjectKeyProductDiscountsByIDDelete Delete() {
           return new ByProjectKeyProductDiscountsByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
