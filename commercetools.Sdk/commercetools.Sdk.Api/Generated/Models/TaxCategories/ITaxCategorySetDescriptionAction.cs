using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategorySetDescriptionAction))]
    public partial interface ITaxCategorySetDescriptionAction : ITaxCategoryUpdateAction
    {
        string Description { get; set; }

    }
}
