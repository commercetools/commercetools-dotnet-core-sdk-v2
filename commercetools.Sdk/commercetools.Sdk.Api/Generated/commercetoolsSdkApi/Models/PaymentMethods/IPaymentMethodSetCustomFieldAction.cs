using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetCustomFieldAction))]
    public partial interface IPaymentMethodSetCustomFieldAction : IPaymentMethodUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
