using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("range")]
    public class RangeFacetResult : FacetResult
    {
        public List<FacetResultRange> Ranges { get; set;}
    }
}
