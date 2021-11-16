using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class ProductVariantImport : IProductVariantImport
    {
        public string Key { get; set;}
        
        public string Sku { get; set;}
        
        public bool IsMasterVariant { get; set;}
        
        public List<IAttribute> Attributes { get; set;}
        
        public List<IImage> Images { get; set;}
        
        public List<IAsset> Assets { get; set;}
        
        public bool? Publish { get; set;}
        
        public IProductKeyReference Product { get; set;}
    }
}
