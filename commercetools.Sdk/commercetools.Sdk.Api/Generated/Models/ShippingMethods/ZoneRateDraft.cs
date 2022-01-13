using commercetools.Api.Models.Zones;
using System.Collections.Generic;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ZoneRateDraft : IZoneRateDraft
    {
        public IZoneResourceIdentifier Zone { get; set; }

        public List<IShippingRateDraft> ShippingRates { get; set; }
    }
}
