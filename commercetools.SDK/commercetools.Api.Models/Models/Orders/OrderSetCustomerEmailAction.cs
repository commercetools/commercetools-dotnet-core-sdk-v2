using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setCustomerEmail")]
    public class OrderSetCustomerEmailAction : OrderUpdateAction
    {
        public string Email { get; set;}
    }
}
