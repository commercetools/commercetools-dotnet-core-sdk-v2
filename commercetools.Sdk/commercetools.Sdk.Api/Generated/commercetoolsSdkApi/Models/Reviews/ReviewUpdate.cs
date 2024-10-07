using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Reviews
{

    public partial class ReviewUpdate : IReviewUpdate
    {
        public long Version { get; set; }

        public IList<IReviewUpdateAction> Actions { get; set; }

        public IEnumerable<IReviewUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
