using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Products
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class TermFacetResult : ITermFacetResult
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        public IFacetTypes Type { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public ITermFacetResultType DataType { get; set; }

        public long Missing { get; set; }

        public long Total { get; set; }

        public long Other { get; set; }

        public IList<IFacetTerm> Terms { get; set; }

        public IEnumerable<IFacetTerm> TermsEnumerable { set => Terms = value.ToList(); }
        public TermFacetResult()
        {
            this.Type = IFacetTypes.FindEnum("terms");
        }
    }
}
