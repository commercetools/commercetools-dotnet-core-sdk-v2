using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Api.Models.Zones.ZoneSetDescriptionAction))]
    public partial interface IZoneSetDescriptionAction : IZoneUpdateAction
    {
        string Description { get; set;}
    }
}
