using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.PaymentTransactionAddedMessagePayload))]
    public partial interface IPaymentTransactionAddedMessagePayload : IMessagePayload
    {
        ITransaction Transaction { get; set;}
    }
}
