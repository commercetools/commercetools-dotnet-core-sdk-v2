using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoInterfaceAccountAction))]
    public partial interface IPaymentSetMethodInfoInterfaceAccountAction : IPaymentUpdateAction
    {
        string InterfaceAccount { get; set; }

    }
}
