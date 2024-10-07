using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderTransitionStateAction : IOrderTransitionStateAction
    {
        public string Action { get; set; }

        public IStateResourceIdentifier State { get; set; }

        public bool? Force { get; set; }
        public OrderTransitionStateAction()
        {
            this.Action = "transitionState";
        }
    }
}
