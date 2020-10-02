using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderUpdate 
    {
        public long Version { get; set;}
        
        public List<OrderUpdateAction> Actions { get; set;}
    }
}
