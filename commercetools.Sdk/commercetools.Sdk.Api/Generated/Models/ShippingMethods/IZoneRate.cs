using commercetools.Api.Models.Zones;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ZoneRate))]
    public partial interface IZoneRate 
    {
        IZoneReference Zone { get; set;}
        
        List<IShippingRate> ShippingRates { get; set;}
    }
}
