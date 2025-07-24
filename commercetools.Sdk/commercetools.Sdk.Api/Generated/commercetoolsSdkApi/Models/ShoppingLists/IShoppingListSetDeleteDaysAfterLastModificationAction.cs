using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetDeleteDaysAfterLastModificationAction))]
    public partial interface IShoppingListSetDeleteDaysAfterLastModificationAction : IShoppingListUpdateAction
    {
        int? DeleteDaysAfterLastModification { get; set; }

    }
}
