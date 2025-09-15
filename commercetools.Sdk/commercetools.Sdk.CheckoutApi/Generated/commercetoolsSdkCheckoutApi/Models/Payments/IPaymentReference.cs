using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Payments.PaymentReference))]
    public partial interface IPaymentReference : IReference
    {
        new string Id { get; set; }

    }
}
