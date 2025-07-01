using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetPaymentMethodStatusAction))]
    public partial interface IPaymentMethodSetPaymentMethodStatusAction : IPaymentMethodUpdateAction
    {
        IPaymentMethodStatus PaymentMethodStatus { get; set; }

    }
}
