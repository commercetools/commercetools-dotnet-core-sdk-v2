using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetDeleteDaysAfterLastModificationAction))]
    public partial interface IShoppingListSetDeleteDaysAfterLastModificationAction : IShoppingListUpdateAction
    {
        long? DeleteDaysAfterLastModification { get; set; }

    }
}
