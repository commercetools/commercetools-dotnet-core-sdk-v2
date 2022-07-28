using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemsOrderAction))]
    public partial interface IShoppingListChangeTextLineItemsOrderAction : IShoppingListUpdateAction
    {
        List<string> TextLineItemOrder { get; set; }

    }
}
