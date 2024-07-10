using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class QuoteStateTransitionMessagePayload : IQuoteStateTransitionMessagePayload
    {
        public string Type { get; set; }

        public IStateReference State { get; set; }

        public IStateReference OldState { get; set; }

        public bool Force { get; set; }
        public QuoteStateTransitionMessagePayload()
        {
            this.Type = "QuoteStateTransition";
        }
    }
}
