using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeTextLineItemsOrder")]
    public class MyShoppingListChangeTextLineItemsOrderAction : MyShoppingListUpdateAction
    {
        public List<string> TextLineItemOrder { get; set;}
    }
}
