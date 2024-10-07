using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryReplaceTaxRateAction))]
    public partial interface ITaxCategoryReplaceTaxRateAction : ITaxCategoryUpdateAction
    {
        string TaxRateId { get; set; }

        string TaxRateKey { get; set; }

        ITaxRateDraft TaxRate { get; set; }

    }
}
