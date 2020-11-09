using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductProjectionPagedSearchResponse))]
    public partial interface IProductProjectionPagedSearchResponse 
    {
        long Count { get; set;}
        
        long? Total { get; set;}
        
        long Offset { get; set;}
        
        List<IProductProjection> Results { get; set;}
        
        IFacetResults Facets { get; set;}
    }
}
