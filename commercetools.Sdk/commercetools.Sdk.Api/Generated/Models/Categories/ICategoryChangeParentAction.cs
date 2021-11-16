using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategoryChangeParentAction))]
    public partial interface ICategoryChangeParentAction : ICategoryUpdateAction
    {
        ICategoryResourceIdentifier Parent { get; set;}
    }
}
