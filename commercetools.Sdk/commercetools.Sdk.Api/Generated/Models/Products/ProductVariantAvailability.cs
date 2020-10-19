using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Products
{
    public partial class ProductVariantAvailability 
    {
        public bool IsOnStock { get; set;}
        
        public long RestockableInDays { get; set;}
        
        public long AvailableQuantity { get; set;}
        
        public ProductVariantChannelAvailabilityMap Channels { get; set;}
    }
}
