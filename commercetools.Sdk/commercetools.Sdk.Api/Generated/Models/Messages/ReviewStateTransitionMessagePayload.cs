using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ReviewStateTransitionMessagePayload : IReviewStateTransitionMessagePayload
    {
        public string Type { get; set; }

        public IStateReference OldState { get; set; }

        public IStateReference NewState { get; set; }

        public bool OldIncludedInStatistics { get; set; }

        public bool NewIncludedInStatistics { get; set; }

        public IReference Target { get; set; }

        public bool Force { get; set; }
        public ReviewStateTransitionMessagePayload()
        {
            this.Type = "ReviewStateTransition";
        }
    }
}
