using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.Customers
{
   public class ByProjectKeyCustomersPasswordResetRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyCustomersPasswordResetRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyCustomersPasswordResetPost Post(commercetools.Api.Models.Customers.CustomerResetPassword customerResetPassword) {
           return new ByProjectKeyCustomersPasswordResetPost(ApiHttpClient, SerializerService, ProjectKey, customerResetPassword);
       }
       
   }
}
