using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.Transaction))]
    public partial interface ITransaction
    {
        string Id { get; set; }

        DateTime? Timestamp { get; set; }

        ITransactionType Type { get; set; }

        ICentPrecisionMoney Amount { get; set; }

        string InteractionId { get; set; }

        ITransactionState State { get; set; }

        ICustomFields Custom { get; set; }

    }
}
