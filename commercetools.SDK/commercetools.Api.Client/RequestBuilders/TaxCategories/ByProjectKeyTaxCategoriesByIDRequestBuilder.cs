using System.IO;
using System.Text.Json;
using commercetools.Api.Serialization;
using commercetools.Api.Client;

namespace commercetools.Api.Client.RequestBuilders.TaxCategories
{
   public class ByProjectKeyTaxCategoriesByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyTaxCategoriesByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyTaxCategoriesByIDGet Get() {
           return new ByProjectKeyTaxCategoriesByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyTaxCategoriesByIDPost Post(commercetools.Api.Models.TaxCategorys.TaxCategoryUpdate taxCategoryUpdate) {
           return new ByProjectKeyTaxCategoriesByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, taxCategoryUpdate);
       }
       
       public ByProjectKeyTaxCategoriesByIDDelete Delete() {
           return new ByProjectKeyTaxCategoriesByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
