using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class TermFacetResult : FacetResult
    {
        public TermFacetResultType DataType { get; set;}
        
        public long Missing { get; set;}
        
        public long Total { get; set;}
        
        public long Other { get; set;}
        
        public List<FacetResultTerm> Terms { get; set;}
    }
}
