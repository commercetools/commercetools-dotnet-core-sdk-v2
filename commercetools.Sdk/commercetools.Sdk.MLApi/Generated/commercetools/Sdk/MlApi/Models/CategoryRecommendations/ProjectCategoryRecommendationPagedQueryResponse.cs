using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.MLApi.Models.CategoryRecommendations
{

    public partial class ProjectCategoryRecommendationPagedQueryResponse : IProjectCategoryRecommendationPagedQueryResponse
    {
        public long Count { get; set; }

        public long Total { get; set; }

        public long Offset { get; set; }

        public IList<IProjectCategoryRecommendation> Results { get; set; }
        public IEnumerable<IProjectCategoryRecommendation> ResultsEnumerable { set => Results = value.ToList(); }


        public IProjectCategoryRecommendationMeta Meta { get; set; }
    }
}
