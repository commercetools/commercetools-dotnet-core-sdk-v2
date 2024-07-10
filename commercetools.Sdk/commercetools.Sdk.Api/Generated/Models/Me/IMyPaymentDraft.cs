using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Me;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyPaymentDraft))]
    public partial interface IMyPaymentDraft
    {
        IMoney AmountPlanned { get; set; }

        IPaymentMethodInfo PaymentMethodInfo { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IMyTransactionDraft Transaction { get; set; }

    }
}
