using commercetools.MLApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.Common
{
    public partial class ProductVariant : IProductVariant
    {
        public IProductReference Product { get; set;}
        
        public bool Staged { get; set;}
        
        public int VariantId { get; set;}
    }
}
