using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;


namespace commercetools.Api.Models.Payments
{
    public partial class TransactionDraft : ITransactionDraft
    {
        public DateTime? Timestamp { get; set; }

        public ITransactionType Type { get; set; }

        public IMoney Amount { get; set; }

        public string InteractionId { get; set; }

        public ITransactionState State { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
