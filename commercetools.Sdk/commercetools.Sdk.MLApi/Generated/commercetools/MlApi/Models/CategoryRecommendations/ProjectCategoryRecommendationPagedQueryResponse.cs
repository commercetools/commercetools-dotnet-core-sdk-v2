using System.Collections.Generic;


namespace commercetools.MLApi.Models.CategoryRecommendations
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
