using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setMethodInfoMethod")]
    public class PaymentSetMethodInfoMethodAction : PaymentUpdateAction
    {
        public string Method { get; set;}
    }
}
