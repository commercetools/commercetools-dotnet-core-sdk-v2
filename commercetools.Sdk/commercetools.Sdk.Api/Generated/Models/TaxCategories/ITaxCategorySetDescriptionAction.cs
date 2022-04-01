using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategorySetDescriptionAction))]
    public partial interface ITaxCategorySetDescriptionAction : ITaxCategoryUpdateAction
    {
        string Description { get; set; }
    }
}
