using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetDescriptionAction))]
    public partial interface IShoppingListSetDescriptionAction : IShoppingListUpdateAction
    {
        ILocalizedString Description { get; set;}
    }
}
