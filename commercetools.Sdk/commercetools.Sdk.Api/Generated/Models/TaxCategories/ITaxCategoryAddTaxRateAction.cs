using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.TaxCategoryAddTaxRateAction))]
    public partial interface ITaxCategoryAddTaxRateAction : ITaxCategoryUpdateAction
    {
        ITaxRateDraft TaxRate { get; set;}
    }
}
