using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;


namespace commercetools.Api.Models.Me
{
    public partial class MyTransactionDraft : IMyTransactionDraft
    {
        public DateTime? Timestamp { get; set;}
        
        public ITransactionType Type { get; set;}
        
        public IMoney Amount { get; set;}
        
        public string InteractionId { get; set;}
    }
}
