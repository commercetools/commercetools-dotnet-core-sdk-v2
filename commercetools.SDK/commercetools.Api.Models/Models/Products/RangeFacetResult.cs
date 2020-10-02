using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("range")]
    public partial class RangeFacetResult : FacetResult
    {
        public List<FacetResultRange> Ranges { get; set;}
        public RangeFacetResult()
        { 
           this.Type = "range";
        }
    }
}
