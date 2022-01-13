using System;


namespace commercetools.Api.Models.Products
{
    public partial class FacetResultTerm : IFacetResultTerm
    {
        public Object Term { get; set; }

        public long Count { get; set; }

        public long? ProductCount { get; set; }
    }
}
