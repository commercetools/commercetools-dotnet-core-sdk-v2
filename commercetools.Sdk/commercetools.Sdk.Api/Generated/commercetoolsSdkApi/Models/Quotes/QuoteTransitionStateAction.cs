using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuoteTransitionStateAction : IQuoteTransitionStateAction
    {
        public string Action { get; set; }

        public IStateResourceIdentifier State { get; set; }

        public bool? Force { get; set; }
        public QuoteTransitionStateAction()
        {
            this.Action = "transitionState";
        }
    }
}
