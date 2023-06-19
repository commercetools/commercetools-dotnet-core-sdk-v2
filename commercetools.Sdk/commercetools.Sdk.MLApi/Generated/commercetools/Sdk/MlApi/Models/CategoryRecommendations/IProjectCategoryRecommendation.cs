using commercetools.Sdk.MLApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Models.CategoryRecommendations
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.CategoryRecommendations.ProjectCategoryRecommendation))]
    public partial interface IProjectCategoryRecommendation
    {
        ICategoryReference Category { get; set; }

        decimal Confidence { get; set; }

        string Path { get; set; }

    }
}
