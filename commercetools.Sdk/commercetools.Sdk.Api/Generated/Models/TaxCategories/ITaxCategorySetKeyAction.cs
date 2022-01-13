using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.TaxCategorySetKeyAction))]
    public partial interface ITaxCategorySetKeyAction : ITaxCategoryUpdateAction
    {
        string Key { get; set; }
    }
}
