using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.Carts;

namespace commercetools.Api.Client.RequestBuilders.Carts
{
   public class ByProjectKeyCartsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyCartsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyCartsGet Get() {
           return new ByProjectKeyCartsGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyCartsPost Post(commercetools.Api.Models.Carts.CartDraft cartDraft) {
           return new ByProjectKeyCartsPost(ApiHttpClient, SerializerService, ProjectKey, cartDraft);
       }
       
       public ByProjectKeyCartsReplicateRequestBuilder Replicate() {
           return new ByProjectKeyCartsReplicateRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyCartsCustomerIdByCustomerIdRequestBuilder WithCustomerId(string customerId) {
           return new ByProjectKeyCartsCustomerIdByCustomerIdRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, customerId);
       }
       public ByProjectKeyCartsByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyCartsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
