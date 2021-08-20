using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.CartDiscounts
{
   
   public class ByProjectKeyCartDiscountsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyCartDiscountsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyCartDiscountsByIDGet Get() {
           return new ByProjectKeyCartDiscountsByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyCartDiscountsByIDPost Post(commercetools.Api.Models.CartDiscounts.ICartDiscountUpdate cartDiscountUpdate) {
           return new ByProjectKeyCartDiscountsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, cartDiscountUpdate);
       }
       
       public ByProjectKeyCartDiscountsByIDDelete Delete() {
           return new ByProjectKeyCartDiscountsByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
