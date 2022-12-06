using commercetools.Sdk.Api.Models.Zones;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ZoneRateDraft))]
    public partial interface IZoneRateDraft
    {
        IZoneResourceIdentifier Zone { get; set; }

        IList<IShippingRateDraft> ShippingRates { get; set; }
        IEnumerable<IShippingRateDraft> ShippingRatesEnumerable { set => ShippingRates = value.ToList(); }


    }
}
