using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Reviews
{

    public partial class ReviewPagedQueryResponse : IReviewPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public IList<IReview> Results { get; set; }
        public IEnumerable<IReview> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
