using commercetools.Api.Models.Common;
using System;


namespace commercetools.Api.Models.Payments
{
    public partial class Transaction : ITransaction
    {
        public string Id { get; set; }

        public DateTime? Timestamp { get; set; }

        public ITransactionType Type { get; set; }

        public ITypedMoney Amount { get; set; }

        public string InteractionId { get; set; }

        public ITransactionState State { get; set; }
    }
}
