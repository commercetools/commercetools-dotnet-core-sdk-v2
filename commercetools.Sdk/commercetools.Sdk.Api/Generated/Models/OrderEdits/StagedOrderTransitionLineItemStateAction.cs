using commercetools.Sdk.Api.Models.States;
using System;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderTransitionLineItemStateAction : IStagedOrderTransitionLineItemStateAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public long Quantity { get; set; }

        public IStateResourceIdentifier FromState { get; set; }

        public IStateResourceIdentifier ToState { get; set; }

        public DateTime? ActualTransitionDate { get; set; }
        public StagedOrderTransitionLineItemStateAction()
        {
            this.Action = "transitionLineItemState";
        }
    }
}
