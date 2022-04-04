using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListSetTextLineItemDescriptionAction))]
    public partial interface IShoppingListSetTextLineItemDescriptionAction : IShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        ILocalizedString Description { get; set; }
    }
}
