using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodAddZoneAction : IShippingMethodAddZoneAction
    {
        public string Action { get; set; }

        public IZoneResourceIdentifier Zone { get; set; }
        public ShippingMethodAddZoneAction()
        {
            this.Action = "addZone";
        }
    }
}
