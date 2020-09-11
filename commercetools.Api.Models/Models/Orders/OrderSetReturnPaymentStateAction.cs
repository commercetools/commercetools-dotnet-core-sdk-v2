using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderSetReturnPaymentStateAction : OrderUpdateAction
    {
        public string ReturnItemId { get; set;}
        
        public ReturnPaymentState PaymentState { get; set;}
    }
}
