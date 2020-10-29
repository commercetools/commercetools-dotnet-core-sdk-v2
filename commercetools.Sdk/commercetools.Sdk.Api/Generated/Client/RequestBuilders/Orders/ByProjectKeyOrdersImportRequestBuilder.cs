using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Orders
{
   public class ByProjectKeyOrdersImportRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyOrdersImportRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyOrdersImportPost Post(commercetools.Api.Models.Orders.OrderImportDraft orderImportDraft) {
           return new ByProjectKeyOrdersImportPost(ApiHttpClient, SerializerService, ProjectKey, orderImportDraft);
       }
       
   }
}
