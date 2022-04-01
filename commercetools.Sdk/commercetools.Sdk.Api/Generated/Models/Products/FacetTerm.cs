using System;


namespace commercetools.Sdk.Api.Models.Products
{
    public partial class FacetTerm : IFacetTerm
    {
        public Object Term { get; set; }

        public long Count { get; set; }

        public long? ProductCount { get; set; }
    }
}
