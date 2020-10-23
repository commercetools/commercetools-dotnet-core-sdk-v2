using commercetools.Api.Generated.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ProductTypes
{
    public interface IProductTypePagedQueryResponse 
    {
        long Limit { get; set;}
        
        long Count { get; set;}
        
        long Total { get; set;}
        
        long Offset { get; set;}
        
        List<IProductType> Results { get; set;}
    }
}
