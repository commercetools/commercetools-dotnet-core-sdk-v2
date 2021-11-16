using System.Collections.Generic;


namespace commercetools.Api.Models.Products
{
    public partial class ProductProjectionPagedSearchResponse : IProductProjectionPagedSearchResponse
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long? Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<IProductProjection> Results { get; set;}
        
        public IFacetResults Facets { get; set;}
    }
}
