using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetDescriptionAction))]
    public partial interface IShoppingListSetDescriptionAction : IShoppingListUpdateAction
    {
        ILocalizedString Description { get; set; }

    }
}
