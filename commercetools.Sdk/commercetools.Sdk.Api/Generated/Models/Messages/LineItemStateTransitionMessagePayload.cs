using commercetools.Api.Models.States;
using System;


namespace commercetools.Api.Models.Messages
{
    public partial class LineItemStateTransitionMessagePayload : ILineItemStateTransitionMessagePayload
    {
        public string Type { get; set; }

        public string LineItemId { get; set; }

        public DateTime TransitionDate { get; set; }

        public long Quantity { get; set; }

        public IStateReference FromState { get; set; }

        public IStateReference ToState { get; set; }
        public LineItemStateTransitionMessagePayload()
        {
            this.Type = "LineItemStateTransition";
        }
    }
}
