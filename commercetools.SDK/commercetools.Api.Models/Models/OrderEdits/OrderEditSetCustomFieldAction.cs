using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCustomField")]
    public class OrderEditSetCustomFieldAction : OrderEditUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
