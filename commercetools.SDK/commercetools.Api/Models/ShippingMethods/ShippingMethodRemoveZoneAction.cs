using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("removeZone")]
    public partial class ShippingMethodRemoveZoneAction : ShippingMethodUpdateAction
    {
        public ZoneResourceIdentifier Zone { get; set;}
        public ShippingMethodRemoveZoneAction()
        { 
           this.Action = "removeZone";
        }
    }
}
