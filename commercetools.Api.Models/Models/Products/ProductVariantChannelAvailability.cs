using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class ProductVariantChannelAvailability 
    {
        public bool IsOnStock { get; set;}
        
        public long RestockableInDays { get; set;}
        
        public long AvailableQuantity { get; set;}
    }
}
