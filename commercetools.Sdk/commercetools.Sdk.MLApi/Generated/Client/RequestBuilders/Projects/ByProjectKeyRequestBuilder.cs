using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.MLApi.Client.RequestBuilders.ImageSearch;
using commercetools.MLApi.Client.RequestBuilders.Recommendations;
using commercetools.MLApi.Client.RequestBuilders.MissingData;
using commercetools.MLApi.Client.RequestBuilders.Similarities;

namespace commercetools.MLApi.Client.RequestBuilders.Projects
{
   public class ByProjectKeyRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       
       public ByProjectKeyImageSearchRequestBuilder ImageSearch() {
           return new ByProjectKeyImageSearchRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyRecommendationsRequestBuilder Recommendations() {
           return new ByProjectKeyRecommendationsRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyMissingDataRequestBuilder MissingData() {
           return new ByProjectKeyMissingDataRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeySimilaritiesRequestBuilder Similarities() {
           return new ByProjectKeySimilaritiesRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
   }
}
