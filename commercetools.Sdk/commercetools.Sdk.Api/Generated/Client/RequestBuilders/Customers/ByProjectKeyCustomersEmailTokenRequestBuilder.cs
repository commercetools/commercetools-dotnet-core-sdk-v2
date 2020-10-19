using System.IO;
using System.Text.Json;
using commercetools.Base.Serialization;
using commercetools.Base.Client;

namespace commercetools.Api.Client.RequestBuilders.Customers
{
   public class ByProjectKeyCustomersEmailTokenRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyCustomersEmailTokenRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyCustomersEmailTokenPost Post(commercetools.Api.Models.Customers.CustomerCreateEmailToken customerCreateEmailToken) {
           return new ByProjectKeyCustomersEmailTokenPost(ApiHttpClient, SerializerService, ProjectKey, customerCreateEmailToken);
       }
       
   }
}
