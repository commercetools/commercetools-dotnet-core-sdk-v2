using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Models.GeneralCategoryRecommendations
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.GeneralCategoryRecommendations.GeneralCategoryRecommendation))]
    public partial interface IGeneralCategoryRecommendation
    {
        string CategoryName { get; set; }

        decimal Confidence { get; set; }

    }
}
