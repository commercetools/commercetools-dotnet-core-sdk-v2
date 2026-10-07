

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetRecurringPaymentConfigurationAction : ICartSetRecurringPaymentConfigurationAction
    {
        public string Action { get; set; }

        public IRecurringPaymentConfigurationDraft RecurringPaymentConfiguration { get; set; }
        public CartSetRecurringPaymentConfigurationAction()
        {
            this.Action = "setRecurringPaymentConfiguration";
        }
    }
}
