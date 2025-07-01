using commercetools.Sdk.Api.Models.PaymentMethods;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoTokenAction))]
    public partial interface IPaymentSetMethodInfoTokenAction : IPaymentUpdateAction
    {
        IPaymentMethodToken Token { get; set; }

    }
}
