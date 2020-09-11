using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Payments
{
    public class PaymentAddTransactionAction : PaymentUpdateAction
    {
        public TransactionDraft Transaction { get; set;}
    }
}
