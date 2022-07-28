using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemNameAction))]
    public partial interface IShoppingListChangeTextLineItemNameAction : IShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        ILocalizedString Name { get; set; }

    }
}
