using commercetools.Sdk.Api.Models.RecurringOrders;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountSetRecurringOrderScopeAction : ICartDiscountSetRecurringOrderScopeAction
    {
        public string Action { get; set; }

        public IRecurringOrderScopeDraft RecurringOrderScope { get; set; }
        public CartDiscountSetRecurringOrderScopeAction()
        {
            this.Action = "setRecurringOrderScope";
        }
    }
}
