using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setLineItemCustomField")]
    public partial class MyCartSetLineItemCustomFieldAction : MyCartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public MyCartSetLineItemCustomFieldAction()
        { 
           this.Action = "setLineItemCustomField";
        }
    }
}
