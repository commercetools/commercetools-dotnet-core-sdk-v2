using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantBulkUpdateResponse : IVariantBulkUpdateResponse
    {
        public int SuccessCount { get; set; }

        public int FailureCount { get; set; }

        public IList<IVariantBulkUpdateResult> Results { get; set; }

        public IEnumerable<IVariantBulkUpdateResult> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
