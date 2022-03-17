using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyTransactionDraft))]
    public partial interface IMyTransactionDraft
    {
        DateTime? Timestamp { get; set; }

        ITransactionType Type { get; set; }

        IMoney Amount { get; set; }

        string InteractionId { get; set; }

        ICustomFieldsDraft Custom { get; set; }
    }
}
