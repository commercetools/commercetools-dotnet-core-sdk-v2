using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public  partial class ProductProjectionPagedSearchResponse : IProductProjectionPagedSearchResponse
    {
        public long Count { get; set;}
        
        public long Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<IProductProjection> Results { get; set;}
        
        public IFacetResults Facets { get; set;}
    }
}
