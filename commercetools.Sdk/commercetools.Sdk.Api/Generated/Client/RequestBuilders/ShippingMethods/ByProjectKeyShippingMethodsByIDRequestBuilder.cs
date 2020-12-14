using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.ShippingMethods
{
   public class ByProjectKeyShippingMethodsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyShippingMethodsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyShippingMethodsByIDGet Get() {
           return new ByProjectKeyShippingMethodsByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyShippingMethodsByIDPost Post(commercetools.Api.Models.ShippingMethods.IShippingMethodUpdate shippingMethodUpdate) {
           return new ByProjectKeyShippingMethodsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, shippingMethodUpdate);
       }
       
       public ByProjectKeyShippingMethodsByIDDelete Delete() {
           return new ByProjectKeyShippingMethodsByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
