using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyShoppingListChangeTextLineItemQuantityAction : IMyShoppingListChangeTextLineItemQuantityAction
    {
        public string Action { get; set;}
        
        public string TextLineItemId { get; set;}
        
        public long Quantity { get; set;}
        public MyShoppingListChangeTextLineItemQuantityAction()
        { 
           this.Action = "changeTextLineItemQuantity";
        }
    }
}
