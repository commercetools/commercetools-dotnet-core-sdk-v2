using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.TaxCategoryReplaceTaxRateAction))]
    public partial interface ITaxCategoryReplaceTaxRateAction : ITaxCategoryUpdateAction
    {
        string TaxRateId { get; set;}
        
        ITaxRateDraft TaxRate { get; set;}
    }
}
