using commercetools.Ml.Models.CategoryRecommendations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.CategoryRecommendations
{
    public partial class ProjectCategoryRecommendationPagedQueryResponse : IProjectCategoryRecommendationPagedQueryResponse
    {
        public long Count { get; set;}
        
        public long Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<IProjectCategoryRecommendation> Results { get; set;}
        
        public IProjectCategoryRecommendationMeta Meta { get; set;}
    }
}
