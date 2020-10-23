using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public  partial class MyShoppingListRemoveLineItemAction : IMyShoppingListRemoveLineItemAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public long Quantity { get; set;}
        public MyShoppingListRemoveLineItemAction()
        { 
           this.Action = "removeLineItem";
        }
    }
}
