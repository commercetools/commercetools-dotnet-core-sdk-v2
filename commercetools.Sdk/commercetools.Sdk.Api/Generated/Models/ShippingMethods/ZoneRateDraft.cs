using commercetools.Sdk.Api.Models.Zones;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    public partial class ZoneRateDraft : IZoneRateDraft
    {
        public IZoneResourceIdentifier Zone { get; set; }

        public List<IShippingRateDraft> ShippingRates { get; set; }
    }
}
