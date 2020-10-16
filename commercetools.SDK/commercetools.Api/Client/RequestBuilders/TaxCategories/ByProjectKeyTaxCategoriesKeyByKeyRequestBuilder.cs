using System.IO;
using System.Text.Json;
using commercetools.Base.Serialization;
using commercetools.Base.Client;

namespace commercetools.Api.Client.RequestBuilders.TaxCategories
{
   public class ByProjectKeyTaxCategoriesKeyByKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string Key { get; }
   
       public ByProjectKeyTaxCategoriesKeyByKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Key = key;
       }
   
       public ByProjectKeyTaxCategoriesKeyByKeyGet Get() {
           return new ByProjectKeyTaxCategoriesKeyByKeyGet(ApiHttpClient, ProjectKey, Key);
       }
       
       public ByProjectKeyTaxCategoriesKeyByKeyPost Post(commercetools.Api.Models.TaxCategories.TaxCategoryUpdate taxCategoryUpdate) {
           return new ByProjectKeyTaxCategoriesKeyByKeyPost(ApiHttpClient, SerializerService, ProjectKey, Key, taxCategoryUpdate);
       }
       
       public ByProjectKeyTaxCategoriesKeyByKeyDelete Delete() {
           return new ByProjectKeyTaxCategoriesKeyByKeyDelete(ApiHttpClient, ProjectKey, Key);
       }
       
   }
}
