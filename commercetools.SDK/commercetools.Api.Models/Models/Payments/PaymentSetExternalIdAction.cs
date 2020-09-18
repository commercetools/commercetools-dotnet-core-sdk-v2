using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setExternalId")]
    public class PaymentSetExternalIdAction : PaymentUpdateAction
    {
        public string ExternalId { get; set;}
    }
}
