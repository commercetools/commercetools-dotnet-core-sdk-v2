using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoInterfaceAction))]
    public partial interface IPaymentSetMethodInfoInterfaceAction : IPaymentUpdateAction
    {
        string Interface { get; set; }

    }
}
