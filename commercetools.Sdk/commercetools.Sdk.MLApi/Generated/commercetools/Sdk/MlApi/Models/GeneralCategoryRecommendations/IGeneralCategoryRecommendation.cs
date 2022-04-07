using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.GeneralCategoryRecommendations
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.GeneralCategoryRecommendations.GeneralCategoryRecommendation))]
    public partial interface IGeneralCategoryRecommendation
    {
        string CategoryName { get; set; }

        double Confidence { get; set; }
    }
}
