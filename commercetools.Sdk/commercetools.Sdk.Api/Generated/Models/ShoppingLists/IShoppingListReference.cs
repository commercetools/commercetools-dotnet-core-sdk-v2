using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListReference))]
    public partial interface IShoppingListReference : IReference
    {
        IShoppingList Obj { get; set; }
    }
}
