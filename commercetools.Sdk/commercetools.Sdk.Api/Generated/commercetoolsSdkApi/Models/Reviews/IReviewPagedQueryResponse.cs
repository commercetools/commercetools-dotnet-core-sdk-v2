using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewPagedQueryResponse))]
    public partial interface IReviewPagedQueryResponse
    {
        long Limit { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        long Offset { get; set; }

        IList<IReview> Results { get; set; }

        IEnumerable<IReview> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
