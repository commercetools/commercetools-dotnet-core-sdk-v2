using System.IO;
using System.Text.Json;
using commercetools.Base.Serialization;
using commercetools.Api.Client.RequestBuilders.ShippingMethods;

using commercetools.Base.Client;

namespace commercetools.Api.Client.RequestBuilders.ShippingMethods
{
   public class ByProjectKeyShippingMethodsRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyShippingMethodsRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyShippingMethodsGet Get() {
           return new ByProjectKeyShippingMethodsGet(ApiHttpClient, ProjectKey);
       }
       
       public ByProjectKeyShippingMethodsPost Post(commercetools.Api.Models.ShippingMethods.ShippingMethodDraft shippingMethodDraft) {
           return new ByProjectKeyShippingMethodsPost(ApiHttpClient, SerializerService, ProjectKey, shippingMethodDraft);
       }
       
       public ByProjectKeyShippingMethodsKeyByKeyRequestBuilder WithKey(string key) {
           return new ByProjectKeyShippingMethodsKeyByKeyRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, key);
       }
       public ByProjectKeyShippingMethodsMatchingCartRequestBuilder MatchingCart() {
           return new ByProjectKeyShippingMethodsMatchingCartRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyShippingMethodsMatchingOrdereditRequestBuilder MatchingOrderedit() {
           return new ByProjectKeyShippingMethodsMatchingOrdereditRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyShippingMethodsMatchingLocationRequestBuilder MatchingLocation() {
           return new ByProjectKeyShippingMethodsMatchingLocationRequestBuilder(ApiHttpClient, SerializerService, ProjectKey);
       }
       public ByProjectKeyShippingMethodsByIDRequestBuilder WithId(string ID) {
           return new ByProjectKeyShippingMethodsByIDRequestBuilder(ApiHttpClient, SerializerService, ProjectKey, ID);
       }
   }
}
