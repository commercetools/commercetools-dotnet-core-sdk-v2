using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setCustomField")]
    public class OrderSetCustomFieldAction : OrderUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
