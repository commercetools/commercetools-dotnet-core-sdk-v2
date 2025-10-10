

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class SetNameUpdateAction : ISetNameUpdateAction
    {
        public string Action { get; set; }

        public string Name { get; set; }
        public SetNameUpdateAction()
        {
            this.Action = "setName";
        }
    }
}
