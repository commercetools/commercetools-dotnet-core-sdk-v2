using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListChangeLineItemsOrderAction))]
    public partial interface IShoppingListChangeLineItemsOrderAction : IShoppingListUpdateAction
    {
        List<string> LineItemOrder { get; set;}
    }
}
