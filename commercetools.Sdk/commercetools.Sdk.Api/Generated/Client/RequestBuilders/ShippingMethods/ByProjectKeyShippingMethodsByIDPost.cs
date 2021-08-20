using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.ShippingMethods
{
   public partial class ByProjectKeyShippingMethodsByIDPost : ApiMethod<ByProjectKeyShippingMethodsByIDPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private string ID { get; }
       
       private commercetools.Api.Models.ShippingMethods.IShippingMethodUpdate ShippingMethodUpdate;
   
       public ByProjectKeyShippingMethodsByIDPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, commercetools.Api.Models.ShippingMethods.IShippingMethodUpdate shippingMethodUpdate) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
           this.ShippingMethodUpdate = shippingMethodUpdate;
           this.RequestUrl = $"/{ProjectKey}/shipping-methods/{ID}";
       }
   
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyShippingMethodsByIDPost WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }
       

       public async Task<commercetools.Api.Models.ShippingMethods.IShippingMethod> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.ShippingMethods.IShippingMethod>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(ShippingMethodUpdate);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body, Encoding.UTF8, "application/json");
              }
          }
          return request;
       }
   }
}
