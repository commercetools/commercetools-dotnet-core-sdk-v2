using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.States;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ReviewStateTransitionMessagePayload))]
    public partial interface IReviewStateTransitionMessagePayload : IMessagePayload
    {
        IStateReference OldState { get; set; }

        IStateReference NewState { get; set; }

        bool OldIncludedInStatistics { get; set; }

        bool NewIncludedInStatistics { get; set; }

        IReference Target { get; set; }

        bool Force { get; set; }

    }
}
