using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingRateDraft : IShippingRateDraft
    {
        public IMoney Price { get; set;}
        
        public IMoney FreeAbove { get; set;}
        
        public List<IShippingRatePriceTier> Tiers { get; set;}
    }
}
