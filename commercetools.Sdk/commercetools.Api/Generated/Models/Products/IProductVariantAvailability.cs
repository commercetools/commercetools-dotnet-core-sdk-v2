using commercetools.Api.Generated.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductVariantAvailability 
    {
        bool IsOnStock { get; set;}
        
        long RestockableInDays { get; set;}
        
        long AvailableQuantity { get; set;}
        
        IProductVariantChannelAvailabilityMap Channels { get; set;}
    }
}
