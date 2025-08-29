using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Errors.PaymentFailureError))]
    public partial interface IPaymentFailureError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
