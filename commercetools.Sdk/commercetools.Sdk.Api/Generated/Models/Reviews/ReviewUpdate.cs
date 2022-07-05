using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Reviews
{

    public partial class ReviewUpdate : IReviewUpdate
    {
        public long Version { get; set; }

        public List<IReviewUpdateAction> Actions { get; set; }
    }
}
