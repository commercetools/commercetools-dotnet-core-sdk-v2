using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Payments.PaymentResourceIdentifier))]
    public partial interface IPaymentResourceIdentifier : IResourceIdentifier
    {
        new string Id { get; set; }

        new string Key { get; set; }

    }
}
