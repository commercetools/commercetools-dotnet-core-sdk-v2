using System;
using commercetools.Base.CustomAttributes;
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
