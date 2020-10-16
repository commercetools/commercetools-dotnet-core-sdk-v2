using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("PaymentTransactionAdded")]
    public partial class PaymentTransactionAddedMessage : Message
    {
        public Transaction Transaction { get; set;}
        public PaymentTransactionAddedMessage()
        { 
           this.Type = "PaymentTransactionAdded";
        }
    }
}
