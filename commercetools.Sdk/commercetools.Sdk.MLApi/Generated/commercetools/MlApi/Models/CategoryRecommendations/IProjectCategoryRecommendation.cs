using commercetools.MLApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.CategoryRecommendations
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.CategoryRecommendations.ProjectCategoryRecommendation))]
    public partial interface IProjectCategoryRecommendation 
    {
        ICategoryReference Category { get; set;}
        
        double Confidence { get; set;}
        
        string Path { get; set;}
    }
}
