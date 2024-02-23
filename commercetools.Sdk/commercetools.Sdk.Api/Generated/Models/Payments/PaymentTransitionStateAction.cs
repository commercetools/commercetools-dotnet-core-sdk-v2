using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentTransitionStateAction : IPaymentTransitionStateAction
    {
        public string Action { get; set; }

        public IStateResourceIdentifier State { get; set; }

        public bool? Force { get; set; }
        public PaymentTransitionStateAction()
        {
            this.Action = "transitionState";
        }
    }
}
