using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("changeLineItemsOrder")]
    public partial class MyShoppingListChangeLineItemsOrderAction : MyShoppingListUpdateAction
    {
        public List<string> LineItemOrder { get; set;}
        public MyShoppingListChangeLineItemsOrderAction()
        { 
           this.Action = "changeLineItemsOrder";
        }
    }
}
