using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Common.PaymentMethodReference))]
    public partial interface IPaymentMethodReference : IReference
    {
        new IReferenceTypeId TypeId { get; set; }

        new string Id { get; set; }

    }
}
