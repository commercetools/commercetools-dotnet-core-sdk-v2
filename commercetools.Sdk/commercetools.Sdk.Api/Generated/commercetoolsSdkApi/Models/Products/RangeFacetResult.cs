using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Products
{

    public partial class RangeFacetResult : IRangeFacetResult
    {
        public IFacetTypes Type { get; set; }

        public IList<IFacetRange> Ranges { get; set; }

        public IEnumerable<IFacetRange> RangesEnumerable { set => Ranges = value.ToList(); }
        public RangeFacetResult()
        {
            this.Type = IFacetTypes.FindEnum("range");
        }
    }
}
