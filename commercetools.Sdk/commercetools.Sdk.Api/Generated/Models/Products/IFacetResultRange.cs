using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.FacetResultRange))]
    public interface IFacetResultRange 
    {
        double From { get; set;}
        
        string FromStr { get; set;}
        
        double To { get; set;}
        
        string ToStr { get; set;}
        
        long Count { get; set;}
        
        long ProductCount { get; set;}
        
        long Total { get; set;}
        
        double Min { get; set;}
        
        double Max { get; set;}
        
        double Mean { get; set;}
    }
}
