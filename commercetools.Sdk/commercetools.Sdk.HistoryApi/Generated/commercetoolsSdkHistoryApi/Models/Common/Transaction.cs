using System;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class Transaction : ITransaction
    {
        public string Id { get; set; }

        public DateTime? Timestamp { get; set; }

        public ITransactionType Type { get; set; }

        public ICentPrecisionMoney Amount { get; set; }

        public string InteractionId { get; set; }

        public ITransactionState State { get; set; }

        public ICustomFields Custom { get; set; }
    }
}
