using commercetools.Sdk.MLApi.Models.Common;


namespace commercetools.Sdk.MLApi.Models.CategoryRecommendations
{
    public partial class ProjectCategoryRecommendation : IProjectCategoryRecommendation
    {
        public ICategoryReference Category { get; set; }

        public double Confidence { get; set; }

        public string Path { get; set; }
    }
}
