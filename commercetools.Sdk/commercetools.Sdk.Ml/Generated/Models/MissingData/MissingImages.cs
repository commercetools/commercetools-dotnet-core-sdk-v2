using commercetools.Ml.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    public partial class MissingImages : IMissingImages
    {
        public IProductReference Product { get; set;}
        
        public long VariantId { get; set;}
        
        public long ImageCount { get; set;}
    }
}
