using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.MLApi.Models.CategoryRecommendations
{

    public partial class ProjectCategoryRecommendationMeta : IProjectCategoryRecommendationMeta
    {
        public string ProductName { get; set; }

        public string ProductImageUrl { get; set; }

        public IList<string> GeneralCategoryNames { get; set; }
        public IEnumerable<string> GeneralCategoryNamesEnumerable { set => GeneralCategoryNames = value.ToList(); }

    }
}
