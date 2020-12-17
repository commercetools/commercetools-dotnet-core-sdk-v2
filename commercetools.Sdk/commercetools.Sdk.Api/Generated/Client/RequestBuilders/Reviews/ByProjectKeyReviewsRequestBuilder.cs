using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.Reviews;

namespace commercetools.Api.Client.RequestBuilders.Reviews
{
   public class ByProjectKeyReviewsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyReviewsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyReviewsGet Get() {
           return new ByProjectKeyReviewsGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyReviewsPost Post(commercetools.Api.Models.Reviews.IReviewDraft reviewDraft) {
           return new ByProjectKeyReviewsPost(ApiHttpClient, SerializerService, ProjectKey, reviewDraft);
       }
       
       public ByProjectKeyReviewsKeyByKeyRequestBuilder WithKey(string key) {
           return new ByProjectKeyReviewsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
       }
       public ByProjectKeyReviewsByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyReviewsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
