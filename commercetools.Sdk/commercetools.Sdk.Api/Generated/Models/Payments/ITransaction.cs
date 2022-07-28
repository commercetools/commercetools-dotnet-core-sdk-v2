using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.Transaction))]
    public partial interface ITransaction
    {
        string Id { get; set; }

        DateTime? Timestamp { get; set; }

        ITransactionType Type { get; set; }

        ITypedMoney Amount { get; set; }

        string InteractionId { get; set; }

        ITransactionState State { get; set; }

        ICustomFields Custom { get; set; }

    }
}
