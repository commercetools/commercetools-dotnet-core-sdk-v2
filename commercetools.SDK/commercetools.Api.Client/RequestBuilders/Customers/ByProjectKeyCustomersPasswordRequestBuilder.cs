using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.Customers
{
   public class ByProjectKeyCustomersPasswordRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyCustomersPasswordRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyCustomersPasswordPost Post(commercetools.Api.Models.Customers.CustomerChangePassword customerChangePassword) {
           return new ByProjectKeyCustomersPasswordPost(ApiHttpClient, SerializerService, ProjectKey, customerChangePassword);
       }
       
   }
}
