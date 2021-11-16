using commercetools.Api.Models.Zones;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ZoneRateDraft))]
    public partial interface IZoneRateDraft 
    {
        IZoneResourceIdentifier Zone { get; set;}
        
        List<IShippingRateDraft> ShippingRates { get; set;}
    }
}
