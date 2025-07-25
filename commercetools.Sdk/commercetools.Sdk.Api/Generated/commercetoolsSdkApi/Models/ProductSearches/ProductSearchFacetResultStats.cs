using System;

namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchFacetResultStats : IProductSearchFacetResultStats
    {
        public string Name { get; set; }

        public Object Min { get; set; }

        public Object Max { get; set; }

        public Object Mean { get; set; }

        public Object Sum { get; set; }

        public long Count { get; set; }
    }
}
