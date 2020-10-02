using commercetools.Api.Models.Me;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setLineItemCustomType")]
    public partial class MyCartSetLineItemCustomTypeAction : MyCartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public MyCartSetLineItemCustomTypeAction()
        { 
           this.Action = "setLineItemCustomType";
        }
    }
}
