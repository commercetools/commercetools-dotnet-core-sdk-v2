using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantPagedQueryResponse : IVariantPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IVariant> Results { get; set; }

        public IEnumerable<IVariant> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
