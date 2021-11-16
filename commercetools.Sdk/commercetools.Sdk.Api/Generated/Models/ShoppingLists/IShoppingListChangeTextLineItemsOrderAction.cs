using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListChangeTextLineItemsOrderAction))]
    public partial interface IShoppingListChangeTextLineItemsOrderAction : IShoppingListUpdateAction
    {
        List<string> TextLineItemOrder { get; set; }
    }
}
