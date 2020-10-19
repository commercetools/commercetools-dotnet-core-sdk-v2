using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Products
{
   public partial class ByProjectKeyProductsPost : ApiMethod<ByProjectKeyProductsPost> {

       
       private ISerializerService SerializerService { get; }
       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Post;
       
       private string ProjectKey { get; }
       
       private commercetools.Api.Models.Products.ProductDraft ProductDraft;
   
       public ByProjectKeyProductsPost(IClient apiHttpClient, ISerializerService serializerService, string projectKey, commercetools.Api.Models.Products.ProductDraft productDraft) {
           this.ApiHttpClient = apiHttpClient;
           this.SerializerService = serializerService;
           this.ProjectKey = projectKey;
           this.ProductDraft = productDraft;
           this.RequestUrl = $"/{ProjectKey}/products";
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
   
       public ByProjectKeyProductsPost WithPriceCurrency(string priceCurrency){
           return this.AddQueryParam("priceCurrency", priceCurrency);
       }
       
       public ByProjectKeyProductsPost WithPriceCountry(string priceCountry){
           return this.AddQueryParam("priceCountry", priceCountry);
       }
       
       public ByProjectKeyProductsPost WithPriceCustomerGroup(string priceCustomerGroup){
           return this.AddQueryParam("priceCustomerGroup", priceCustomerGroup);
       }
       
       public ByProjectKeyProductsPost WithPriceChannel(string priceChannel){
           return this.AddQueryParam("priceChannel", priceChannel);
       }
       
       public ByProjectKeyProductsPost WithLocaleProjection(string localeProjection){
           return this.AddQueryParam("localeProjection", localeProjection);
       }
       
       public ByProjectKeyProductsPost WithStoreProjection(string storeProjection){
           return this.AddQueryParam("storeProjection", storeProjection);
       }
       
       public ByProjectKeyProductsPost WithExpand(string expand){
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
              var body = this.SerializerService.Serialize(ProductDraft);
              if(!string.IsNullOrEmpty(body))
              {
                  request.Content = new StringContent(body);
              }
          }
          return request;
       }
   }
}
