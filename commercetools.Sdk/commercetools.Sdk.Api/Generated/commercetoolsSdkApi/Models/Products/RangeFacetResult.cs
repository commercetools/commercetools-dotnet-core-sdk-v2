using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Products
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class RangeFacetResult : IRangeFacetResult
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        public IFacetTypes Type { get; set; }

        public IList<IFacetRange> Ranges { get; set; }

        public IEnumerable<IFacetRange> RangesEnumerable { set => Ranges = value.ToList(); }
        public RangeFacetResult()
        {
            this.Type = IFacetTypes.FindEnum("range");
        }
    }
}
