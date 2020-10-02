using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCustomField")]
    public partial class CartSetCustomFieldAction : CartUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public CartSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
