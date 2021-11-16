using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    public partial class ZoneUpdateAction : IZoneUpdateAction
    {
        public string Action { get; set;}
    }
}
