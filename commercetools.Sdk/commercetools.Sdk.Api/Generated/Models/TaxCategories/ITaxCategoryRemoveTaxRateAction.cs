using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryRemoveTaxRateAction))]
    public partial interface ITaxCategoryRemoveTaxRateAction : ITaxCategoryUpdateAction
    {
        string TaxRateId { get; set; }

        string TaxRateKey { get; set; }

    }
}
