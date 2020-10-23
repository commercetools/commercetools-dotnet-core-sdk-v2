using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IProductPriceExternalDiscountSetMessagePayload : IMessagePayload
    {
        int VariantId { get; set;}
        
        string VariantKey { get; set;}
        
        string Sku { get; set;}
        
        string PriceId { get; set;}
        
        IDiscountedPrice Discounted { get; set;}
        
        bool Staged { get; set;}
    }
}
