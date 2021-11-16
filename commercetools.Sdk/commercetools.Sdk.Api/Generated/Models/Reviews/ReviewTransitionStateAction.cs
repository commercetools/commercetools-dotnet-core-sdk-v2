using commercetools.Api.Models.States;


namespace commercetools.Api.Models.Reviews
{
    public partial class ReviewTransitionStateAction : IReviewTransitionStateAction
    {
        public string Action { get; set; }

        public IStateResourceIdentifier State { get; set; }

        public bool? Force { get; set; }
        public ReviewTransitionStateAction()
        {
            this.Action = "transitionState";
        }
    }
}
