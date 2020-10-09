using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Products
{
   public partial class ByProjectKeyProductsByIDImagesPost : ApiMethod<ByProjectKeyProductsByIDImagesPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private string ID { get; }
       
       private Stream Stream;
   
       public ByProjectKeyProductsByIDImagesPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string id, Stream stream) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ID = id;
           this.Stream = stream;
           this.RequestUrl = $"/{ProjectKey}/products/{ID}/images";
       }
   
       public List<string> GetFilename() {
           return this.GetQueryParam("filename");
       }
       
       public List<string> GetVariant() {
           return this.GetQueryParam("variant");
       }
       
       public List<string> GetSku() {
           return this.GetQueryParam("sku");
       }
       
       public List<string> GetStaged() {
           return this.GetQueryParam("staged");
       }
   
       public ByProjectKeyProductsByIDImagesPost WithFilename(string filename){
           return this.AddQueryParam("filename", filename);
       }
       
       public ByProjectKeyProductsByIDImagesPost WithVariant(double variant){
           return this.AddQueryParam("variant", variant.ToString());
       }
       
       public ByProjectKeyProductsByIDImagesPost WithSku(string sku){
           return this.AddQueryParam("sku", sku);
       }
       
       public ByProjectKeyProductsByIDImagesPost WithStaged(bool staged){
           return this.AddQueryParam("staged", staged.ToString());
       }

       public async Task<commercetools.Api.Models.Products.Product> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Products.Product>(requestMessage);
       }
       
       public override HttpRequestMessage Build()
       {
          var request = base.Build();
          if (SerializerService != null)
          {
              var body = this.SerializerService.Serialize(Stream);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
