using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("changeLineItemsOrder")]
    public class ShoppingListChangeLineItemsOrderAction : ShoppingListUpdateAction
    {
        public List<string> LineItemOrder { get; set;}
    }
}
