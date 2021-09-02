using commercetools.MLApi.Models.CategoryRecommendations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.CategoryRecommendations
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.CategoryRecommendations.ProjectCategoryRecommendationPagedQueryResponse))]
    public partial interface IProjectCategoryRecommendationPagedQueryResponse
    {
        long Count { get; set; }

        long Total { get; set; }

        long Offset { get; set; }

        List<IProjectCategoryRecommendation> Results { get; set; }

        IProjectCategoryRecommendationMeta Meta { get; set; }
    }
}
