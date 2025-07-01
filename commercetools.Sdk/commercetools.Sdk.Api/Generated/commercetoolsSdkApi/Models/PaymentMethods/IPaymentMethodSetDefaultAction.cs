using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetDefaultAction))]
    public partial interface IPaymentMethodSetDefaultAction : IPaymentMethodUpdateAction
    {
        bool Default { get; set; }

    }
}
