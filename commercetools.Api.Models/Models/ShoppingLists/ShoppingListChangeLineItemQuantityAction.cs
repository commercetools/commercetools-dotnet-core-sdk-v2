using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShoppingLists
{
    public class ShoppingListChangeLineItemQuantityAction : ShoppingListUpdateAction
    {
        public string LineItemId { get; set;}
        
        public long Quantity { get; set;}
    }
}
