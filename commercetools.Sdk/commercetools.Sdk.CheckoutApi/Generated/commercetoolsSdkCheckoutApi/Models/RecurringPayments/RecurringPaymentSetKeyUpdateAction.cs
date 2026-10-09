

namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{

    public partial class RecurringPaymentSetKeyUpdateAction : IRecurringPaymentSetKeyUpdateAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public RecurringPaymentSetKeyUpdateAction()
        {
            this.Action = "setKey";
        }
    }
}
