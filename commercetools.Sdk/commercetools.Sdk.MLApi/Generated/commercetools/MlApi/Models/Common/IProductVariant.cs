using commercetools.MLApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.Common.ProductVariant))]
    public partial interface IProductVariant 
    {
        IProductReference Product { get; set;}
        
        bool Staged { get; set;}
        
        int VariantId { get; set;}
    }
}
