using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;
using commercetools.Api.Client.RequestBuilders.TaxCategories;

namespace commercetools.Api.Client.RequestBuilders.TaxCategories
{
   public class ByProjectKeyTaxCategoriesRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyTaxCategoriesRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyTaxCategoriesGet Get() {
           return new ByProjectKeyTaxCategoriesGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyTaxCategoriesPost Post(commercetools.Api.Models.TaxCategorys.TaxCategoryDraft taxCategoryDraft) {
           return new ByProjectKeyTaxCategoriesPost(ApiHttpClient, SerializerService, ProjectKey, taxCategoryDraft);
       }
       
       public ByProjectKeyTaxCategoriesKeyByKeyRequestBuilder WithKey(string key) {
           return new ByProjectKeyTaxCategoriesKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
       }
       public ByProjectKeyTaxCategoriesByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyTaxCategoriesByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
