using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.MLApi.Models.GeneralCategoryRecommendations
{

    public partial class GeneralCategoryRecommendationPagedQueryResponse : IGeneralCategoryRecommendationPagedQueryResponse
    {
        public long Count { get; set; }

        public long Total { get; set; }

        public long Offset { get; set; }

        public IList<IGeneralCategoryRecommendation> Results { get; set; }
        public IEnumerable<IGeneralCategoryRecommendation> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
