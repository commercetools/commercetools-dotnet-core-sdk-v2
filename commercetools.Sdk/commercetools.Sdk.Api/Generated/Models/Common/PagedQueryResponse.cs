using System;
using System.Collections.Generic;


namespace commercetools.Api.Models.Common
{
    public partial class PagedQueryResponse : IPagedQueryResponse
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long? Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<IBaseResource> Results { get; set;}
        
        public Object Meta { get; set;}
    }
}
