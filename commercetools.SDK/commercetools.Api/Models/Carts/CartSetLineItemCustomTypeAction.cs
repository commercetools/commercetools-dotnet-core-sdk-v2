using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setLineItemCustomType")]
    public partial class CartSetLineItemCustomTypeAction : CartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public CartSetLineItemCustomTypeAction()
        { 
           this.Action = "setLineItemCustomType";
        }
    }
}
