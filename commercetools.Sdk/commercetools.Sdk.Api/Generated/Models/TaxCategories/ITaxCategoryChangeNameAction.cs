using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.TaxCategoryChangeNameAction))]
    public partial interface ITaxCategoryChangeNameAction : ITaxCategoryUpdateAction
    {
        string Name { get; set; }
    }
}
