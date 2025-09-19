using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.TransactionDraft))]
    public partial interface ITransactionDraft
    {
        DateTime? Timestamp { get; set; }

        ITransactionType Type { get; set; }

        IMoney Amount { get; set; }

        string InteractionId { get; set; }

        ITransactionState State { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        string InterfaceId { get; set; }

    }
}
