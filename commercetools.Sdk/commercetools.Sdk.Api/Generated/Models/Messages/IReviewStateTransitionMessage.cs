using commercetools.Api.Models.Common;
using commercetools.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ReviewStateTransitionMessage))]
    public partial interface IReviewStateTransitionMessage : IMessage
    {
        IStateReference OldState { get; set; }

        IStateReference NewState { get; set; }

        bool OldIncludedInStatistics { get; set; }

        bool NewIncludedInStatistics { get; set; }

        IReference Target { get; set; }

        bool Force { get; set; }
    }
}
