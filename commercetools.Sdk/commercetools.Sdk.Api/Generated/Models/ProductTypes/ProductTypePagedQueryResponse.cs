using System.Collections.Generic;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypePagedQueryResponse : IProductTypePagedQueryResponse
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long? Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<IProductType> Results { get; set;}
    }
}
