using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Customers
{
   
   public class ByProjectKeyCustomersEmailConfirmRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyCustomersEmailConfirmRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyCustomersEmailConfirmPost Post(commercetools.Api.Models.Customers.ICustomerEmailVerify customerEmailVerify) {
           return new ByProjectKeyCustomersEmailConfirmPost(ApiHttpClient, SerializerService, ProjectKey, customerEmailVerify);
       }
       
   }
}
