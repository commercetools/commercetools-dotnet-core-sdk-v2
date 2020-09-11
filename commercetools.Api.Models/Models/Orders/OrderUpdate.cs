using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderUpdate 
    {
        public long Version { get; set;}
        
        public List<OrderUpdateAction> Actions { get; set;}
    }
}
