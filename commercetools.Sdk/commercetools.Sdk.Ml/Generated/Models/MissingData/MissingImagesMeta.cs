using commercetools.Ml.Models.MissingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    public partial class MissingImagesMeta : IMissingImagesMeta
    {
        public IMissingImagesProductLevel ProductLevel { get; set;}
        
        public IMissingImagesVariantLevel VariantLevel { get; set;}
        
        public long Threshold { get; set;}
    }
}
