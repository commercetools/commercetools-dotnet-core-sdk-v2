

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetRecurringPaymentStrategyAction : ICartSetRecurringPaymentStrategyAction
    {
        public string Action { get; set; }

        public IPaymentStrategy PaymentStrategy { get; set; }
        public CartSetRecurringPaymentStrategyAction()
        {
            this.Action = "setRecurringPaymentStrategy";
        }
    }
}
