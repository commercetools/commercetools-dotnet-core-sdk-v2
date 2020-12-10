using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.TransactionDraft))]
    public partial interface ITransactionDraft 
    {
        DateTime Timestamp { get; set;}
        
        ITransactionType Type { get; set;}
        
        IMoney Amount { get; set;}
        
        string InteractionId { get; set;}
        
        ITransactionState State { get; set;}
    }
}
