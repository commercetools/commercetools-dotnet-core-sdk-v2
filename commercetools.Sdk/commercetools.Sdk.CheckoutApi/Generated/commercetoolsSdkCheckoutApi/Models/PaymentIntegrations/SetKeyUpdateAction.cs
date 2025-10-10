

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class SetKeyUpdateAction : ISetKeyUpdateAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public SetKeyUpdateAction()
        {
            this.Action = "setKey";
        }
    }
}
