using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Messages;
using commercetools.Api.Generated.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IPaymentTransactionStateChangedMessage : IMessage
    {
        string TransactionId { get; set;}
        
        string State { get; set;}
        
        TransactionState StateAsEnum { get; }
    }
}
