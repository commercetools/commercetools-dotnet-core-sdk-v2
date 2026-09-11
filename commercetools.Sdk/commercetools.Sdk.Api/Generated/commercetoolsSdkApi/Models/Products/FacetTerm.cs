using System;

namespace commercetools.Sdk.Api.Models.Products
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class FacetTerm : IFacetTerm
    {
        public Object Term { get; set; }

        public long Count { get; set; }

        public long? ProductCount { get; set; }
    }
}
