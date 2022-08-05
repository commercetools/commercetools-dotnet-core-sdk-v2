using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{

    public partial class StagedQuoteTransitionStateAction : IStagedQuoteTransitionStateAction
    {
        public string Action { get; set; }

        public IStateResourceIdentifier State { get; set; }

        public bool? Force { get; set; }
        public StagedQuoteTransitionStateAction()
        {
            this.Action = "transitionState";
        }
    }
}
