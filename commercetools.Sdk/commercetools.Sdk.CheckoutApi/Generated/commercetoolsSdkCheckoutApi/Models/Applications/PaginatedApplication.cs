using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class PaginatedApplication : IPaginatedApplication
    {
        public int Limit { get; set; }

        public int Offset { get; set; }

        public int Count { get; set; }

        public int Total { get; set; }

        public IList<IApplication> Results { get; set; }

        public IEnumerable<IApplication> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
