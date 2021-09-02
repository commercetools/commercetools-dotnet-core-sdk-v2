using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentAddTransactionAction : IPaymentAddTransactionAction
    {
        public string Action { get; set; }

        public ITransactionDraft Transaction { get; set; }
        public PaymentAddTransactionAction()
        {
            this.Action = "addTransaction";
        }
    }
}
