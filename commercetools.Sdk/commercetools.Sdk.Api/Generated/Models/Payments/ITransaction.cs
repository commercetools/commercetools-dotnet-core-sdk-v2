using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.Transaction))]
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
