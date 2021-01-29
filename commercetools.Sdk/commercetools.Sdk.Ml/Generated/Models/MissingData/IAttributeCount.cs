using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.AttributeCount))]
    public partial interface IAttributeCount 
    {
        int ProductTypeAttributes { get; set;}
        
        int VariantAttributes { get; set;}
        
        int MissingAttributeValues { get; set;}
    }
}
