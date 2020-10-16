using System.IO;
using System.Text.Json;
using commercetools.Base.Serialization;
using commercetools.Base.Client;

namespace commercetools.Api.Client.RequestBuilders.Reviews
{
   public class ByProjectKeyReviewsByIDRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
       
       private string ID { get; }
   
       public ByProjectKeyReviewsByIDRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
       }
   
       public ByProjectKeyReviewsByIDGet Get() {
           return new ByProjectKeyReviewsByIDGet(ApiHttpClient, ProjectKey, ID);
       }
       
       public ByProjectKeyReviewsByIDPost Post(commercetools.Api.Models.Reviews.ReviewUpdate reviewUpdate) {
           return new ByProjectKeyReviewsByIDPost(ApiHttpClient, SerializerService, ProjectKey, ID, reviewUpdate);
       }
       
       public ByProjectKeyReviewsByIDDelete Delete() {
           return new ByProjectKeyReviewsByIDDelete(ApiHttpClient, ProjectKey, ID);
       }
       
   }
}
