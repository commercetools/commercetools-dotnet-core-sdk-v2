using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Payments
{
    public class PaymentSetAmountPaidAction : PaymentUpdateAction
    {
        public Money Amount { get; set;}
    }
}
