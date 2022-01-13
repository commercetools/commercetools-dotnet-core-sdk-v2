using commercetools.Api.Models.States;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderStateTransitionMessagePayload : IOrderStateTransitionMessagePayload
    {
        public string Type { get; set; }

        public IStateReference State { get; set; }

        public IStateReference OldState { get; set; }

        public bool Force { get; set; }
        public OrderStateTransitionMessagePayload()
        {
            this.Type = "OrderStateTransition";
        }
    }
}
