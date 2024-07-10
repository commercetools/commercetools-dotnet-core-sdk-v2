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

    public partial class PaymentTransactionAddedMessagePayload : IPaymentTransactionAddedMessagePayload
    {
        public string Type { get; set; }

        public ITransaction Transaction { get; set; }
        public PaymentTransactionAddedMessagePayload()
        {
            this.Type = "PaymentTransactionAdded";
        }
    }
}
