using commercetools.Sdk.Api.Models.Zones;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ZoneRate))]
    public partial interface IZoneRate
    {
        IZoneReference Zone { get; set; }

        List<IShippingRate> ShippingRates { get; set; }

    }
}
