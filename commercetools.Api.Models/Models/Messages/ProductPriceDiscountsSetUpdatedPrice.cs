using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class ProductPriceDiscountsSetUpdatedPrice 
    {
        public int VariantId { get; set;}
        
        public string VariantKey { get; set;}
        
        public string Sku { get; set;}
        
        public string PriceId { get; set;}
        
        public DiscountedPrice Discounted { get; set;}
        
        public bool Staged { get; set;}
    }
}
