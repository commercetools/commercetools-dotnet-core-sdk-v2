using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShoppingLists
{
    public class ShoppingListChangeTextLineItemsOrderAction : ShoppingListUpdateAction
    {
        public List<string> TextLineItemOrder { get; set;}
    }
}
