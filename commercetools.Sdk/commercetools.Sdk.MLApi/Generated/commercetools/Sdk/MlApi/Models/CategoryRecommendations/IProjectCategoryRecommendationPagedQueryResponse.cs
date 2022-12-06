using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.CategoryRecommendations
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.CategoryRecommendations.ProjectCategoryRecommendationPagedQueryResponse))]
    public partial interface IProjectCategoryRecommendationPagedQueryResponse
    {
        long Count { get; set; }

        long Total { get; set; }

        long Offset { get; set; }

        IList<IProjectCategoryRecommendation> Results { get; set; }
        IEnumerable<IProjectCategoryRecommendation> ResultsEnumerable { set => Results = value.ToList(); }


        IProjectCategoryRecommendationMeta Meta { get; set; }

    }
}
