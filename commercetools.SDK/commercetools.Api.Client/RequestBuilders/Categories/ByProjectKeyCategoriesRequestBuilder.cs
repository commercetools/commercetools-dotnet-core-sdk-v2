using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;
using commercetools.Api.Client.RequestBuilders.Categories;

namespace commercetools.Api.Client.RequestBuilders.Categories
{
   public class ByProjectKeyCategoriesRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyCategoriesRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyCategoriesGet Get() {
           return new ByProjectKeyCategoriesGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyCategoriesPost Post(commercetools.Api.Models.Categories.CategoryDraft categoryDraft) {
           return new ByProjectKeyCategoriesPost(ApiHttpClient, SerializerService, ProjectKey, categoryDraft);
       }
       
       public ByProjectKeyCategoriesKeyByKeyRequestBuilder WithKey(string key) {
           return new ByProjectKeyCategoriesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
       }
       public ByProjectKeyCategoriesByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyCategoriesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
