using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class RangeFacetResult : IRangeFacetResult
    {
        public IFacetTypes Type { get; set;}
        
        public List<IFacetResultRange> Ranges { get; set;}
        public RangeFacetResult()
        { 
           this.Type = IFacetTypes.FindEnum("range");
        }
    }
}
