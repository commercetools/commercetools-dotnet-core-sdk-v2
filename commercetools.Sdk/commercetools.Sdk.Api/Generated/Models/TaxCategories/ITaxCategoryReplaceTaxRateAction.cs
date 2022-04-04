using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryReplaceTaxRateAction))]
    public partial interface ITaxCategoryReplaceTaxRateAction : ITaxCategoryUpdateAction
    {
        string TaxRateId { get; set; }

        ITaxRateDraft TaxRate { get; set; }
    }
}
