using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;

namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class TransactionDraft : ITransactionDraft
    {
        public DateTime? Timestamp { get; set; }

        public ITransactionType Type { get; set; }

        public IMoney Amount { get; set; }

        public string InteractionId { get; set; }

        public ITransactionState State { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public string InterfaceId { get; set; }
    }
}
