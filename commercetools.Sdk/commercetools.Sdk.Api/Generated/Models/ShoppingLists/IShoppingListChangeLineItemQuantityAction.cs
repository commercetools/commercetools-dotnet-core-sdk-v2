using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListChangeLineItemQuantityAction))]
    public partial interface IShoppingListChangeLineItemQuantityAction : IShoppingListUpdateAction
    {
        string LineItemId { get; set;}
        
        long Quantity { get; set;}
    }
}
