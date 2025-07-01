using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodSetMethodAction))]
    public partial interface IPaymentMethodSetMethodAction : IPaymentMethodUpdateAction
    {
        string Method { get; set; }

    }
}
