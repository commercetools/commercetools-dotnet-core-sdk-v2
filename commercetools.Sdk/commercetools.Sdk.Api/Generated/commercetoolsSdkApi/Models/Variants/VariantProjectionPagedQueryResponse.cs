using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantProjectionPagedQueryResponse : IVariantProjectionPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public IList<IVariantProjection> Results { get; set; }

        public IEnumerable<IVariantProjection> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
