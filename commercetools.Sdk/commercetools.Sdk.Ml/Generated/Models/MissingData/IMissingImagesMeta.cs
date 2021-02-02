using commercetools.Ml.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.MissingImagesMeta))]
    public partial interface IMissingImagesMeta 
    {
        IMissingImagesProductLevel ProductLevel { get; set;}
        
        IMissingImagesVariantLevel VariantLevel { get; set;}
        
        long Threshold { get; set;}
    }
}
