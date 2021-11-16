using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.TaxCategorySetDescriptionAction))]
    public partial interface ITaxCategorySetDescriptionAction : ITaxCategoryUpdateAction
    {
        string Description { get; set;}
    }
}
