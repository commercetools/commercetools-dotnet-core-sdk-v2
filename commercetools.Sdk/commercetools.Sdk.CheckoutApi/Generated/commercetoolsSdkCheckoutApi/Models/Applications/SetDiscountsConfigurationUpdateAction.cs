

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetDiscountsConfigurationUpdateAction : ISetDiscountsConfigurationUpdateAction
    {
        public string Action { get; set; }

        public IDiscountsConfiguration DiscountsConfiguration { get; set; }
        public SetDiscountsConfigurationUpdateAction()
        {
            this.Action = "setDiscountsConfiguration";
        }
    }
}
