using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.CategoryRecommendations
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.CategoryRecommendations.ProjectCategoryRecommendationPagedQueryResponse))]
    public partial interface IProjectCategoryRecommendationPagedQueryResponse
    {
        long Count { get; set; }

        long Total { get; set; }

        long Offset { get; set; }

        List<IProjectCategoryRecommendation> Results { get; set; }

        IProjectCategoryRecommendationMeta Meta { get; set; }
    }
}
