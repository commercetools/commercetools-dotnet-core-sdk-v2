using commercetools.Api.Models.Zones;
using System.Collections.Generic;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ZoneRate : IZoneRate
    {
        public IZoneReference Zone { get; set; }

        public List<IShippingRate> ShippingRates { get; set; }
    }
}
