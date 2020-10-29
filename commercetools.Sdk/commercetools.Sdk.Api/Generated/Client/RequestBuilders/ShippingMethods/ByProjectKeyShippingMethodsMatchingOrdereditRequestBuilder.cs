using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.ShippingMethods
{
   public class ByProjectKeyShippingMethodsMatchingOrdereditRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyShippingMethodsMatchingOrdereditRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyShippingMethodsMatchingOrdereditGet Get() {
           return new ByProjectKeyShippingMethodsMatchingOrdereditGet(ApiHttpClient, ProjectKey);
       }
       
   }
}
