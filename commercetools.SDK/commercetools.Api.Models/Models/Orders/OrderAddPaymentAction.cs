using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("addPayment")]
    public class OrderAddPaymentAction : OrderUpdateAction
    {
        public PaymentResourceIdentifier Payment { get; set;}
    }
}
