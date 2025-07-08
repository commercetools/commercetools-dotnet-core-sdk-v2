using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderTransitionStateAction : IRecurringOrderTransitionStateAction
    {
        public string Action { get; set; }

        public IStateResourceIdentifier State { get; set; }

        public bool? Force { get; set; }
        public RecurringOrderTransitionStateAction()
        {
            this.Action = "transitionState";
        }
    }
}
