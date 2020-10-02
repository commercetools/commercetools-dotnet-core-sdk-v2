using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setTextLineItemCustomField")]
    public partial class MyShoppingListSetTextLineItemCustomFieldAction : MyShoppingListUpdateAction
    {
        public string TextLineItemId { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public MyShoppingListSetTextLineItemCustomFieldAction()
        { 
           this.Action = "setTextLineItemCustomField";
        }
    }
}
