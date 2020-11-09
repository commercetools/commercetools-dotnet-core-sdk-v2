using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyTransactionDraft))]
    public partial interface IMyTransactionDraft 
    {
        DateTime Timestamp { get; set;}
        
        string Type { get; set;}
        
        TransactionType TypeAsEnum { get; }
        
        IMoney Amount { get; set;}
        
        string InteractionId { get; set;}
    }
}
