using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.CategoryRecommendations
{
    public partial class ProjectCategoryRecommendationMeta : IProjectCategoryRecommendationMeta
    {
        public string ProductName { get; set; }

        public string ProductImageUrl { get; set; }

        public List<string> GeneralCategoryNames { get; set; }
    }
}
