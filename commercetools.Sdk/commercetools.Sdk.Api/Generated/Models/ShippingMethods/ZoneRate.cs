using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ZoneRate : IZoneRate
    {
        public IZoneReference Zone { get; set;}
        
        public List<IShippingRate> ShippingRates { get; set;}
    }
}
