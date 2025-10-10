using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;


namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetActivePaymentComponentTypeUpdateAction : ISetActivePaymentComponentTypeUpdateAction
    {
        public string Action { get; set; }

        public IPaymentComponentType ActivePaymentComponentType { get; set; }
        public SetActivePaymentComponentTypeUpdateAction()
        {
            this.Action = "setActivePaymentComponentType";
        }
    }
}
