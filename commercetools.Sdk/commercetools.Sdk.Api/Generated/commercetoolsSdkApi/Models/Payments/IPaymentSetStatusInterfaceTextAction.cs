using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetStatusInterfaceTextAction))]
    public partial interface IPaymentSetStatusInterfaceTextAction : IPaymentUpdateAction
    {
        string InterfaceText { get; set; }

    }
}
