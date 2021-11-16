using commercetools.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingRateDraft : IShippingRateDraft
    {
        public IMoney Price { get; set;}
        
        public IMoney FreeAbove { get; set;}
        
        public List<IShippingRatePriceTier> Tiers { get; set;}
    }
}
