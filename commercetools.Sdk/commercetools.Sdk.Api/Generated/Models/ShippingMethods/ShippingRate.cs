using commercetools.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingRate : IShippingRate
    {
        public ITypedMoney Price { get; set; }

        public ITypedMoney FreeAbove { get; set; }

        public bool? IsMatching { get; set; }

        public List<IShippingRatePriceTier> Tiers { get; set; }
    }
}
