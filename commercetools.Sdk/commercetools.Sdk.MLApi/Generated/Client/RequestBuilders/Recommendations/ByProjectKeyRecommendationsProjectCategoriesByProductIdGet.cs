using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.MLApi.Client.RequestBuilders.Recommendations
{
   public partial class ByProjectKeyRecommendationsProjectCategoriesByProductIdGet : ApiMethod<ByProjectKeyRecommendationsProjectCategoriesByProductIdGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string ProductId { get; }
       
   
       public ByProjectKeyRecommendationsProjectCategoriesByProductIdGet(IClient apiHttpClient, string projectKey, string productId) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.ProductId = productId;
           this.RequestUrl = $"/{ProjectKey}/recommendations/project-categories/{ProductId}";
       }
   
       public List<string> GetLimit() {
           return this.GetQueryParam("limit");
       }
       
       public List<string> GetOffset() {
           return this.GetQueryParam("offset");
       }
       
       public List<string> GetStaged() {
           return this.GetQueryParam("staged");
       }
       
       public List<string> GetConfidenceMin() {
           return this.GetQueryParam("confidenceMin");
       }
       
       public List<string> GetConfidenceMax() {
           return this.GetQueryParam("confidenceMax");
       }
   
       public ByProjectKeyRecommendationsProjectCategoriesByProductIdGet WithLimit(int limit){
           return this.AddQueryParam("limit", limit.ToString());
       }
       
       public ByProjectKeyRecommendationsProjectCategoriesByProductIdGet WithOffset(int offset){
           return this.AddQueryParam("offset", offset.ToString());
       }
       
       public ByProjectKeyRecommendationsProjectCategoriesByProductIdGet WithStaged(bool staged){
           return this.AddQueryParam("staged", staged.ToString());
       }
       
       public ByProjectKeyRecommendationsProjectCategoriesByProductIdGet WithConfidenceMin(double confidenceMin){
           return this.AddQueryParam("confidenceMin", confidenceMin.ToString());
       }
       
       public ByProjectKeyRecommendationsProjectCategoriesByProductIdGet WithConfidenceMax(double confidenceMax){
           return this.AddQueryParam("confidenceMax", confidenceMax.ToString());
       }

       public async Task<commercetools.MLApi.Models.CategoryRecommendations.ProjectCategoryRecommendationPagedQueryResponse> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.MLApi.Models.CategoryRecommendations.ProjectCategoryRecommendationPagedQueryResponse>(requestMessage);
       }
   }
}
