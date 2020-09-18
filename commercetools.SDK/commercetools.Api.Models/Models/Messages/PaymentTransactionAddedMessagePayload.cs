using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("PaymentTransactionAdded")]
    public class PaymentTransactionAddedMessagePayload : MessagePayload
    {
        public Transaction Transaction { get; set;}
    }
}
