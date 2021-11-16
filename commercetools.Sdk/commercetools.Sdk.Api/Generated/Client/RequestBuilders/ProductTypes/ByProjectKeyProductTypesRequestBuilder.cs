using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.ProductTypes
{

    public class ByProjectKeyProductTypesRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyProductTypesRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyProductTypesGet Get() {
           return new ByProjectKeyProductTypesGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyProductTypesPost Post(commercetools.Api.Models.ProductTypes.IProductTypeDraft productTypeDraft) {
           return new ByProjectKeyProductTypesPost(ApiHttpClient, SerializerService, ProjectKey, productTypeDraft);
       }
       
       
       public ByProjectKeyProductTypesKeyByKeyRequestBuilder WithKey(string key) {
           return new ByProjectKeyProductTypesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
       }
       
       public ByProjectKeyProductTypesByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyProductTypesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
