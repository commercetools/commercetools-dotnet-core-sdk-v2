using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using commercetools.Base.Client;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Client.RequestBuilders.Recommendations
{

    public partial class ByProjectKeyRecommendationsProjectCategoriesByProductIdGet : ApiMethod<ByProjectKeyRecommendationsProjectCategoriesByProductIdGet>, IApiMethod<ByProjectKeyRecommendationsProjectCategoriesByProductIdGet, commercetools.Sdk.MLApi.Models.CategoryRecommendations.IProjectCategoryRecommendationPagedQueryResponse>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }

        private string ProductId { get; }


        public ByProjectKeyRecommendationsProjectCategoriesByProductIdGet(IClient apiHttpClient, string projectKey, string productId)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ProductId = productId;
            this.RequestUrl = $"/{ProjectKey}/recommendations/project-categories/{ProductId}";
        }

        public List<string> GetLimit()
        {
            return this.GetQueryParam("limit");
        }

        public List<string> GetOffset()
        {
            return this.GetQueryParam("offset");
        }

        public List<string> GetStaged()
        {
            return this.GetQueryParam("staged");
        }

        public List<string> GetConfidenceMin()
        {
            return this.GetQueryParam("confidenceMin");
        }

        public List<string> GetConfidenceMax()
        {
            return this.GetQueryParam("confidenceMax");
        }

        public ByProjectKeyRecommendationsProjectCategoriesByProductIdGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyRecommendationsProjectCategoriesByProductIdGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyRecommendationsProjectCategoriesByProductIdGet WithStaged(bool staged)
        {
            return this.AddQueryParam("staged", staged.ToString());
        }

        public ByProjectKeyRecommendationsProjectCategoriesByProductIdGet WithConfidenceMin(decimal confidenceMin)
        {
            return this.AddQueryParam("confidenceMin", confidenceMin.ToString());
        }

        public ByProjectKeyRecommendationsProjectCategoriesByProductIdGet WithConfidenceMax(decimal confidenceMax)
        {
            return this.AddQueryParam("confidenceMax", confidenceMax.ToString());
        }


        public async Task<commercetools.Sdk.MLApi.Models.CategoryRecommendations.IProjectCategoryRecommendationPagedQueryResponse> ExecuteAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.MLApi.Models.CategoryRecommendations.IProjectCategoryRecommendationPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<string> ExecuteAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsJsonAsync(requestMessage, cancellationToken);
        }

        public async Task<IApiResponse<commercetools.Sdk.MLApi.Models.CategoryRecommendations.IProjectCategoryRecommendationPagedQueryResponse>> SendAsync(CancellationToken cancellationToken = default)
        {

            var requestMessage = Build();
            return await ApiHttpClient.SendAsync<commercetools.Sdk.MLApi.Models.CategoryRecommendations.IProjectCategoryRecommendationPagedQueryResponse>(requestMessage, cancellationToken);

        }

        public async Task<IApiResponse<string>> SendAsJsonAsync(CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.SendAsJsonAsync(requestMessage, cancellationToken);
        }

    }
}
