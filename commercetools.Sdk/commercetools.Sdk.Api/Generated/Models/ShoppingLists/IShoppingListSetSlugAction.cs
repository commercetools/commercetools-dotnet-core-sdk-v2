using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListSetSlugAction))]
    public partial interface IShoppingListSetSlugAction : IShoppingListUpdateAction
    {
        ILocalizedString Slug { get; set;}
    }
}
