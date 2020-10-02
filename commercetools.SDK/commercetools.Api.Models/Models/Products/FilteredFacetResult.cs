using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("filter")]
    public partial class FilteredFacetResult : FacetResult
    {
        public long Count { get; set;}
        
        public long ProductCount { get; set;}
        public FilteredFacetResult()
        { 
           this.Type = "filter";
        }
    }
}
