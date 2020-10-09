using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;
using commercetools.Api.Client.RequestBuilders.ApiClients;

namespace commercetools.Api.Client.RequestBuilders.ApiClients
{
   public class ByProjectKeyApiClientsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyApiClientsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyApiClientsGet Get() {
           return new ByProjectKeyApiClientsGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyApiClientsPost Post(commercetools.Api.Models.ApiClients.ApiClientDraft apiClientDraft) {
           return new ByProjectKeyApiClientsPost(ApiHttpClient, SerializerService, ProjectKey, apiClientDraft);
       }
       
       public ByProjectKeyApiClientsByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyApiClientsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
