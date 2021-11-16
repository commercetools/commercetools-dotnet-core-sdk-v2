using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Api.Models.Projects.ShoppingListsConfiguration))]
    public partial interface IShoppingListsConfiguration 
    {
        long? DeleteDaysAfterLastModification { get; set;}
    }
}
