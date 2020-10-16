using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Me
{
    public partial class MyTransactionDraft 
    {
        public DateTime Timestamp { get; set;}
        
        public string Type { get; set;}
        
        [JsonIgnore]
        public TransactionType TypeAsEnum => this.Type.GetEnum<TransactionType>();
        
        public Money Amount { get; set;}
        
        public string InteractionId { get; set;}
    }
}
