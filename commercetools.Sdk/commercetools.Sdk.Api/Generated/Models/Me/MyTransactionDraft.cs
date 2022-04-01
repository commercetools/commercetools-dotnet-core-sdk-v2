using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Sdk.Api.Models.Types;
using System;


namespace commercetools.Sdk.Api.Models.Me
{
    public partial class MyTransactionDraft : IMyTransactionDraft
    {
        public DateTime? Timestamp { get; set; }

        public ITransactionType Type { get; set; }

        public IMoney Amount { get; set; }

        public string InteractionId { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
