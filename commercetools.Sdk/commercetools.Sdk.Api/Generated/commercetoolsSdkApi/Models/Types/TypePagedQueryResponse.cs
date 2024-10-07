using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Types
{

    public partial class TypePagedQueryResponse : ITypePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IType> Results { get; set; }

        public IEnumerable<IType> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
