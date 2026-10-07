using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartRemoveRecurringPaymentAllocationAction))]
    public partial interface ICartRemoveRecurringPaymentAllocationAction : ICartUpdateAction
    {
        string Id { get; set; }

    }
}
