using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Api.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Products
{
   public partial class ByProjectKeyProductsKeyByKeyPost : ApiMethod<ByProjectKeyProductsKeyByKeyPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private string Key { get; }
       
       private commercetools.Api.Models.Products.ProductUpdate ProductUpdate;
   
       public ByProjectKeyProductsKeyByKeyPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, string key, commercetools.Api.Models.Products.ProductUpdate productUpdate) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.Key = key;
           this.ProductUpdate = productUpdate;
           this.RequestUrl = $"/{ProjectKey}/products/key={Key}";
       }
   
       public List<string> GetPriceCurrency() {
           return this.GetQueryParam("priceCurrency");
       }
       
       public List<string> GetPriceCountry() {
           return this.GetQueryParam("priceCountry");
       }
       
       public List<string> GetPriceCustomerGroup() {
           return this.GetQueryParam("priceCustomerGroup");
       }
       
       public List<string> GetPriceChannel() {
           return this.GetQueryParam("priceChannel");
       }
       
       public List<string> GetLocaleProjection() {
           return this.GetQueryParam("localeProjection");
       }
       
       public List<string> GetStoreProjection() {
           return this.GetQueryParam("storeProjection");
       }
       
       public List<string> GetExpand() {
           return this.GetQueryParam("expand");
       }
   
       public ByProjectKeyProductsKeyByKeyPost WithPriceCurrency(string priceCurrency){
           return this.AddQueryParam("priceCurrency", priceCurrency);
       }
       
       public ByProjectKeyProductsKeyByKeyPost WithPriceCountry(string priceCountry){
           return this.AddQueryParam("priceCountry", priceCountry);
       }
       
       public ByProjectKeyProductsKeyByKeyPost WithPriceCustomerGroup(string priceCustomerGroup){
           return this.AddQueryParam("priceCustomerGroup", priceCustomerGroup);
       }
       
       public ByProjectKeyProductsKeyByKeyPost WithPriceChannel(string priceChannel){
           return this.AddQueryParam("priceChannel", priceChannel);
       }
       
       public ByProjectKeyProductsKeyByKeyPost WithLocaleProjection(string localeProjection){
           return this.AddQueryParam("localeProjection", localeProjection);
       }
       
       public ByProjectKeyProductsKeyByKeyPost WithStoreProjection(string storeProjection){
           return this.AddQueryParam("storeProjection", storeProjection);
       }
       
       public ByProjectKeyProductsKeyByKeyPost WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
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
              var body = this.SerializerService.Serialize(ProductUpdate);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
