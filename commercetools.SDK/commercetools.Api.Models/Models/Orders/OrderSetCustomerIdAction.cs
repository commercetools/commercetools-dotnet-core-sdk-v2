using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setCustomerId")]
    public class OrderSetCustomerIdAction : OrderUpdateAction
    {
        public string CustomerId { get; set;}
    }
}
