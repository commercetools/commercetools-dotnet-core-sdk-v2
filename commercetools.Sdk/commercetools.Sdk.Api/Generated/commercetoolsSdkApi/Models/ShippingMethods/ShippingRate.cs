using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingRate : IShippingRate
    {
        public ICentPrecisionMoney Price { get; set; }

        public ICentPrecisionMoney FreeAbove { get; set; }

        public bool? IsMatching { get; set; }

        public IList<IShippingRatePriceTier> Tiers { get; set; }

        public IEnumerable<IShippingRatePriceTier> TiersEnumerable { set => Tiers = value.ToList(); }
    }
}
