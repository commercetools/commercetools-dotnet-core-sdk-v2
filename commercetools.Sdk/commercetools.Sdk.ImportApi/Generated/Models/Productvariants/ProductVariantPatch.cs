using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class ProductVariantPatch : IProductVariantPatch
    {
        public IProductVariantKeyReference ProductVariant { get; set;}
        
        public IAttributes Attributes { get; set;}
        
        public bool? Staged { get; set;}
    }
}
