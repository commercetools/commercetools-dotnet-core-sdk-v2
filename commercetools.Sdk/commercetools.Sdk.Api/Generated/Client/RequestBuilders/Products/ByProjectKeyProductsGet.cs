using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.Api.Client.RequestBuilders.Products
{
   public partial class ByProjectKeyProductsGet : ApiMethod<ByProjectKeyProductsGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
   
       public ByProjectKeyProductsGet(IClient apiHttpClient, string projectKey) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
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
       
       public List<string> GetSort() {
           return this.GetQueryParam("sort");
       }
       
       public List<string> GetLimit() {
           return this.GetQueryParam("limit");
       }
       
       public List<string> GetOffset() {
           return this.GetQueryParam("offset");
       }
       
       public List<string> GetWithTotal() {
           return this.GetQueryParam("withTotal");
       }
       
       public List<string> GetWhere() {
           return this.GetQueryParam("where");
       }
   
       public ByProjectKeyProductsGet WithPriceCurrency(string priceCurrency){
           return this.AddQueryParam("priceCurrency", priceCurrency);
       }
       
       public ByProjectKeyProductsGet WithPriceCountry(string priceCountry){
           return this.AddQueryParam("priceCountry", priceCountry);
       }
       
       public ByProjectKeyProductsGet WithPriceCustomerGroup(string priceCustomerGroup){
           return this.AddQueryParam("priceCustomerGroup", priceCustomerGroup);
       }
       
       public ByProjectKeyProductsGet WithPriceChannel(string priceChannel){
           return this.AddQueryParam("priceChannel", priceChannel);
       }
       
       public ByProjectKeyProductsGet WithLocaleProjection(string localeProjection){
           return this.AddQueryParam("localeProjection", localeProjection);
       }
       
       public ByProjectKeyProductsGet WithStoreProjection(string storeProjection){
           return this.AddQueryParam("storeProjection", storeProjection);
       }
       
       public ByProjectKeyProductsGet WithExpand(string expand){
           return this.AddQueryParam("expand", expand);
       }
       
       public ByProjectKeyProductsGet WithSort(string sort){
           return this.AddQueryParam("sort", sort);
       }
       
       public ByProjectKeyProductsGet WithLimit(int limit){
           return this.AddQueryParam("limit", limit.ToString());
       }
       
       public ByProjectKeyProductsGet WithOffset(int offset){
           return this.AddQueryParam("offset", offset.ToString());
       }
       
       public ByProjectKeyProductsGet WithWithTotal(bool withTotal){
           return this.AddQueryParam("withTotal", withTotal.ToString());
       }
       
       public ByProjectKeyProductsGet WithWhere(string where){
           return this.AddQueryParam("where", where);
       }
       
       public ByProjectKeyProductsGet WithPredicateVar(string varName, string predicateVar){
           return this.AddQueryParam($"var.{varName}", predicateVar);
       }

       public async Task<commercetools.Api.Models.Products.IProductPagedQueryResponse> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.Products.IProductPagedQueryResponse>(requestMessage);
       }
   }
}
