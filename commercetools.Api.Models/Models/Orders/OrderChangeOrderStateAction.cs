using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderChangeOrderStateAction : OrderUpdateAction
    {
        public OrderState OrderState { get; set;}
    }
}
