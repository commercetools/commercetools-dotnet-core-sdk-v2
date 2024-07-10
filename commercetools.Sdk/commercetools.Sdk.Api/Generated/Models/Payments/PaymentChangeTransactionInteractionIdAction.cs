using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentChangeTransactionInteractionIdAction : IPaymentChangeTransactionInteractionIdAction
    {
        public string Action { get; set; }

        public string TransactionId { get; set; }

        public string InteractionId { get; set; }
        public PaymentChangeTransactionInteractionIdAction()
        {
            this.Action = "changeTransactionInteractionId";
        }
    }
}
