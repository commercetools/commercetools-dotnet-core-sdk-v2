using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetCustomFieldAction))]
    public partial interface IReviewSetCustomFieldAction : IReviewUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
