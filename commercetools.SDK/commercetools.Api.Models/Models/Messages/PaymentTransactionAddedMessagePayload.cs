using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("PaymentTransactionAdded")]
    public partial class PaymentTransactionAddedMessagePayload : MessagePayload
    {
        public Transaction Transaction { get; set;}
        public PaymentTransactionAddedMessagePayload()
        { 
           this.Type = "PaymentTransactionAdded";
        }
    }
}
