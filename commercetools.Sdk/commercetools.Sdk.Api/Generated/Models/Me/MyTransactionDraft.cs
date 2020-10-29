using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyTransactionDraft : IMyTransactionDraft
    {
        public DateTime Timestamp { get; set;}
        
        public string Type { get; set;}
        
        [JsonIgnore]
        public TransactionType TypeAsEnum => this.Type.GetEnum<TransactionType>();
        
        public IMoney Amount { get; set;}
        
        public string InteractionId { get; set;}
    }
}
