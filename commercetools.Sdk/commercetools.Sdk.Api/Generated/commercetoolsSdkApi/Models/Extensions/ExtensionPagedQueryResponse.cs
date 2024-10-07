using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class ExtensionPagedQueryResponse : IExtensionPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IExtension> Results { get; set; }

        public IEnumerable<IExtension> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
