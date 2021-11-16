using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.ReviewSetTargetAction))]
    public partial interface IReviewSetTargetAction : IReviewUpdateAction
    {
        Object Target { get; set;}
    }
}
