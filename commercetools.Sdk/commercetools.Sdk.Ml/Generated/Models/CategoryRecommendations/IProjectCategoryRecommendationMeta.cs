using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.CategoryRecommendations
{
    [DeserializeAs(typeof(commercetools.Ml.Models.CategoryRecommendations.ProjectCategoryRecommendationMeta))]
    public partial interface IProjectCategoryRecommendationMeta 
    {
        string ProductName { get; set;}
        
        string ProductImageUrl { get; set;}
        
        List<string> GeneralCategoryNames { get; set;}
    }
}
