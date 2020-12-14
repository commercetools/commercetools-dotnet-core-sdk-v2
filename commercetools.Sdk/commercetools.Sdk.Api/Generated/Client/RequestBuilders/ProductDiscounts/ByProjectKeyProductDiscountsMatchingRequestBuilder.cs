using System.IO;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.ProductDiscounts
{
   public class ByProjectKeyProductDiscountsMatchingRequestBuilder {

       private IClient ApiHttpClient { get; }
       
       private ISerializerService SerializerService { get; }
       
       private string ProjectKey { get; }
   
       public ByProjectKeyProductDiscountsMatchingRequestBuilder (IClient apiHttpClient, ISerializerService serializerService, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
       }
   
       public ByProjectKeyProductDiscountsMatchingPost Post(commercetools.Api.Models.ProductDiscounts.IProductDiscountMatchQuery productDiscountMatchQuery) {
           return new ByProjectKeyProductDiscountsMatchingPost(ApiHttpClient, SerializerService, ProjectKey, productDiscountMatchQuery);
       }
       
   }
}
