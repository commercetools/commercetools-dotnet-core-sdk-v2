using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetInterfaceAccountAction))]
    public partial interface IPaymentMethodSetInterfaceAccountAction : IPaymentMethodUpdateAction
    {
        string InterfaceAccount { get; set; }

    }
}
