using commercetools.Ml.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Ml.Models.MissingData.MissingImages))]
    public partial interface IMissingImages 
    {
        IProductReference Product { get; set;}
        
        long VariantId { get; set;}
        
        long ImageCount { get; set;}
    }
}
