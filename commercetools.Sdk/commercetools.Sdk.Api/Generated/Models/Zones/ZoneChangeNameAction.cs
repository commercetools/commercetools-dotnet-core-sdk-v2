using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    public partial class ZoneChangeNameAction : IZoneChangeNameAction
    {
        public string Action { get; set; }

        public string Name { get; set; }
        public ZoneChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
