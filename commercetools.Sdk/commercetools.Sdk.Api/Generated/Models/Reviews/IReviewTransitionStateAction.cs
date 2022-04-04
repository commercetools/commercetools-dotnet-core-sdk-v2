using commercetools.Sdk.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewTransitionStateAction))]
    public partial interface IReviewTransitionStateAction : IReviewUpdateAction
    {
        IStateResourceIdentifier State { get; set; }

        bool? Force { get; set; }
    }
}
