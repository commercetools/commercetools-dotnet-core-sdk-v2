using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewUpdate))]
    public partial interface IReviewUpdate
    {
        long Version { get; set; }

        List<IReviewUpdateAction> Actions { get; set; }
    }
}
