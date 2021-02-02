using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.MissingImagesSearchRequest))]
    public partial interface IMissingImagesSearchRequest 
    {
        long? Limit { get; set;}
        
        long? Offset { get; set;}
        
        bool? Staged { get; set;}
        
        long? ProductSetLimit { get; set;}
        
        bool? IncludeVariants { get; set;}
        
        bool? AutoThreshold { get; set;}
        
        long? Threshold { get; set;}
        
        List<string> ProductIds { get; set;}
        
        List<string> ProductTypeIds { get; set;}
    }
}
