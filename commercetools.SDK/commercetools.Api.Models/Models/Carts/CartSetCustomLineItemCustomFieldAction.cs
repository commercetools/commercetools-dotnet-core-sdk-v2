using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCustomLineItemCustomField")]
    public partial class CartSetCustomLineItemCustomFieldAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public CartSetCustomLineItemCustomFieldAction()
        { 
           this.Action = "setCustomLineItemCustomField";
        }
    }
}
