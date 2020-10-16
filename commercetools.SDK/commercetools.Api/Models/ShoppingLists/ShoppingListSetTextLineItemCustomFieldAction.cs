using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("setTextLineItemCustomField")]
    public partial class ShoppingListSetTextLineItemCustomFieldAction : ShoppingListUpdateAction
    {
        public string TextLineItemId { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public ShoppingListSetTextLineItemCustomFieldAction()
        { 
           this.Action = "setTextLineItemCustomField";
        }
    }
}
