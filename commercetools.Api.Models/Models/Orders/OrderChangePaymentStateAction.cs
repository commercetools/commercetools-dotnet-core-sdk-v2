using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderChangePaymentStateAction : OrderUpdateAction
    {
        public PaymentState PaymentState { get; set;}
    }
}
