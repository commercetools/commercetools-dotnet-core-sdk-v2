using commercetools.Api.Models.Me;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("addPayment")]
    public class MyCartAddPaymentAction : MyCartUpdateAction
    {
        public PaymentResourceIdentifier Payment { get; set;}
    }
}
