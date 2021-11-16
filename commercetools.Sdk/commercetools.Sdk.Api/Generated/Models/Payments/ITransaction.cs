using commercetools.Api.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.Transaction))]
    public partial interface ITransaction
    {
        string Id { get; set; }

        DateTime? Timestamp { get; set; }

        ITransactionType Type { get; set; }

        ITypedMoney Amount { get; set; }

        string InteractionId { get; set; }

        ITransactionState State { get; set; }
    }
}
