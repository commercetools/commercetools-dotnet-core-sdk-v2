using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.Ml.Models.SimilarProducts.SimilarityMeasures))]
    public partial interface ISimilarityMeasures 
    {
        long? Name { get; set;}
        
        long? Description { get; set;}
        
        long? Attribute { get; set;}
        
        long? VariantCount { get; set;}
        
        long? Price { get; set;}
    }
}
