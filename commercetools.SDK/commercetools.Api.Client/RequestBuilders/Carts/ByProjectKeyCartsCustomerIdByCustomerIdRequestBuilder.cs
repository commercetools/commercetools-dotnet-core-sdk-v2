using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.Carts
{
   public class ByProjectKeyCartsCustomerIdByCustomerIdRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string CustomerId { get; }
   
       public ByProjectKeyCartsCustomerIdByCustomerIdRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string customerId) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.CustomerId = customerId;
       }
   
       public ByProjectKeyCartsCustomerIdByCustomerIdGet Get() {
           return new ByProjectKeyCartsCustomerIdByCustomerIdGet(ApiHttpClient, ProjectKey, CustomerId);
       }
       
   }
}
