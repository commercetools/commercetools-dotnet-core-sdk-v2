using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyTransactionDraft))]
    public partial interface IMyTransactionDraft
    {
        DateTime? Timestamp { get; set; }

        ITransactionType Type { get; set; }

        IMoney Amount { get; set; }

        string InteractionId { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
