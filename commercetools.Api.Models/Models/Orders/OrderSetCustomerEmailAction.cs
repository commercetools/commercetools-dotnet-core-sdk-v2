using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderSetCustomerEmailAction : OrderUpdateAction
    {
        public string Email { get; set;}
    }
}
