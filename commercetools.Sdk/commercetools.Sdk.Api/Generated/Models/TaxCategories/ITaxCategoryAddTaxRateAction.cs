using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryAddTaxRateAction))]
    public partial interface ITaxCategoryAddTaxRateAction : ITaxCategoryUpdateAction
    {
        ITaxRateDraft TaxRate { get; set; }

    }
}
