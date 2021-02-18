using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.SimilarProducts.ProductSetSelector))]
    public partial interface IProductSetSelector 
    {
        string ProjectKey { get; set;}
        
        List<string> ProductIds { get; set;}
        
        List<string> ProductTypeIds { get; set;}
        
        bool? Staged { get; set;}
        
        bool? IncludeVariants { get; set;}
        
        long? ProductSetLimit { get; set;}
    }
}
