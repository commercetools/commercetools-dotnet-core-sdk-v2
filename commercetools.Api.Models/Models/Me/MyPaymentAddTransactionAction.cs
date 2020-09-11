using commercetools.Api.Models.Me;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    public class MyPaymentAddTransactionAction : MyPaymentUpdateAction
    {
        public TransactionDraft Transaction { get; set;}
    }
}
