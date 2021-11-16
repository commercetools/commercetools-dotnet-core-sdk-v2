using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingPricesSearchRequest))]
    public partial interface IMissingPricesSearchRequest 
    {
        long? Limit { get; set;}
        
        long? Offset { get; set;}
        
        bool? Staged { get; set;}
        
        long? ProductSetLimit { get; set;}
        
        bool? IncludeVariants { get; set;}
        
        string CurrencyCode { get; set;}
        
        bool? CheckDate { get; set;}
        
        DateTime? ValidFrom { get; set;}
        
        DateTime? ValidUntil { get; set;}
        
        List<string> ProductIds { get; set;}
        
        List<string> ProductTypeIds { get; set;}
    }
}
