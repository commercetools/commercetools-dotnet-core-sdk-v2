using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class RecurringOrderStateTransitionMessagePayload : IRecurringOrderStateTransitionMessagePayload
    {
        public string Type { get; set; }

        public IStateReference State { get; set; }

        public IStateReference OldState { get; set; }

        public bool Force { get; set; }
        public RecurringOrderStateTransitionMessagePayload()
        {
            this.Type = "RecurringOrderStateTransition";
        }
    }
}
