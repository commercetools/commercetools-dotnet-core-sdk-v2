using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoMethodAction))]
    public partial interface IPaymentSetMethodInfoMethodAction : IPaymentUpdateAction
    {
        string Method { get; set; }

    }
}
