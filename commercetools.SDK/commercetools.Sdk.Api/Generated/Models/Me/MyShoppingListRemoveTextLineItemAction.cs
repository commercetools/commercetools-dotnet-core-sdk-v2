using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("removeTextLineItem")]
    public partial class MyShoppingListRemoveTextLineItemAction : MyShoppingListUpdateAction
    {
        public string TextLineItemId { get; set;}
        
        public long Quantity { get; set;}
        public MyShoppingListRemoveTextLineItemAction()
        { 
           this.Action = "removeTextLineItem";
        }
    }
}
