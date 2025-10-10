

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetPaymentsConfigurationUpdateAction : ISetPaymentsConfigurationUpdateAction
    {
        public string Action { get; set; }

        public IPaymentsConfiguration PaymentsConfiguration { get; set; }
        public SetPaymentsConfigurationUpdateAction()
        {
            this.Action = "setPaymentsConfiguration";
        }
    }
}
