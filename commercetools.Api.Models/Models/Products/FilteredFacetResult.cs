using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class FilteredFacetResult : FacetResult
    {
        public long Count { get; set;}
        
        public long ProductCount { get; set;}
    }
}
