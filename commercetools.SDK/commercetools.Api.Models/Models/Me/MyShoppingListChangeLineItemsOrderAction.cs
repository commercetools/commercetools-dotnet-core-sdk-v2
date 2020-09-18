using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeLineItemsOrder")]
    public class MyShoppingListChangeLineItemsOrderAction : MyShoppingListUpdateAction
    {
        public List<string> LineItemOrder { get; set;}
    }
}
