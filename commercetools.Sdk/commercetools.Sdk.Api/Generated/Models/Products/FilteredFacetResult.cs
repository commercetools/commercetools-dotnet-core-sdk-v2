using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public  partial class FilteredFacetResult : IFilteredFacetResult
    {
        public string Type { get; set;}
        
        [JsonIgnore]
        public FacetTypes TypeAsEnum => this.Type.GetEnum<FacetTypes>();
        
        public long Count { get; set;}
        
        public long ProductCount { get; set;}
        public FilteredFacetResult()
        { 
           this.Type = "filter";
        }
    }
}
