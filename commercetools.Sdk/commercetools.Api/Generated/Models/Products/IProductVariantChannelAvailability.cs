using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductVariantChannelAvailability 
    {
        bool IsOnStock { get; set;}
        
        long RestockableInDays { get; set;}
        
        long AvailableQuantity { get; set;}
    }
}
