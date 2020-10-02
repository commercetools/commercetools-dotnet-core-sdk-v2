using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("addZone")]
    public partial class ShippingMethodAddZoneAction : ShippingMethodUpdateAction
    {
        public ZoneResourceIdentifier Zone { get; set;}
        public ShippingMethodAddZoneAction()
        { 
           this.Action = "addZone";
        }
    }
}
