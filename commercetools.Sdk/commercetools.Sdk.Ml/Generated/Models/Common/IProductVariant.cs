using commercetools.Ml.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.Common
{
    [DeserializeAs(typeof(commercetools.Ml.Models.Common.ProductVariant))]
    public partial interface IProductVariant 
    {
        IProductReference Product { get; set;}
        
        bool Staged { get; set;}
        
        int VariantId { get; set;}
    }
}
