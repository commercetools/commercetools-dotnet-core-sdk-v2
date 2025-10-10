

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class SetTypeUpdateAction : ISetTypeUpdateAction
    {
        public string Action { get; set; }

        public string Type { get; set; }
        public SetTypeUpdateAction()
        {
            this.Action = "setType";
        }
    }
}
