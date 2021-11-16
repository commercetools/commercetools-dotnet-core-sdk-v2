using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class FilteredFacetResult : IFilteredFacetResult
    {
        public IFacetTypes Type { get; set;}
        
        public long Count { get; set;}
        
        public long? ProductCount { get; set;}
        public FilteredFacetResult()
        { 
           this.Type = IFacetTypes.FindEnum("filter");
        }
    }
}
