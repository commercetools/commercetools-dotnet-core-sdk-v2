using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCustomField")]
    public partial class OrderEditSetCustomFieldAction : OrderEditUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public OrderEditSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
