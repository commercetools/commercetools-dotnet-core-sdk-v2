using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.GeneralCategoryRecommendations
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.GeneralCategoryRecommendations.GeneralCategoryRecommendationPagedQueryResponse))]
    public partial interface IGeneralCategoryRecommendationPagedQueryResponse
    {
        long Count { get; set; }

        long Total { get; set; }

        long Offset { get; set; }

        List<IGeneralCategoryRecommendation> Results { get; set; }
    }
}
