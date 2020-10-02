using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("addShippingRate")]
    public partial class ShippingMethodAddShippingRateAction : ShippingMethodUpdateAction
    {
        public ZoneResourceIdentifier Zone { get; set;}
        
        public ShippingRateDraft ShippingRate { get; set;}
        public ShippingMethodAddShippingRateAction()
        { 
           this.Action = "addShippingRate";
        }
    }
}
