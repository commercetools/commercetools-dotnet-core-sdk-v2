using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.MissingAttributesSearchRequest))]
    public partial interface IMissingAttributesSearchRequest 
    {
        int? Limit { get; set;}
        
        int? Offset { get; set;}
        
        bool? Staged { get; set;}
        
        int? ProductSetLimit { get; set;}
        
        bool? IncludeVariants { get; set;}
        
        double? CoverageMin { get; set;}
        
        double? CoverageMax { get; set;}
        
        string SortBy { get; set;}
        
        bool? ShowMissingAttributeNames { get; set;}
        
        List<string> ProductIds { get; set;}
        
        List<string> ProductTypeIds { get; set;}
        
        string AttributeName { get; set;}
    }
}
