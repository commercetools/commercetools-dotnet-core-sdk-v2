using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategorySetKeyAction))]
    public partial interface ITaxCategorySetKeyAction : ITaxCategoryUpdateAction
    {
        string Key { get; set; }

    }
}
