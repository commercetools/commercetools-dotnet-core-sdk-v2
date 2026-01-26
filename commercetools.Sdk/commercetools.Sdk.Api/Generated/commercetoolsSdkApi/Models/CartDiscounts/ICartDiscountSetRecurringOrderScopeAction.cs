using commercetools.Sdk.Api.Models.RecurringOrders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetRecurringOrderScopeAction))]
    public partial interface ICartDiscountSetRecurringOrderScopeAction : ICartDiscountUpdateAction
    {
        IRecurringOrderScopeDraft RecurringOrderScope { get; set; }

    }
}
