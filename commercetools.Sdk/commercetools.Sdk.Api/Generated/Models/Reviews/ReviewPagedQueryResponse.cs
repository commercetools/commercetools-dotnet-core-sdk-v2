using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Reviews
{

    public partial class ReviewPagedQueryResponse : IReviewPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public List<IReview> Results { get; set; }
    }
}
