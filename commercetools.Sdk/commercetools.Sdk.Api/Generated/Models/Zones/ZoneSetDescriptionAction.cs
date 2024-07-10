using commercetools.Sdk.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Zones
{

    public partial class ZoneSetDescriptionAction : IZoneSetDescriptionAction
    {
        public string Action { get; set; }

        public string Description { get; set; }
        public ZoneSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
