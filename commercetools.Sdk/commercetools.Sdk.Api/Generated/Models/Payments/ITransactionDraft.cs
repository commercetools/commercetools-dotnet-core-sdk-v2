using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.TransactionDraft))]
    public partial interface ITransactionDraft
    {
        DateTime? Timestamp { get; set; }

        ITransactionType Type { get; set; }

        IMoney Amount { get; set; }

        string InteractionId { get; set; }

        ITransactionState State { get; set; }

        ICustomFieldsDraft Custom { get; set; }
    }
}
