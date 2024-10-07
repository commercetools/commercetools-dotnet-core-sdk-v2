using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryAddTaxRateAction))]
    public partial interface ITaxCategoryAddTaxRateAction : ITaxCategoryUpdateAction
    {
        ITaxRateDraft TaxRate { get; set; }

    }
}
