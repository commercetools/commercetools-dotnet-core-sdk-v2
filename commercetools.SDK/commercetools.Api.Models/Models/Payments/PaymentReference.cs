using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("payment")]
    public class PaymentReference : Reference
    {
        public Payment Obj { get; set;}
    }
}
