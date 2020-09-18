using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setMethodInfoName")]
    public class PaymentSetMethodInfoNameAction : PaymentUpdateAction
    {
        public LocalizedString Name { get; set;}
    }
}
