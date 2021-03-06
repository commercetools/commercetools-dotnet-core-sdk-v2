using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductPriceExternalDiscountSetMessagePayload))]
    public partial interface IProductPriceExternalDiscountSetMessagePayload : IMessagePayload
    {
        int VariantId { get; set;}
        
        string VariantKey { get; set;}
        
        string Sku { get; set;}
        
        string PriceId { get; set;}
        
        IDiscountedPrice Discounted { get; set;}
        
        bool Staged { get; set;}
    }
}
