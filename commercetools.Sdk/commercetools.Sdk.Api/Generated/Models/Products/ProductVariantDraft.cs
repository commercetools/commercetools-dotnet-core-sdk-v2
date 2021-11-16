using commercetools.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Api.Models.Products
{
    public partial class ProductVariantDraft : IProductVariantDraft
    {
        public string Sku { get; set;}
        
        public string Key { get; set;}
        
        public List<IPriceDraft> Prices { get; set;}
        
        public List<IAttribute> Attributes { get; set;}
        
        public List<IImage> Images { get; set;}
        
        public List<IAssetDraft> Assets { get; set;}
    }
}
