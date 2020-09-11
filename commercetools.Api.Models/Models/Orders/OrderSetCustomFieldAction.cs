using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderSetCustomFieldAction : OrderUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
