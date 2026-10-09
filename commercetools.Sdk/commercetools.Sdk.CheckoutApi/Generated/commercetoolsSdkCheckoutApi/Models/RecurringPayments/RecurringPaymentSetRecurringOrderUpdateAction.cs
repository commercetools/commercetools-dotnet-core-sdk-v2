

namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{

    public partial class RecurringPaymentSetRecurringOrderUpdateAction : IRecurringPaymentSetRecurringOrderUpdateAction
    {
        public string Action { get; set; }

        public IRecurringOrderReference RecurringOrder { get; set; }
        public RecurringPaymentSetRecurringOrderUpdateAction()
        {
            this.Action = "setRecurringOrder";
        }
    }
}
