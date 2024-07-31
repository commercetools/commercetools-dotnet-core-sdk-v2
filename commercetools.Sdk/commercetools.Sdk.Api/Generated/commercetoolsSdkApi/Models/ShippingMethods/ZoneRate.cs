using commercetools.Sdk.Api.Models.Zones;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ZoneRate : IZoneRate
    {
        public IZoneReference Zone { get; set; }

        public IList<IShippingRate> ShippingRates { get; set; }

        public IEnumerable<IShippingRate> ShippingRatesEnumerable { set => ShippingRates = value.ToList(); }
    }
}
