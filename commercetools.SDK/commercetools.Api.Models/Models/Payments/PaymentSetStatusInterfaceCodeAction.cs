using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setStatusInterfaceCode")]
    public class PaymentSetStatusInterfaceCodeAction : PaymentUpdateAction
    {
        public string InterfaceCode { get; set;}
    }
}
