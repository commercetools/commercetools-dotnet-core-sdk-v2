using commercetools.MLApi.Models.Common;


namespace commercetools.MLApi.Models.CategoryRecommendations
{
    public partial class ProjectCategoryRecommendation : IProjectCategoryRecommendation
    {
        public ICategoryReference Category { get; set; }

        public double Confidence { get; set; }

        public string Path { get; set; }
    }
}
