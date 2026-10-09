using commercetools.Sdk.Api.Models.PaymentMethods;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.RecurringPaymentAllocation))]
    public partial interface IRecurringPaymentAllocation
    {
        string Id { get; set; }

        IPaymentMethodReference PaymentMethod { get; set; }

        IAllocation Allocation { get; set; }

    }
}
