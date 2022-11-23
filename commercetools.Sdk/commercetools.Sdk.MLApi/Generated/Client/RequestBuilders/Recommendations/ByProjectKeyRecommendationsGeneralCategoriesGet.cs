using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Sdk.MLApi.Client.RequestBuilders.Recommendations
{

    public partial class ByProjectKeyRecommendationsGeneralCategoriesGet : ApiMethod<ByProjectKeyRecommendationsGeneralCategoriesGet>, IApiMethod<ByProjectKeyRecommendationsGeneralCategoriesGet, commercetools.Sdk.MLApi.Models.GeneralCategoryRecommendations.IGeneralCategoryRecommendationPagedQueryResponse>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyRecommendationsGeneralCategoriesGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/recommendations/general-categories";
        }

        public List<string> GetProductImageUrl()
        {
            return this.GetQueryParam("productImageUrl");
        }

        public List<string> GetProductName()
        {
            return this.GetQueryParam("productName");
        }

        public List<string> GetLimit()
        {
            return this.GetQueryParam("limit");
        }

        public List<string> GetOffset()
        {
            return this.GetQueryParam("offset");
        }

        public List<string> GetConfidenceMin()
        {
            return this.GetQueryParam("confidenceMin");
        }

        public List<string> GetConfidenceMax()
        {
            return this.GetQueryParam("confidenceMax");
        }

        public ByProjectKeyRecommendationsGeneralCategoriesGet WithProductImageUrl(string productImageUrl)
        {
            return this.AddQueryParam("productImageUrl", productImageUrl);
        }

        public ByProjectKeyRecommendationsGeneralCategoriesGet WithProductName(string productName)
        {
            return this.AddQueryParam("productName", productName);
        }

        public ByProjectKeyRecommendationsGeneralCategoriesGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyRecommendationsGeneralCategoriesGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyRecommendationsGeneralCategoriesGet WithConfidenceMin(decimal confidenceMin)
        {
            return this.AddQueryParam("confidenceMin", confidenceMin.ToString());
        }

        public ByProjectKeyRecommendationsGeneralCategoriesGet WithConfidenceMax(decimal confidenceMax)
        {
            return this.AddQueryParam("confidenceMax", confidenceMax.ToString());
        }


        public async Task<commercetools.Sdk.MLApi.Models.GeneralCategoryRecommendations.IGeneralCategoryRecommendationPagedQueryResponse> ExecuteAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Sdk.MLApi.Models.GeneralCategoryRecommendations.IGeneralCategoryRecommendationPagedQueryResponse>(requestMessage, cancellationToken);
        }

    }
}
