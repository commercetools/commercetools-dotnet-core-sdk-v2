using commercetools.Sdk.Api.Models.Zones;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ZoneRate : IZoneRate
    {
        public IZoneReference Zone { get; set; }

        public List<IShippingRate> ShippingRates { get; set; }
    }
}
