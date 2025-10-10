

namespace commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations
{

    public partial class SetStatusUpdateAction : ISetStatusUpdateAction
    {
        public string Action { get; set; }

        public IPaymentIntegrationStatus Status { get; set; }
        public SetStatusUpdateAction()
        {
            this.Action = "setStatus";
        }
    }
}
