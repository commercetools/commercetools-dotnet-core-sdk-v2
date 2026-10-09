

namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{

    public partial class RecurringPaymentAddPaymentMethodConfigurationUpdateAction : IRecurringPaymentAddPaymentMethodConfigurationUpdateAction
    {
        public string Action { get; set; }

        public IPaymentMethodConfiguration PaymentMethodConfiguration { get; set; }
        public RecurringPaymentAddPaymentMethodConfigurationUpdateAction()
        {
            this.Action = "addPaymentMethodConfiguration";
        }
    }
}
