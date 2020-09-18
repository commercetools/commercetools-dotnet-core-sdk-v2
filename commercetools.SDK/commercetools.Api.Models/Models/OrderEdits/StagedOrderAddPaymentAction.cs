using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("addPayment")]
    public class StagedOrderAddPaymentAction : StagedOrderUpdateAction
    {
        public PaymentResourceIdentifier Payment { get; set;}
    }
}
