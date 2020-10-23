using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductVariantAvailability))]
    public interface IProductVariantAvailability 
    {
        bool IsOnStock { get; set;}
        
        long RestockableInDays { get; set;}
        
        long AvailableQuantity { get; set;}
        
        IProductVariantChannelAvailabilityMap Channels { get; set;}
    }
}
