using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Products
{
    public partial class FacetResultTerm 
    {
        public Object Term { get; set;}
        
        public long Count { get; set;}
        
        public long ProductCount { get; set;}
    }
}
