using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.MissingAttributesDetails))]
    public partial interface IMissingAttributesDetails 
    {
        int Total { get; set;}
        
        int MissingAttributeNames { get; set;}
        
        int MissingAttributeValues { get; set;}
    }
}
