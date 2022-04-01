using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetSlugAction))]
    public partial interface IShoppingListSetSlugAction : IShoppingListUpdateAction
    {
        ILocalizedString Slug { get; set; }
    }
}
