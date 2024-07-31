using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetTargetAction))]
    public partial interface IReviewSetTargetAction : IReviewUpdateAction
    {
        Object Target { get; set; }

    }
}
