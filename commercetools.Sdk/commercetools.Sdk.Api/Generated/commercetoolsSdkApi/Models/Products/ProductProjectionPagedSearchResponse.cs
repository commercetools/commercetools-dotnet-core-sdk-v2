using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Products
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class ProductProjectionPagedSearchResponse : IProductProjectionPagedSearchResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IProductProjection> Results { get; set; }

        public IEnumerable<IProductProjection> ResultsEnumerable { set => Results = value.ToList(); }

        [ObsoleteAttribute("This property is obsolete", false)]
        public IFacetResults Facets { get; set; }
    }
}
