using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("removeLineItem")]
    public partial class MyShoppingListRemoveLineItemAction : MyShoppingListUpdateAction
    {
        public string LineItemId { get; set;}
        
        public long Quantity { get; set;}
        public MyShoppingListRemoveLineItemAction()
        { 
           this.Action = "removeLineItem";
        }
    }
}
