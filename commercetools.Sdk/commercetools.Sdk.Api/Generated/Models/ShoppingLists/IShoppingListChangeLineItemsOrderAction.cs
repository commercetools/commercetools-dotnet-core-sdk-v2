using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListChangeLineItemsOrderAction))]
    public partial interface IShoppingListChangeLineItemsOrderAction : IShoppingListUpdateAction
    {
        List<string> LineItemOrder { get; set; }

    }
}
