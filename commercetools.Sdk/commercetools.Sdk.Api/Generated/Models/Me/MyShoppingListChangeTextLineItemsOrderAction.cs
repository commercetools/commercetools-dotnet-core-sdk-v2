using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public  partial class MyShoppingListChangeTextLineItemsOrderAction : IMyShoppingListChangeTextLineItemsOrderAction
    {
        public string Action { get; set;}
        
        public List<string> TextLineItemOrder { get; set;}
        public MyShoppingListChangeTextLineItemsOrderAction()
        { 
           this.Action = "changeTextLineItemsOrder";
        }
    }
}
