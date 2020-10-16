using System.IO;
using System.Text.Json;
using commercetools.Base.Serialization;
using commercetools.Base.Client;

namespace commercetools.Api.Client.RequestBuilders.Customers
{
   public class ByProjectKeyCustomersPasswordTokenRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyCustomersPasswordTokenRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyCustomersPasswordTokenPost Post(commercetools.Api.Models.Customers.CustomerCreatePasswordResetToken customerCreatePasswordResetToken) {
           return new ByProjectKeyCustomersPasswordTokenPost(ApiHttpClient, SerializerService, ProjectKey, customerCreatePasswordResetToken);
       }
       
   }
}
