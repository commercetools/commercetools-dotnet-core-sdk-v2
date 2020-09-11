using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Payments
{
    public class PaymentSetExternalIdAction : PaymentUpdateAction
    {
        public string ExternalId { get; set;}
    }
}
