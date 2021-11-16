using System.Collections.Generic;


namespace commercetools.Api.Models.Categories
{
    public partial class CategoryPagedQueryResponse : ICategoryPagedQueryResponse
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long? Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<ICategory> Results { get; set;}
    }
}
