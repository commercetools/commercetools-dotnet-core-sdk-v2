using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.MissingPricesSearchRequest))]
    public partial interface IMissingPricesSearchRequest 
    {
        long? Limit { get; set;}
        
        long? Offset { get; set;}
        
        bool? Staged { get; set;}
        
        long? ProductSetLimit { get; set;}
        
        bool? IncludeVariants { get; set;}
        
        string CurrencyCode { get; set;}
        
        bool? CheckDate { get; set;}
        
        DateTime ValidFrom { get; set;}
        
        DateTime ValidUntil { get; set;}
        
        List<string> ProductIds { get; set;}
        
        List<string> ProductTypeIds { get; set;}
    }
}
