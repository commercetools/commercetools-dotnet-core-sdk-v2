using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.FacetResultTerm))]
    public interface IFacetResultTerm 
    {
        Object Term { get; set;}
        
        long Count { get; set;}
        
        long? ProductCount { get; set;}
    }
}
