using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class ShippingRate : IShippingRate
    {
        public IMoney Price { get; set;}
        
        public IMoney FreeAbove { get; set;}
        
        public bool IsMatching { get; set;}
        
        public List<IShippingRatePriceTier> Tiers { get; set;}
    }
}
