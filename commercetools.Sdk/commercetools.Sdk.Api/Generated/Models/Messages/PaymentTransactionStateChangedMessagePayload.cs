using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentTransactionStateChangedMessagePayload : IPaymentTransactionStateChangedMessagePayload
    {
        public string Type { get; set; }

        public string TransactionId { get; set; }

        public ITransactionState State { get; set; }
        public PaymentTransactionStateChangedMessagePayload()
        {
            this.Type = "PaymentTransactionStateChanged";
        }
    }
}
