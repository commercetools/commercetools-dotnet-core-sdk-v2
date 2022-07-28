using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Categories.CategoryChangeParentAction))]
    public partial interface ICategoryChangeParentAction : ICategoryUpdateAction
    {
        ICategoryResourceIdentifier Parent { get; set; }

    }
}
