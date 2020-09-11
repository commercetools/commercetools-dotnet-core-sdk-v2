using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderRemovePaymentAction : OrderUpdateAction
    {
        public PaymentResourceIdentifier Payment { get; set;}
    }
}
