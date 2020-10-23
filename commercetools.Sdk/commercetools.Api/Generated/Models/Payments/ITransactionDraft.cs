using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Payments
{
    public interface ITransactionDraft 
    {
        DateTime Timestamp { get; set;}
        
        string Type { get; set;}
        
        TransactionType TypeAsEnum { get; }
        
        IMoney Amount { get; set;}
        
        string InteractionId { get; set;}
        
        string State { get; set;}
        
        TransactionState StateAsEnum { get; }
    }
}
