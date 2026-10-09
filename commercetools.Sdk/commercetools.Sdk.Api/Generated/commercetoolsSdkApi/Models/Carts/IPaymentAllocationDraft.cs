using commercetools.Sdk.Api.Models.PaymentMethods;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.PaymentAllocationDraft))]
    public partial interface IPaymentAllocationDraft
    {
        string Id { get; set; }

        IPaymentMethodReference PaymentMethod { get; set; }

        IAllocationDraft Allocation { get; set; }

    }
}
