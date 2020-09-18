using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("removePayment")]
    public class CartRemovePaymentAction : CartUpdateAction
    {
        public PaymentResourceIdentifier Payment { get; set;}
    }
}
