using commercetools.Ml.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.MissingAttributesMeta))]
    public partial interface IMissingAttributesMeta 
    {
        IMissingAttributesDetails ProductLevel { get; set;}
        
        IMissingAttributesDetails VariantLevel { get; set;}
        
        List<string> ProductTypeIds { get; set;}
    }
}
