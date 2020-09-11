using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShoppingLists
{
    public class ShoppingListChangeTextLineItemNameAction : ShoppingListUpdateAction
    {
        public string TextLineItemId { get; set;}
        
        public LocalizedString Name { get; set;}
    }
}
