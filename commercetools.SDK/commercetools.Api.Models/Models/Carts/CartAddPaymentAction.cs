using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("addPayment")]
    public class CartAddPaymentAction : CartUpdateAction
    {
        public PaymentResourceIdentifier Payment { get; set;}
    }
}
