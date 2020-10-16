using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("addTransaction")]
    public partial class PaymentAddTransactionAction : PaymentUpdateAction
    {
        public TransactionDraft Transaction { get; set;}
        public PaymentAddTransactionAction()
        { 
           this.Action = "addTransaction";
        }
    }
}
