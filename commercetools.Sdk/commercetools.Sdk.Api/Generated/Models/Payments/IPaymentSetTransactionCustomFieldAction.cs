using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetTransactionCustomFieldAction))]
    public partial interface IPaymentSetTransactionCustomFieldAction : IPaymentUpdateAction
    {
        string TransactionId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }

    }
}
