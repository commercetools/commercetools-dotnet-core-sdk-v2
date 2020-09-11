using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class FacetResultTerm 
    {
        public Object Term { get; set;}
        
        public long Count { get; set;}
        
        public long ProductCount { get; set;}
    }
}
