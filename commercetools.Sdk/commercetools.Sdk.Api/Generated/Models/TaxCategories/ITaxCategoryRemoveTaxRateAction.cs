using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.TaxCategoryRemoveTaxRateAction))]
    public partial interface ITaxCategoryRemoveTaxRateAction : ITaxCategoryUpdateAction
    {
        string TaxRateId { get; set; }
    }
}
