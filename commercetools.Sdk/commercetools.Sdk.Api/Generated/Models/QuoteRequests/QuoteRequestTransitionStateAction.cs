using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{

    public partial class QuoteRequestTransitionStateAction : IQuoteRequestTransitionStateAction
    {
        public string Action { get; set; }

        public IStateResourceIdentifier State { get; set; }

        public bool? Force { get; set; }
        public QuoteRequestTransitionStateAction()
        {
            this.Action = "transitionState";
        }
    }
}
