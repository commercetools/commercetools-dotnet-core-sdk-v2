using System.Collections.Generic;


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
