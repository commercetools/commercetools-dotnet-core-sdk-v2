using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.GeneralCategoryRecommendations
{

    public partial class GeneralCategoryRecommendationPagedQueryResponse : IGeneralCategoryRecommendationPagedQueryResponse
    {
        public long Count { get; set; }

        public long Total { get; set; }

        public long Offset { get; set; }

        public List<IGeneralCategoryRecommendation> Results { get; set; }
    }
}
