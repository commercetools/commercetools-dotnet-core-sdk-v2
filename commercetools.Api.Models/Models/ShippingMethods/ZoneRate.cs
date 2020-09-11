using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShippingMethods
{
    public class ZoneRate 
    {
        public ZoneReference Zone { get; set;}
        
        public List<ShippingRate> ShippingRates { get; set;}
    }
}
