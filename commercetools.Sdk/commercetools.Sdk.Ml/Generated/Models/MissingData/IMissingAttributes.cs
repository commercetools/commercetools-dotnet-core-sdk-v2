using commercetools.Ml.Models.Common;
using commercetools.Ml.Models.MissingData;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.MissingAttributes))]
    public partial interface IMissingAttributes 
    {
        IProductReference Product { get; set;}
        
        IProductTypeReference ProductType { get; set;}
        
        int VariantId { get; set;}
        
        List<string> MissingAttributeValues { get; set;}
        
        List<string> MissingAttributeNames { get; set;}
        
        IAttributeCount AttributeCount { get; set;}
        
        IAttributeCoverage AttributeCoverage { get; set;}
    }
}
