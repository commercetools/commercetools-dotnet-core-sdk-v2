using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.MLApi.Client.RequestBuilders.Recommendations
{
   public class ByProjectKeyRecommendationsGeneralCategoriesRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyRecommendationsGeneralCategoriesRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyRecommendationsGeneralCategoriesGet Get() {
           return new ByProjectKeyRecommendationsGeneralCategoriesGet(ApiHttpClient, ProjectKey);
       }
       
   }
}
