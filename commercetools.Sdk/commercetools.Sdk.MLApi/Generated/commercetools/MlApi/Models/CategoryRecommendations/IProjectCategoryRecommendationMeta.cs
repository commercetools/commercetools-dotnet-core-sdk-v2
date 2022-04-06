using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.CategoryRecommendations
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.CategoryRecommendations.ProjectCategoryRecommendationMeta))]
    public partial interface IProjectCategoryRecommendationMeta
    {
        string ProductName { get; set; }

        string ProductImageUrl { get; set; }

        List<string> GeneralCategoryNames { get; set; }
    }
}
