using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Ml.Client.RequestBuilders.Recommendations;

namespace commercetools.Ml.Client.RequestBuilders.Recommendations
{
   public class ByProjectKeyRecommendationsProjectCategoriesRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyRecommendationsProjectCategoriesRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       
       public ByProjectKeyRecommendationsProjectCategoriesByProductIdRequestBuilder WithProductId(string productId) {
           return new ByProjectKeyRecommendationsProjectCategoriesByProductIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, productId);
       }
   }
}
