using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.CategoryRecommendations
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.CategoryRecommendations.ProjectCategoryRecommendationMeta))]
    public partial interface IProjectCategoryRecommendationMeta
    {
        string ProductName { get; set; }

        string ProductImageUrl { get; set; }

        IList<string> GeneralCategoryNames { get; set; }
        IEnumerable<string> GeneralCategoryNamesEnumerable { set => GeneralCategoryNames = value.ToList(); }


    }
}
