using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.TaxCategories.TaxCategoryChangeNameAction))]
    public partial interface ITaxCategoryChangeNameAction : ITaxCategoryUpdateAction
    {
        string Name { get; set; }
    }
}
