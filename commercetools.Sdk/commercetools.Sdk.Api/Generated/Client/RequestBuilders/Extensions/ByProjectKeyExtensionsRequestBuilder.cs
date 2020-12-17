using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.Extensions;

namespace commercetools.Api.Client.RequestBuilders.Extensions
{
   public class ByProjectKeyExtensionsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyExtensionsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyExtensionsGet Get() {
           return new ByProjectKeyExtensionsGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyExtensionsPost Post(commercetools.Api.Models.Extensions.IExtensionDraft extensionDraft) {
           return new ByProjectKeyExtensionsPost(ApiHttpClient, SerializerService, ProjectKey, extensionDraft);
       }
       
       public ByProjectKeyExtensionsKeyByKeyRequestBuilder WithKey(string key) {
           return new ByProjectKeyExtensionsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
       }
       public ByProjectKeyExtensionsByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyExtensionsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
