using commercetools.Sdk.Api.Models.Zones;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ZoneRateDraft : IZoneRateDraft
    {
        public IZoneResourceIdentifier Zone { get; set; }

        public IList<IShippingRateDraft> ShippingRates { get; set; }

        public IEnumerable<IShippingRateDraft> ShippingRatesEnumerable { set => ShippingRates = value.ToList(); }
    }
}
