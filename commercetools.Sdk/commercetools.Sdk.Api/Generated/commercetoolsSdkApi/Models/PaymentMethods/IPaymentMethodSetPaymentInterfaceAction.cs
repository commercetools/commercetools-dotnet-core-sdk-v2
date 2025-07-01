using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetPaymentInterfaceAction))]
    public partial interface IPaymentMethodSetPaymentInterfaceAction : IPaymentMethodUpdateAction
    {
        string PaymentInterface { get; set; }

    }
}
