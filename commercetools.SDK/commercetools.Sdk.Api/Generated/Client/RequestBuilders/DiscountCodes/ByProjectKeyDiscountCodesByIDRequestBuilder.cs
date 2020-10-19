using System.IO;
using System.Text.Json;
using commercetools.Base.Serialization;
using commercetools.Base.Client;

namespace commercetools.Api.Client.RequestBuilders.DiscountCodes
{
   public class ByProjectKeyDiscountCodesByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyDiscountCodesByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyDiscountCodesByIDGet Get() {
           return new ByProjectKeyDiscountCodesByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyDiscountCodesByIDPost Post(commercetools.Api.Models.DiscountCodes.DiscountCodeUpdate discountCodeUpdate) {
           return new ByProjectKeyDiscountCodesByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, discountCodeUpdate);
       }
       
       public ByProjectKeyDiscountCodesByIDDelete Delete() {
           return new ByProjectKeyDiscountCodesByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
