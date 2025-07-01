using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoCustomFieldAction))]
    public partial interface IPaymentSetMethodInfoCustomFieldAction : IPaymentUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
