using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public class FacetResultRange 
    {
        public double From { get; set;}
        
        public string FromStr { get; set;}
        
        public double To { get; set;}
        
        public string ToStr { get; set;}
        
        public long Count { get; set;}
        
        public long ProductCount { get; set;}
        
        public long Total { get; set;}
        
        public double Min { get; set;}
        
        public double Max { get; set;}
        
        public double Mean { get; set;}
    }
}
