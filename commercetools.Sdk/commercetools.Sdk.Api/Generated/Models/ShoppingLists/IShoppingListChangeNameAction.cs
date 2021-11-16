using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListChangeNameAction))]
    public partial interface IShoppingListChangeNameAction : IShoppingListUpdateAction
    {
        ILocalizedString Name { get; set; }
    }
}
